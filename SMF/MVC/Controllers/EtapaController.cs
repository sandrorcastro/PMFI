using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infra.Context;
using MVC.Extensions;

namespace MVC.Controllers
{
    public class EtapaController : Controller
    {
        private readonly ContextoAplicacao _context;

        public EtapaController(ContextoAplicacao context)
        {
            _context = context;
        }

        // GET: Etapa
        public async Task<IActionResult> Index()
        {
            var contextoAplicacao = _context.dbSEtapas.Include(e => e.FluxoProcesso).Include(e => e.Processo).Include(e => e.Servidor).Include(e => e.SituacaoEtapa).Include(e => e.TipoProcesso);
            return View(await contextoAplicacao.ToListAsync());
        }

        // GET: Etapa/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.dbSEtapas == null)
            {
                return NotFound();
            }

            var etapa = await _context.dbSEtapas
                .Include(e => e.FluxoProcesso)
                .Include(e => e.Processo)
                .Include(e => e.Servidor)
                .Include(e => e.SituacaoEtapa)
                .Include(e => e.TipoProcesso)
                .FirstOrDefaultAsync(m => m.ProcessoId == id);
            if (etapa == null)
            {
                return NotFound();
            }

            return View(etapa);
        }

        // GET: Etapa/Create
        public IActionResult Create(int? TipoProcessoId)
        {
            if (TipoProcessoId.HasValue)
            {
                ViewData["FluxoProcessoId"] = new SelectList(_context.dbSFluxosProcesso.Where(tp=>tp.TipoProcessoId==TipoProcessoId).Distinct(), "FluxoProcessoId", "Descricao");
            }
            else
            {
                ViewData["FluxoProcessoId"] = new SelectList(_context.dbSFluxosProcesso, "FluxoProcessoId", "Descricao");

            }

            ViewData["ProcessoId"] = new SelectList(_context.dbSProcessos, "ProcessoId", "ProcessoId");
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "Nome");
            ViewData["SituacaoEtapaId"] = new SelectList(_context.dbSSituacoesEtapa, "SituacaoEtapaId", "Descricao");
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "Descricao");
            return View();
        }

        // POST: Etapa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProcessoId,FluxoProcessoId,TipoProcessoId,SituacaoEtapaId,DataInicio,DataFim,ServidorId,Ano,antigo,protocolo,anoprotocolo,ObservacaoEtapa,emailEnviado,emailRecebido,whatsEnviado,whatsRecebido")] Etapa etapa)
        {
            if (ModelState.IsValid)
            {
                if (EtapaExists(etapa.ProcessoId, etapa.FluxoProcessoId, etapa.TipoProcessoId))
                {
                    this.MostrarMensagem("Este Processo com esta etapa Já Existe!");
                    ViewData["FluxoProcessoId"] = new SelectList(_context.dbSFluxosProcesso, "FluxoProcessoId", "FluxoProcessoId", etapa.FluxoProcessoId);
                    ViewData["ProcessoId"] = new SelectList(_context.dbSProcessos, "ProcessoId", "ProcessoId", etapa.ProcessoId);
                    ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "Nome", etapa.ServidorId);
                    ViewData["SituacaoEtapaId"] = new SelectList(_context.dbSSituacoesEtapa, "SituacaoEtapaId", "Descricao", etapa.SituacaoEtapaId);
                    ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "Descricao", etapa.TipoProcessoId);
                    return View(etapa);
                }
                if(!FluxoProcessoTipoProcessoExists(etapa.TipoProcessoId))
                {
                    this.MostrarMensagem("Não Existe Fluxo de Processo Definido para este Tipo de Processo! Contacte O Administrador!");
                    ViewData["FluxoProcessoId"] = new SelectList(_context.dbSFluxosProcesso, "FluxoProcessoId", "Descricao", etapa.FluxoProcessoId);
                    ViewData["ProcessoId"] = new SelectList(_context.dbSProcessos, "ProcessoId", "ProcessoId", etapa.ProcessoId);
                    ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "Nome", etapa.ServidorId);
                    ViewData["SituacaoEtapaId"] = new SelectList(_context.dbSSituacoesEtapa, "SituacaoEtapaId", "Descricao", etapa.SituacaoEtapaId);
                    ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "Descricao", etapa.TipoProcessoId);
                    return View(etapa);

                }




                _context.Add(etapa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FluxoProcessoId"] = new SelectList(_context.dbSFluxosProcesso, "FluxoProcessoId", "FluxoProcessoId", etapa.FluxoProcessoId);
            ViewData["ProcessoId"] = new SelectList(_context.dbSProcessos, "ProcessoId", "ProcessoId", etapa.ProcessoId);
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "ServidorId", etapa.ServidorId);
            ViewData["SituacaoEtapaId"] = new SelectList(_context.dbSSituacoesEtapa, "SituacaoEtapaId", "SituacaoEtapaId", etapa.SituacaoEtapaId);
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "TipoProcessoId", etapa.TipoProcessoId);
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
            ViewData["FluxoProcessoId"] = new SelectList(_context.dbSFluxosProcesso, "FluxoProcessoId", "FluxoProcessoId", etapa.FluxoProcessoId);
            ViewData["ProcessoId"] = new SelectList(_context.dbSProcessos, "ProcessoId", "ProcessoId", etapa.ProcessoId);
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "ServidorId", etapa.ServidorId);
            ViewData["SituacaoEtapaId"] = new SelectList(_context.dbSSituacoesEtapa, "SituacaoEtapaId", "SituacaoEtapaId", etapa.SituacaoEtapaId);
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "TipoProcessoId", etapa.TipoProcessoId);
            return View(etapa);
        }

        // POST: Etapa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ProcessoId,FluxoProcessoId,TipoProcessoId,SituacaoEtapaId,DataInicio,DataFim,ServidorId,Ano,antigo,protocolo,anoprotocolo,ObservacaoEtapa,emailEnviado,emailRecebido,whatsEnviado,whatsRecebido")] Etapa etapa)
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
                    if (!EtapaExists(etapa.ProcessoId,etapa.FluxoProcessoId,etapa.TipoProcessoId))
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
            ViewData["FluxoProcessoId"] = new SelectList(_context.dbSFluxosProcesso, "FluxoProcessoId", "FluxoProcessoId", etapa.FluxoProcessoId);
            ViewData["ProcessoId"] = new SelectList(_context.dbSProcessos, "ProcessoId", "ProcessoId", etapa.ProcessoId);
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "ServidorId", etapa.ServidorId);
            ViewData["SituacaoEtapaId"] = new SelectList(_context.dbSSituacoesEtapa, "SituacaoEtapaId", "SituacaoEtapaId", etapa.SituacaoEtapaId);
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "TipoProcessoId", etapa.TipoProcessoId);
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
                .Include(e => e.FluxoProcesso)
                .Include(e => e.Processo)
                .Include(e => e.Servidor)
                .Include(e => e.SituacaoEtapa)
                .Include(e => e.TipoProcesso)
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

        private bool EtapaExists(long ProcessoId, int FluxoProcessoId, int TipoProcessoId)
        {
          return (_context.dbSEtapas?.Any(e => e.ProcessoId == ProcessoId && e.FluxoProcessoId==FluxoProcessoId && e.TipoProcessoId==TipoProcessoId)).GetValueOrDefault();
        }
        private bool FluxoProcessoTipoProcessoExists(int TipoProcessoId)
        {
            return (_context.dbSFluxosProcesso?.Any(fp => fp.TipoProcessoId == TipoProcessoId )).GetValueOrDefault();
        }
    }
}
