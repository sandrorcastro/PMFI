using Application.Interfaces;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using Infra.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public Autuar2Controller(IMapper mapper, IImovelAppService imovelAppService, IEconomiaAppService economiaAppService, IProcessoAppService processoAppService, IObjetoProcessoAppService objetoProcessoAppService, ContextoAplicacao context, IEconomia_EntidadeAppService economia_EntidadeAppService)
        {
            this.mapper = mapper;
            this.imovelAppService = imovelAppService;
            this.economiaAppService = economiaAppService;
            this.processoAppService = processoAppService;
            this.objetoProcessoAppService = objetoProcessoAppService;
            _context = context;
            this.economia_EntidadeAppService = economia_EntidadeAppService;
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


        public ActionResult Autuar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autuar(int id)
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
