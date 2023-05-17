using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infra.Context;
using Application.Services;
using MVC.Models;
using MVC.ViewModels;
using Application.Interfaces;
using AutoMapper;
using MVC.Extensions;

namespace MVC.Controllers
{
    public class EtapaController : Controller
    {
        private readonly ContextoAplicacao _context;
        private readonly IEtapaAppService etapaAppService;
        IMapper mapper;

        public EtapaController(ContextoAplicacao context, IEtapaAppService etapaAppService, IMapper mapper)
        {
            _context = context;
            this.etapaAppService = etapaAppService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index(string sort, string filter, int p, SortDirection direction)
        {
            var query = from s in etapaAppService.GetIQueryable().Filter(filter).OrderBy(sort, direction) select s;
            EtapaPaginatedListViewModel evm = new EtapaPaginatedListViewModel(sort, filter);
            evm.values = await EtapaPaginatedListViewModel.CreateAsync(query, p == 0 ? 1 : p, 10);
            evm.Filter = filter;
            evm.Sort = sort;
            return View(evm);
        }









        // GET: Etapa
        /*public async Task<IActionResult> Index()
        {
            //var contextoAplicacao = _context.dbSEtapas.Include(e => e.Economia).Include(e => e.Endereco).Include(e => e.Imovel).Include(e => e.Pessoa).Include(e => e.PessoaProprietariaResponsavel).Include(e => e.PessoaTerceira).Include(e => e.Servidor).Include(e => e.SituacaoEtapa).Include(e => e.TipoEtapa);
            //return View(await contextoAplicacao.ToListAsync());
        }*/

        // GET: Etapa/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.dbSEtapas == null)
            {
                return NotFound();
            }

            var etapa = await _context.dbSEtapas
                .Include(e => e.Economia)
                .Include(e => e.Endereco)
                .Include(e => e.Imovel)
                .Include(e => e.Pessoa)
                .Include(e => e.PessoaProprietariaResponsavel)
                .Include(e => e.PessoaTerceira)
                .Include(e => e.Servidor)
                .Include(e => e.SituacaoEtapa)
                .Include(e => e.TipoEtapa)
                .FirstOrDefaultAsync(m => m.ProcessoId == id);
            if (etapa == null)
            {
                return NotFound();
            }

            return View(etapa);
        }

        // GET: Etapa/Create
        public IActionResult Create()
        {
            ViewData["ImovelId"] = new SelectList(_context.dbSEconomias, "ImovelId", "ImovelId");
            ViewData["EnderecoId"] = new SelectList(_context.dbSEnderecos, "EnderecoId", "EnderecoId");
            ViewData["ImovelId"] = new SelectList(_context.dbSImoveis, "ImovelId", "ImovelId");
            ViewData["PessoaId"] = new SelectList(_context.dbSPessoas, "PessoaId", "Nome");
            ViewData["PessoaProprietariaResponsavelId"] = new SelectList(_context.dbSPessoas, "PessoaId", "Nome");
            ViewData["PessoaTerceiraID"] = new SelectList(_context.dbSPessoas, "PessoaId", "Nome");
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "ServidorId");
            ViewData["SituacaoEtapaId"] = new SelectList(_context.dbSSituacoesEtapa, "SituacaoEtapaId", "SituacaoEtapaId");
            ViewData["TipoEtapaId"] = new SelectList(_context.dbSTiposEtapa, "TipoEtapaId", "TipoEtapaId");
            return View();
        }

