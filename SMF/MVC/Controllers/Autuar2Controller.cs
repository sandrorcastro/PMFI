using Application.Interfaces;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using Infra.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC.Extensions;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class Autuar2Controller : Controller
    {
        private readonly ContextoAplicacao _context;
        private readonly IImovelAppService imovelAppService;
        private readonly IEconomiaAppService economiaAppService;
     
        private readonly IEconomia_EntidadeAppService economia_EntidadeAppService;
        private readonly IEndereco_EntidadeAppService endereco_EntidadeAppService;
        private readonly IProcessoAppService processoAppService;
        private readonly IObjetoProcessoAppService objetoProcessoAppService;

        private readonly IPessoaAppService pessoaAppService;
        private readonly IIncrementoTabelasAppService incrementoTabelasAppService;
        IMapper mapper;

        public Autuar2Controller(IMapper mapper, IImovelAppService imovelAppService, IEconomiaAppService economiaAppService, IProcessoAppService processoAppService, IObjetoProcessoAppService objetoProcessoAppService, ContextoAplicacao context, IEconomia_EntidadeAppService economia_EntidadeAppService, IPessoaAppService pessoaAppService, IEndereco_EntidadeAppService endereco_EntidadeAppService)
        {
            this.mapper = mapper;
            this.imovelAppService = imovelAppService;
            this.economiaAppService = economiaAppService;
            this.processoAppService = processoAppService;
            this.objetoProcessoAppService = objetoProcessoAppService;
            _context = context;
            this.economia_EntidadeAppService = economia_EntidadeAppService;
            this.pessoaAppService = pessoaAppService;
            this.endereco_EntidadeAppService = endereco_EntidadeAppService;
        }

        // GET: Autuar2Controller
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Imovel(ImovelViewModel imovel)
        {
            var queryimovel = from s in imovelAppService.GetIQueryable().Filter(imovel.ImovelId.ToString()).Include(e=>e.Economias).ThenInclude(e=>e.Economia) select s;
            //var queryeconomias = from s in economiaAppService.GetIQueryable().Filter(imovel.ImovelId.ToString()) select s;
            var imovelDO = queryimovel.AsNoTracking().FirstOrDefault();
            if (imovelDO == null)
            {
                this.MostrarMensagem("O Imóvel de inscrição: " + imovel.ImovelId + " Não Existe!");
                return RedirectToAction("Index");
            }
            //var economiasDO = queryeconomias.AsNoTracking().ToList();
            ImovelViewModel ivm = mapper.Map<ImovelViewModel>(imovelDO);
            //ivm.EconomiasImovel = queryeconomias.AsNoTracking().ToList();
            //ImovelViewModel imovelvm = mapper.Map<ImovelViewModel>(imovelAppService.Find(imovel.ImovelId));
            //ImovelViewModel imovelvm = mapper.Map<ImovelViewModel>(imovel.);
            //ServidorViewModel servidor = new ServidorViewModel();
            //return View(mapper.Map<ImovelViewModel>(imovelDO));
            return View(ivm);
        }

        public ActionResult Processos(long ImovelId , long EconomiaId)
        {
            var processos = _context.dbSProcessos.Join(_context.dbSObjetosProcesso, processo => processo.ProcessoId,
             objeto => objeto.ProcessoId, (processo, objetoprocesso) => new { Processo = processo, ObjetoProcesso = objetoprocesso })
                .Where(resultado => resultado.ObjetoProcesso.ImovelId == ImovelId && resultado.ObjetoProcesso.EconomiaId == EconomiaId)
               .Select(resultado => resultado.Processo).Include(o => o.Orgao).Include(u => u.Unidade).Include(d => d.Divisao)
                                                       .Include(o => o.OrgaoRemetente).Include(u => u.UnidadeRemetente).Include(d => d.DivisaoRemetente)
                                                       .Include(o => o.OrgaoDestinatario).Include(u => u.UnidadeDestinatario).Include(d => d.DivisaoDestinatario)
                                                       .Include(s => s.Servidor)
                                                       .Include(tp => tp.TipoProcesso)
                                                       .Include(sp => sp.SituacaoProcesso)
                                                       .Include(e => e.ObjetoProcesso).ThenInclude(e => e.Economia)
                                                       .Include(e => e.ObjetoProcesso).ThenInclude(e => e.Pessoa)
                                                       .Include(e => e.ObjetoProcesso).ThenInclude(e => e.Endereco)
                                                       .ToList();

            ViewData["ImovelId"] = ImovelId.ToString();
            ViewData["EconomiaId"] = EconomiaId.ToString();

            return View(processos);
        }
        public ActionResult Economia(long ImovelId, long EconomiaId)
        {
            var queryeconomia = from s in economiaAppService.GetIQueryable().Filter(i => i.ImovelId == ImovelId && i.EconomiaId == EconomiaId) select s;
            var economiaDO = queryeconomia.AsNoTracking().FirstOrDefault();
            EconomiaViewModel evm = mapper.Map<EconomiaViewModel>(economiaDO);
            //evm.Pessoas = queryeconomia_Entidade.AsNoTracking().ToList();
            evm.Pessoas = economia_EntidadeAppService.GetTodos().Where(i => i.ImovelId == ImovelId && i.EconomiaId == EconomiaId).Include(p => p.Pessoa).ThenInclude(tp => tp.TipoPessoa).ToList();
            //var economiaDO = queryeconomia.AsNoTracking().ToList();
            return View(evm);
        }

        public ActionResult Movimentos(long ProcessoId)
        {

            var movimentos = _context.dbSEtapas.Where(p => p.ProcessoId == ProcessoId).Include(p => p.Processo)
                                                                                      .Include(tp => tp.TipoProcesso)
                                                                                      .Include(fp => fp.FluxoProcesso)
                                                                                      .Include(se => se.SituacaoEtapa).ToList();
            var processo = _context.dbSProcessos.Where(p => p.ProcessoId == ProcessoId).Include(p => p.ObjetoProcesso).ThenInclude(p => p.Pessoa)
                                                                                      //.Include(fp => fp.FluxoProcesso)
                                                                                      //.Include(se => se.SituacaoEtapa)
                                                                                      .FirstOrDefault();
            ViewData["ProcessoId"] = processo.ProcessoId;
            ViewData["ImovelId"] = processo.ObjetoProcesso.ImovelId;
            ViewData["EconomiaId"] = processo.ObjetoProcesso.EconomiaId;
            ViewData["PessoaId"] = processo.ObjetoProcesso.PessoaId;
            ViewData["conId"] = processo.ObjetoProcesso.Pessoa.conId;

            return View(movimentos);
        }
        public ActionResult Autuar(long ImovelId, long EconomiaId, long PessoaId, long conId, long? ProcessoId,bool? TemProcessos)
        {
            var matriculaservidorId = User.Claims.FirstOrDefault().Value;
            var Servidor = _context.dbSServidores.Where(m => m.Matricula == matriculaservidorId && m.Ativo == true).Include(tp => tp.PodeExecutar).ThenInclude(tp => tp.TipoProcesso).Include(d => d.Divisao).ThenInclude(u => u.Unidade).ThenInclude(o => o.Orgao).FirstOrDefault();
            var entidadeId = long.Parse(String.Concat(ImovelId.ToString() + EconomiaId.ToString().PadLeft(3, '0')));
            var economia = economiaAppService.GetIQueryable().Where(e => e.ImovelId == ImovelId && e.EconomiaId == EconomiaId).FirstOrDefault();
            var pessoa = pessoaAppService.GetIQueryable().Where(p => p.PessoaId == PessoaId).Include(tp => tp.TipoPessoa).FirstOrDefault();
            var enderecoseconomia = endereco_EntidadeAppService.GetIQueryable().Where(s => s.EntidadeId == entidadeId).Include(e => e.Endereco).ThenInclude(l => l.Logradouro).ThenInclude(tl => tl.TipoLogradouro).ToList();
            var enderecospessoa = endereco_EntidadeAppService.GetIQueryable().Where(s => s.EntidadeId == conId && s.ImovelId == ImovelId && s.EconomiaId == EconomiaId).Include(e => e.Endereco).ThenInclude(l => l.Logradouro).ThenInclude(tl => tl.TipoLogradouro).ToList();
            economia.Enderecos = enderecoseconomia;
            economia.TemProcessos = TemProcessos==null?false:TemProcessos;
            pessoa.Enderecos = enderecospessoa;
            //var UnidadeServidor = _context.dbSUnidades.Where(u => u.UnidadeId == Servidor.UnidadeId).FirstOrDefault();
            if ((bool)economia.TemProcessos && ProcessoId!= null)
            {

            }
            ViewData["FluxoProcessoId"] = new SelectList(_context.dbSFluxosProcesso, "FluxoProcessoId", "Descricao");
            ViewData["OrgaoId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "Descricao", Servidor.Divisao.Unidade.OrgaoId);
            ViewData["OrgaoDestinatarioId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "Descricao", Servidor.Divisao.Unidade.OrgaoId);
            ViewData["OrgaoRemetenteId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "Descricao", Servidor.Divisao.Unidade.OrgaoId);
            ViewData["SituacaoProcessoId"] = new SelectList(_context.dbSSituacoesProcesso, "SituacaoProcessoId", "Descricao");
            //ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "Descricao");

            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso.Join(_context.dbSServidores_TiposProcessos, tipoprocesso => tipoprocesso.TipoProcessoId,
            servidortipoprocesso => servidortipoprocesso.TipoProcessoId, (tipoprocesso, servidortipoprocesso) => new { TipoProcesso = tipoprocesso, ServidorTipoProcesso = servidortipoprocesso })
               .Where(resultado => resultado.ServidorTipoProcesso.ServidorId == Servidor.ServidorId)
              .Select(resultado => new { resultado.TipoProcesso.TipoProcessoId, resultado.TipoProcesso.Descricao }).ToList(), "TipoProcessoId", "Descricao");



            //ViewData["TipoProcessoId"] = new SelectList(Servidor.PodeExecutar.ToList(), "TipoProcessoId", "Descricao");
            ViewData["UnidadeId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "Descricao", Servidor.Divisao.UnidadeId);
            ViewData["UnidadeDestinatarioId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "Descricao", Servidor.Divisao.UnidadeId);
            ViewData["UnidadeRemetenteId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "Descricao", Servidor.Divisao.UnidadeId);
            //
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "Descricao", Servidor.ServidorId);
            ViewData["SituacaoEtapaId"] = new SelectList(_context.dbSSituacoesEtapa, "SituacaoEtapaId", "Descricao");
            ViewData["TipoEtapaId"] = new SelectList(_context.dbSTiposEtapa, "TipoEtapaId", "Descricao");


            // var  entidadeId = long.Parse(String.Concat(ImovelId.ToString() + EconomiaId.ToString().PadLeft(3, '0')));
            // var economia = economiaAppService.GetIQueryable().Where(e => e.ImovelId == ImovelId && e.EconomiaId == EconomiaId).FirstOrDefault();


            //var pessoa = pessoaAppService.GetIQueryable().Where(p => p.PessoaId == PessoaId).Include(e=>e.Enderecos).ThenInclude(e=>e.Endereco).ThenInclude(l=>l.Logradouro).ThenInclude(tl=>tl.TipoLogradouro).Include(tp=>tp.TipoPessoa).FirstOrDefault();
            ///var pessoa = pessoaAppService.GetIQueryable().Where(p => p.PessoaId == PessoaId).Include(tp=>tp.TipoPessoa).FirstOrDefault();
            ///ar enderecoseconomia = endereco_EntidadeAppService.GetIQueryable().Where(s => s.EntidadeId == entidadeId).Include(e=>e.Endereco).ThenInclude(l=>l.Logradouro).ThenInclude(tl => tl.TipoLogradouro).ToList();
            ///var enderecospessoa = endereco_EntidadeAppService.GetIQueryable().Where(s => s.EntidadeId == conId && s.ImovelId==ImovelId && s.EconomiaId==EconomiaId).Include(e => e.Endereco).ThenInclude(l => l.Logradouro).ThenInclude(tl => tl.TipoLogradouro).ToList();
            ///economia.Enderecos = enderecoseconomia;
            ///pessoa.Enderecos = enderecospessoa;
            
            AutuarViewModel avm = new AutuarViewModel()
            {
                Economia = economia,
                Pessoa = pessoa

            };
            //_context.DisposeAsync();
            return View(avm);
        }
        [HttpPost]
        public ActionResult Autuar(AutuarViewModel avm)
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Autuar2Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Autuar2Controller/Create
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

        // GET: Autuar2Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Autuar2Controller/Edit/5
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

        // GET: Autuar2Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Autuar2Controller/Delete/5
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
    }
}
