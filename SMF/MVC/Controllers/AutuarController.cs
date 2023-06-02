using Application.Interfaces;
//using AspNetCore;
using AutoMapper;
using Domain.Entities;
using Infra.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC.Extensions;
using MVC.ViewModels;
using System.Runtime.Intrinsics.X86;

namespace MVC.Controllers
{
    [Authorize]
    public class AutuarController : Controller
    {
        private readonly ContextoAplicacao _context;
        private readonly IImovelAppService imovelAppService;
        private readonly IEconomiaAppService economiaAppService;
        private readonly IEconomia_EntidadeAppService economia_EntidadeAppService;
        private readonly IEndereco_EntidadeAppService endereco_EntidadeAppService;
        private readonly IPessoaAppService pessoaAppService;
        private readonly IIncrementoTabelasAppService incrementoTabelasAppService;
        IMapper mapper;
        public AutuarController(IImovelAppService imovelAppService, IMapper mapper, IEconomiaAppService economiaAppService, IEconomia_EntidadeAppService economia_EntidadeAppService, IPessoaAppService pessoaAppService, IEndereco_EntidadeAppService endereco_EntidadeAppService, ContextoAplicacao context, IIncrementoTabelasAppService incrementoTabelasAppService)
        {
            this.imovelAppService = imovelAppService;
            this.mapper = mapper;
            this.economiaAppService = economiaAppService;
            this.economia_EntidadeAppService = economia_EntidadeAppService;
            this.pessoaAppService = pessoaAppService;
            this.endereco_EntidadeAppService = endereco_EntidadeAppService;
            _context = context;
            this.incrementoTabelasAppService = incrementoTabelasAppService;
        }
        public ActionResult Index()
        {
            return View(new ImovelViewModel() );
        }
        // GET: AutuarController

        [HttpPost]
        public ActionResult Imovel(ImovelViewModel imovel)
        {
            //var contextoAplicacao = _context.dbSEnderecos.Include(e => e.Bairro).Include(e => e.Cidade).Include(e => e.Logradouro);
            
            var queryimovel = from s in imovelAppService.GetIQueryable().Filter(imovel.ImovelId.ToString()) select s;
            var queryeconomias = from s in economiaAppService.GetIQueryable().Filter(imovel.ImovelId.ToString()) select s;
            var imovelDO = queryimovel.AsNoTracking().FirstOrDefault();
            if (imovelDO == null)
            {
                this.MostrarMensagem("O Imóvel de inscrição: " + imovel.ImovelId + " Não Existe!");
                return RedirectToAction("Index");
            }
            
            
            //var economiasDO = queryeconomias.AsNoTracking().ToList();
            ImovelViewModel ivm = mapper.Map<ImovelViewModel>(imovelDO);
            ivm.EconomiasImovel = queryeconomias.AsNoTracking().ToList();


            //ImovelViewModel imovelvm = mapper.Map<ImovelViewModel>(imovelAppService.Find(imovel.ImovelId));
            //ImovelViewModel imovelvm = mapper.Map<ImovelViewModel>(imovel.);
            //ServidorViewModel servidor = new ServidorViewModel();

            //return View(mapper.Map<ImovelViewModel>(imovelDO));
            return View(ivm);
        }
        public ActionResult Economia(long ImovelId, long EconomiaId)
        {
            var queryeconomia = from s in economiaAppService.GetIQueryable().Filter(i => i.ImovelId == ImovelId && i.EconomiaId == EconomiaId) select s;
            var economiaDO = queryeconomia.AsNoTracking().FirstOrDefault();
            EconomiaViewModel evm = mapper.Map<EconomiaViewModel>(economiaDO);
            //evm.Pessoas = queryeconomia_Entidade.AsNoTracking().ToList();
            evm.Pessoas = economia_EntidadeAppService.GetTodos().Where(i => i.ImovelId == ImovelId && i.EconomiaId == EconomiaId).Include(p => p.Pessoa).ThenInclude(tp=>tp.TipoPessoa).ToList();
            //var economiaDO = queryeconomia.AsNoTracking().ToList();
            return View(evm);
        }
        