        // POST: Etapa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EtapaId,ProcessoId,SituacaoEtapaId,DataInicio,DataFim,ServidorId,ImovelId,EconomiaId,TipoEtapaId,EnderecoId,PessoaId,PessoaProprietariaResponsavelId,PessoaTerceiraID,Ano,antigo,protocolo,anoprotocolo,Observacao,emailEnviado,emailRecebido,whatsEnviado,whatsRecebido")] Etapa etapa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(etapa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ImovelId"] = new SelectList(_context.dbSEconomias, "ImovelId", "ImovelId", etapa.ImovelId);
            ViewData["EnderecoId"] = new SelectList(_context.dbSEnderecos, "EnderecoId", "EnderecoId", etapa.EnderecoId);
            ViewData["ImovelId"] = new SelectList(_context.dbSImoveis, "ImovelId", "ImovelId", etapa.ImovelId);
            ViewData["PessoaId"] = new SelectList(_context.dbSPessoas, "PessoaId", "Nome", etapa.PessoaId);
            ViewData["PessoaProprietariaResponsavelId"] = new SelectList(_context.dbSPessoas, "PessoaId", "Nome", etapa.PessoaProprietariaResponsavelId);
            ViewData["PessoaTerceiraID"] = new SelectList(_context.dbSPessoas, "PessoaId", "Nome", etapa.PessoaTerceiraID);
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "ServidorId", etapa.ServidorId);
            ViewData["SituacaoEtapaId"] = new SelectList(_context.dbSSituacoesEtapa, "SituacaoEtapaId", "SituacaoEtapaId", etapa.SituacaoEtapaId);
            ViewData["TipoEtapaId"] = new SelectList(_context.dbSTiposEtapa, "TipoEtapaId", "TipoEtapaId", etapa.TipoEtapaId);
            return View(etapa);
        }

        // GET: Etapa/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.dbSEtapas == null)
            {
                return NotFound();
            }

            var etapa = await _context.dbSEtapas.FindAsync(id);
            if (etapa == null)
            {
                return NotFound();
            }
            ViewData["ImovelId"] = new SelectList(_context.dbSEconomias, "ImovelId", "ImovelId", etapa.ImovelId);
            ViewData["EnderecoId"] = new SelectList(_context.dbSEnderecos, "EnderecoId", "EnderecoId", etapa.EnderecoId);
            ViewData["ImovelId"] = new SelectList(_context.dbSImoveis, "ImovelId", "ImovelId", etapa.ImovelId);
            ViewData["PessoaId"] = new SelectList(_context.dbSPessoas, "PessoaId", "Nome", etapa.PessoaId);
            ViewData["PessoaProprietariaResponsavelId"] = new SelectList(_context.dbSPessoas, "PessoaId", "Nome", etapa.PessoaProprietariaResponsavelId);
            ViewData["PessoaTerceiraID"] = new SelectList(_context.dbSPessoas, "PessoaId", "Nome", etapa.PessoaTerceiraID);
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "ServidorId", etapa.ServidorId);
            ViewData["SituacaoEtapaId"] = new SelectList(_context.dbSSituacoesEtapa, "SituacaoEtapaId", "SituacaoEtapaId", etapa.SituacaoEtapaId);
            ViewData["TipoEtapaId"] = new SelectList(_context.dbSTiposEtapa, "TipoEtapaId", "TipoEtapaId", etapa.TipoEtapaId);
            return View(etapa);
        }

        // POST: Etapa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("EtapaId,ProcessoId,SituacaoEtapaId,DataInicio,DataFim,ServidorId,ImovelId,EconomiaId,TipoEtapaId,EnderecoId,PessoaId,PessoaProprietariaResponsavelId,PessoaTerceiraID,Ano,antigo,protocolo,anoprotocolo,Observacao,emailEnviado,emailRecebido,whatsEnviado,whatsRecebido")] Etapa etapa)
        {
            if (id != etapa.ProcessoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(etapa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EtapaExists(etapa.ProcessoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ImovelId"] = new SelectList(_context.dbSEconomias, "ImovelId", "ImovelId", etapa.ImovelId);
            ViewData["EnderecoId"] = new SelectList(_context.dbSEnderecos, "EnderecoId", "EnderecoId", etapa.EnderecoId);
            ViewData["ImovelId"] = new SelectList(_context.dbSImoveis, "ImovelId", "ImovelId", etapa.ImovelId);
            ViewData["PessoaId"] = new SelectList(_context.dbSPessoas, "PessoaId", "Nome", etapa.PessoaId);
            ViewData["PessoaProprietariaResponsavelId"] = new SelectList(_context.dbSPessoas, "PessoaId", "Nome", etapa.PessoaProprietariaResponsavelId);
            ViewData["PessoaTerceiraID"] = new SelectList(_context.dbSPessoas, "PessoaId", "Nome", etapa.PessoaTerceiraID);
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "ServidorId", etapa.ServidorId);
            ViewData["SituacaoEtapaId"] = new SelectList(_context.dbSSituacoesEtapa, "SituacaoEtapaId", "SituacaoEtapaId", etapa.SituacaoEtapaId);
            ViewData["TipoEtapaId"] = new SelectList(_context.dbSTiposEtapa, "TipoEtapaId", "TipoEtapaId", etapa.TipoEtapaId);
            return View(etapa);
        }

        // GET: Etapa/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.dbSEtapas == null)
            {
                return NotFound();
            }

            var etapa = await _context.dbSEtapas
                .Include(e => e.Economia)
                .Include(e => e.Endereco)
                .Include(e => e.Imovel)
                .Include(e => e.Pessoa)
                .Include(e => e.PessoaProprietariaResponsavel)
                .Include(e => e.PessoaTerceira)
                .Include(e => e.Servidor)
                .Include(e => e.SituacaoEtapa)
                .Include(e => e.TipoEtapa)
                .FirstOrDefaultAsync(m => m.ProcessoId == id);
            if (etapa == null)
            {
                return NotFound();
            }

            return View(etapa);
        }

        // POST: Etapa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.dbSEtapas == null)
            {
                return Problem("Entity set 'ContextoAplicacao.dbSEtapas'  is null.");
            }
            var etapa = await _context.dbSEtapas.FindAsync(id);
            if (etapa != null)
            {
                _context.dbSEtapas.Remove(etapa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EtapaExists(long id)
        {
          return (_context.dbSEtapas?.Any(e => e.ProcessoId == id)).GetValueOrDefault();
        }
    }
}
