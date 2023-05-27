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
    public class FluxoProcessoController : Controller
    {
        private readonly ContextoAplicacao _context;

        public FluxoProcessoController(ContextoAplicacao context)
        {
            _context = context;
        }

        // GET: FluxoProcesso
        public async Task<IActionResult> Index()
        {
            var contextoAplicacao = _context.dbSFluxosProcesso.Include(f => f.TipoProcesso).OrderBy(o => o.FluxoProcessoId).OrderBy(o=>o.TipoProcessoId);
            return View(await contextoAplicacao.ToListAsync());
        }

        // GET: FluxoProcesso/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.dbSFluxosProcesso == null)
            {
                return NotFound();
            }

            var fluxoProcesso = await _context.dbSFluxosProcesso
                .Include(f => f.TipoProcesso)
                .FirstOrDefaultAsync(m => m.FluxoProcessoId == id);
            if (fluxoProcesso == null)
            {
                return NotFound();
            }

            return View(fluxoProcesso);
        }

        // GET: FluxoProcesso/Create
        public IActionResult Create()
        {
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "Descricao");
            return View();
        }

        // POST: FluxoProcesso/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FluxoProcessoId,TipoProcessoId,Descricao,TempoTramitacao")] FluxoProcesso fluxoProcesso)
        {
            if (ModelState.IsValid)
            {
                if (FluxoProcessoExists(fluxoProcesso.TipoProcessoId, fluxoProcesso.FluxoProcessoId))
                {
                    this.MostrarMensagem("O Fluxo de Processo: " + fluxoProcesso.FluxoProcessoId + " para o Tipo de Processo: "+fluxoProcesso.TipoProcessoId + " Já Existe!");
                    ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "Descricao", fluxoProcesso.TipoProcessoId);
                    return View(fluxoProcesso);
                }
                _context.Add(fluxoProcesso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "Descricao", fluxoProcesso.TipoProcessoId);
            return View(fluxoProcesso);
        }

        // GET: FluxoProcesso/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.dbSFluxosProcesso == null)
            {
                return NotFound();
            }

            var fluxoProcesso = await _context.dbSFluxosProcesso.FindAsync(id);
            if (fluxoProcesso == null)
            {
                return NotFound();
            }
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "TipoProcessoId", fluxoProcesso.TipoProcessoId);
            return View(fluxoProcesso);
        }

        // POST: FluxoProcesso/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FluxoProcessoId,TipoProcessoId,Descricao,TempoTramitacao")] FluxoProcesso fluxoProcesso)
        {
            if (id != fluxoProcesso.FluxoProcessoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fluxoProcesso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FluxoProcessoExists(fluxoProcesso.TipoProcessoId, fluxoProcesso.FluxoProcessoId))
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
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "TipoProcessoId", fluxoProcesso.TipoProcessoId);
            return View(fluxoProcesso);
        }

        // GET: FluxoProcesso/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.dbSFluxosProcesso == null)
            {
                return NotFound();
            }

            var fluxoProcesso = await _context.dbSFluxosProcesso
                .Include(f => f.TipoProcesso)
                .FirstOrDefaultAsync(m => m.FluxoProcessoId == id);
            if (fluxoProcesso == null)
            {
                return NotFound();
            }

            return View(fluxoProcesso);
        }

        // POST: FluxoProcesso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.dbSFluxosProcesso == null)
            {
                return Problem("Entity set 'ContextoAplicacao.dbSFluxosProcesso'  is null.");
            }
            var fluxoProcesso = await _context.dbSFluxosProcesso.FindAsync(id);
            if (fluxoProcesso != null)
            {
                _context.dbSFluxosProcesso.Remove(fluxoProcesso);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FluxoProcessoExists(int TipoProcessoId, int FluxoProcessoId)
        {
          return (_context.dbSFluxosProcesso?.Any(fp => fp.TipoProcessoId==TipoProcessoId && fp.FluxoProcessoId==FluxoProcessoId )).GetValueOrDefault();
        }
    }
}