        public ActionResult Autuar(long ImovelId, long EconomiaId,long PessoaId,long conId)
        {
            var matriculaservidorId = User.Claims.FirstOrDefault().Value;
            var Servidor = _context.dbSServidores.Where(m => m.Matricula == matriculaservidorId && m.Ativo == true).Include(tp=>tp.PodeExecutar).ThenInclude(tp=>tp.TipoProcesso).Include(d=>d.Divisao).ThenInclude(u=>u.Unidade).ThenInclude(o=>o.Orgao).FirstOrDefault();
            //var UnidadeServidor = _context.dbSUnidades.Where(u => u.UnidadeId == Servidor.UnidadeId).FirstOrDefault();


            ViewData["FluxoProcessoId"] = new SelectList(_context.dbSFluxosProcesso, "FluxoProcessoId", "Descricao");
            ViewData["OrgaoId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "Descricao", Servidor.Divisao.Unidade.OrgaoId);
            ViewData["OrgaoDestinatarioId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "Descricao", Servidor.Divisao.Unidade.OrgaoId);
            ViewData["OrgaoRemetenteId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "Descricao", Servidor.Divisao.Unidade.OrgaoId);
            ViewData["SituacaoProcessoId"] = new SelectList(_context.dbSSituacoesProcesso, "SituacaoProcessoId", "Descricao");
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "Descricao");
            //ViewData["TipoProcessoId"] = new SelectList(Servidor.PodeExecutar.ToList(), "TipoProcessoId", "Descricao");
            ViewData["UnidadeId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "Descricao", Servidor.Divisao.UnidadeId);
            ViewData["UnidadeDestinatarioId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "Descricao", Servidor.Divisao.UnidadeId);
            ViewData["UnidadeRemetenteId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "Descricao", Servidor.Divisao.UnidadeId);
            //
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "Descricao",Servidor.ServidorId);
            ViewData["SituacaoEtapaId"] = new SelectList(_context.dbSSituacoesEtapa, "SituacaoEtapaId", "Descricao");
            ViewData["TipoEtapaId"] = new SelectList(_context.dbSTiposEtapa, "TipoEtapaId", "Descricao");


            var  entidadeId = long.Parse(String.Concat(ImovelId.ToString() + EconomiaId.ToString().PadLeft(3, '0')));
            var economia = economiaAppService.GetIQueryable().Where(e => e.ImovelId == ImovelId && e.EconomiaId == EconomiaId).FirstOrDefault();
          

            //var pessoa = pessoaAppService.GetIQueryable().Where(p => p.PessoaId == PessoaId).Include(e=>e.Enderecos).ThenInclude(e=>e.Endereco).ThenInclude(l=>l.Logradouro).ThenInclude(tl=>tl.TipoLogradouro).Include(tp=>tp.TipoPessoa).FirstOrDefault();
            var pessoa = pessoaAppService.GetIQueryable().Where(p => p.PessoaId == PessoaId).Include(tp=>tp.TipoPessoa).FirstOrDefault();
            var enderecoseconomia = endereco_EntidadeAppService.GetIQueryable().Where(s => s.EntidadeId == entidadeId).Include(e=>e.Endereco).ThenInclude(l=>l.Logradouro).ThenInclude(tl => tl.TipoLogradouro).ToList();
            var enderecospessoa = endereco_EntidadeAppService.GetIQueryable().Where(s => s.EntidadeId == conId && s.ImovelId==ImovelId && s.EconomiaId==EconomiaId).Include(e => e.Endereco).ThenInclude(l => l.Logradouro).ThenInclude(tl => tl.TipoLogradouro).ToList();
            economia.Enderecos = enderecoseconomia;
            pessoa.Enderecos = enderecospessoa;
            AutuarViewModel avm = new AutuarViewModel()
            {
                Economia = economia,
                Pessoa = pessoa
                
            };
            //_context.DisposeAsync();
            return View(avm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Autuar(AutuarViewModel avm)
        {
            var matriculaservidorId = User.Claims.FirstOrDefault().Value;
            var Servidor = _context.dbSServidores.Where(m => m.Matricula == matriculaservidorId && m.Ativo == true).Include(tp => tp.PodeExecutar).ThenInclude(tp => tp.TipoProcesso).Include(d => d.Divisao).ThenInclude(u => u.Unidade).ThenInclude(o => o.Orgao).FirstOrDefault();
            if (ModelState.IsValid)
            {
                //if(_context.dbSProcessos.Find())
                //if(ProcessoExists)
                Processo processo = new Processo()
                {
                    ProcessoId = incrementoTabelasAppService.Incrementar("Processo", "Sistema", "2023"),
                    ObjetoProcesso = new ObjetoProcesso()
                    {
                        TipoObjetoProcesso = 1,
                        DescricaoObjetoProcesso="Ainda não Definido!",
                        ImovelId = avm.Economia.ImovelId,
                        EconomiaId = avm.Economia.EconomiaId,
                        PessoaId = avm.Pessoa.PessoaId,
                        EnderecoId = avm.EnderecoPessoaAutuado.EnderecoId
                    },
                    
                    OrgaoId = Servidor.Divisao.Unidade.OrgaoId,
                    UnidadeId = Servidor.Divisao.UnidadeId,
                    DivisaoId = Servidor.DivisaoId,
                    ServidorId = Servidor.ServidorId,
                    OrgaoRemetenteId = Servidor.Divisao.Unidade.OrgaoId,
                    UnidadeRemetenteId = Servidor.Divisao.UnidadeId,
                    DivisaoRemetenteId = Servidor.DivisaoId,
                    OrgaoDestinatarioId = Servidor.Divisao.Unidade.OrgaoId,
                    UnidadeDestinatarioId = Servidor.Divisao.UnidadeId,
                    DivisaoDestinatarioId = Servidor.DivisaoId,
                    SituacaoProcessoId = avm.Processo.SituacaoProcessoId,
                    TipoProcessoId = avm.Processo.TipoProcessoId,
                    ObservacaoProcesso = avm.Etapa.ObservacaoEtapa
                    

                };
                Etapa etapa = new Etapa() {
                    ProcessoId = processo.ProcessoId,
                    TipoProcessoId=avm.Processo.TipoProcessoId,
                    SituacaoEtapaId = avm.Etapa.SituacaoEtapaId,

                    FluxoProcessoId = 4,   /////////////
                    //TipoProcessoId = processo.TipoProcessoId,
                    ServidorId = Servidor.ServidorId,
                    Ano="2023",
                    antigo=false,
                    ObservacaoEtapa=avm.Etapa.ObservacaoEtapa,
                };
                

                _context.Add(etapa);
                _context.AddRange(processo);
                economiaAppService.UpdateEconomiaTemProcessos(new Economia() { ImovelId = avm.Economia.ImovelId, EconomiaId = avm.Economia.EconomiaId });
                _context.SaveChanges();
                //_context.DisposeAsync();
            }


            return View("Index",new ImovelViewModel());
        }

        public ActionResult DetalhesProcesso(long ProcessoID)
        {
            var processo = _context.dbSProcessos.Where(p => p.ProcessoId== ProcessoID)
                                                       .Include(o => o.Orgao).Include(u => u.Unidade).Include(d => d.Divisao)
                                                       .Include(o => o.OrgaoRemetente).Include(u => u.UnidadeRemetente).Include(d => d.DivisaoRemetente)
                                                       .Include(o => o.OrgaoDestinatario).Include(u => u.UnidadeDestinatario).Include(d => d.DivisaoDestinatario)
                                                       .Include(s => s.Servidor)
                                                       .Include(tp => tp.TipoProcesso)
                                                       .Include(sp => sp.SituacaoProcesso)
                                                       .Include(e => e.ObjetoProcesso).ThenInclude(e => e.Economia).FirstOrDefault();
            return View(processo);

            
        }

        // GET: AutuarController/Details/5
        public ActionResult Processos(long ImovelId,long EconomiaId)
        {
            var processos = _context.dbSProcessos.Join(_context.dbSObjetosProcesso, processo => processo.ProcessoId,
             objeto => objeto.ProcessoId,(processo, objetoprocesso) => new { Processo = processo, ObjetoProcesso = objetoprocesso })
                .Where(resultado => resultado.ObjetoProcesso.ImovelId == ImovelId && resultado.ObjetoProcesso.EconomiaId==EconomiaId)
               .Select(resultado => resultado.Processo).Include(o=>o.Orgao).Include(u=>u.Unidade).Include(d=>d.Divisao)
                                                       .Include(o => o.OrgaoRemetente).Include(u => u.UnidadeRemetente).Include(d => d.DivisaoRemetente)
                                                       .Include(o => o.OrgaoDestinatario).Include(u => u.UnidadeDestinatario).Include(d => d.DivisaoDestinatario)
                                                       .Include(s=>s.Servidor)
                                                       .Include(tp=>tp.TipoProcesso)
                                                       .Include(sp=>sp.SituacaoProcesso)
                                                       .Include(e=>e.ObjetoProcesso).ThenInclude(e=>e.Economia)
                                                        .ToList();  
            return View(processos);
        }
        // GET: AutuarController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AutuarController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AutuarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AutuarController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AutuarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AutuarController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AutuarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        private bool ProcessoExists(long id)
        {
            return (_context.dbSProcessos?.Any(e => e.ProcessoId == id)).GetValueOrDefault();
        }
        
    }
}
