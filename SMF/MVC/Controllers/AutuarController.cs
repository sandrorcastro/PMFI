﻿using Application.Interfaces;
//using AspNetCore;
using AutoMapper;
using Domain.Entities;
using Infra.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC.Extensions;
using MVC.ViewModels;
using System.Runtime.Intrinsics.X86;

namespace MVC.Controllers
{
    public class AutuarController : Controller
    {
        private readonly ContextoAplicacao _context;
        private readonly IImovelAppService imovelAppService;
        private readonly IEconomiaAppService economiaAppService;
        private readonly IEconomia_EntidadeAppService economia_EntidadeAppService;
        private readonly IEndereco_EntidadeAppService endereco_EntidadeAppService;
        private readonly IPessoaAppService pessoaAppService;
        IMapper mapper;
        public AutuarController(IImovelAppService imovelAppService, IMapper mapper, IEconomiaAppService economiaAppService, IEconomia_EntidadeAppService economia_EntidadeAppService, IPessoaAppService pessoaAppService, IEndereco_EntidadeAppService endereco_EntidadeAppService, ContextoAplicacao context)
        {
            this.imovelAppService = imovelAppService;
            this.mapper = mapper;
            this.economiaAppService = economiaAppService;
            this.economia_EntidadeAppService = economia_EntidadeAppService;
            this.pessoaAppService = pessoaAppService;
            this.endereco_EntidadeAppService = endereco_EntidadeAppService;
            _context = context;
        }
        public ActionResult Index()
        {
            return View(new ImovelViewModel() { });
        }
        // GET: AutuarController

        [HttpPost]
        public ActionResult Imovel(ImovelViewModel imovel)
        {
            //var contextoAplicacao = _context.dbSEnderecos.Include(e => e.Bairro).Include(e => e.Cidade).Include(e => e.Logradouro);

            var queryimovel = from s in imovelAppService.GetIQueryable().Filter(imovel.ImovelId.ToString()) select s;
            var queryeconomias = from s in economiaAppService.GetIQueryable().Filter(imovel.ImovelId.ToString()) select s;
            var imovelDO = queryimovel.AsNoTracking().FirstOrDefault();
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
            ViewData["FluxoProcessoId"] = new SelectList(_context.dbSFluxosProcesso, "FluxoProcessoId", "Descricao");
            ViewData["OrgaoId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "Descricao");
            ViewData["OrgaoDestinatarioId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "Descricao");
            ViewData["OrgaoRemetenteId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "Descricao");
            ViewData["SituacaoProcessoId"] = new SelectList(_context.dbSSituacoesProcesso, "SituacaoProcessoId", "Descricao");
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "Descricao");
            ViewData["UnidadeDestinatarioId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "Descricao");
            ViewData["UnidadeRemetenteId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "Descricao");
            //
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "Descricao");
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
            return View(avm);
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
    }
}
