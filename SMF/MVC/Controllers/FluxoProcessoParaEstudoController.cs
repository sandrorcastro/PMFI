using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infra.Context;

namespace MVC.Controllers
{
    public class FluxoProcessoParaEstudoController : Controller
    {
        private readonly ContextoAplicacao _context;

        public FluxoProcessoParaEstudoController(ContextoAplicacao context)
        {
            _context = context;
        }

        // GET: FluxoProcessoParaEstudo
        public async Task<IActionResult> Index()
        {
            var contextoAplicacao = _context.dbSFluxosProcesso.Include(f => f.TipoEtapa).Include(f => f.TipoProcesso);
            return View(await contextoAplicacao.ToListAsync());
        }

        // GET: FluxoProcessoParaEstudo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.dbSFluxosProcesso == null)
            {
                return NotFound();
            }

            var fluxoProcesso = await _context.dbSFluxosProcesso
                .Include(f => f.TipoEtapa)
                .Include(f => f.TipoProcesso)
                .FirstOrDefaultAsync(m => m.FluxoProcessoId == id);
            if (fluxoProcesso == null)
            {
                return NotFound();
            }

            return View(fluxoProcesso);
        }

        // GET: FluxoProcessoParaEstudo/Create
        public IActionResult Create()
        {
            ViewData["TipoEtapaId"] = new SelectList(_context.dbSTiposEtapa, "TipoEtapaId", "TipoEtapaId");
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "TipoProcessoId");
            return View();
        }

        // POST: FluxoProcessoParaEstudo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FluxoProcessoId,Descricao,TipoProcessoId,TipoEtapaId")] FluxoProcesso fluxoProcesso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fluxoProcesso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TipoEtapaId"] = new SelectList(_context.dbSTiposEtapa, "TipoEtapaId", "TipoEtapaId", fluxoProcesso.TipoEtapaId);
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "TipoProcessoId", fluxoProcesso.TipoProcessoId);
            return View(fluxoProcesso);
        }

        // GET: FluxoProcessoParaEstudo/Edit/5
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
            ViewData["TipoEtapaId"] = new SelectList(_context.dbSTiposEtapa, "TipoEtapaId", "TipoEtapaId", fluxoProcesso.TipoEtapaId);
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "TipoProcessoId", fluxoProcesso.TipoProcessoId);
            return View(fluxoProcesso);
        }

        // POST: FluxoProcessoParaEstudo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FluxoProcessoId,Descricao,TipoProcessoId,TipoEtapaId")] FluxoProcesso fluxoProcesso)
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
                    if (!FluxoProcessoExists(fluxoProcesso.FluxoProcessoId))
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
            ViewData["TipoEtapaId"] = new SelectList(_context.dbSTiposEtapa, "TipoEtapaId", "TipoEtapaId", fluxoProcesso.TipoEtapaId);
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "TipoProcessoId", fluxoProcesso.TipoProcessoId);
            return View(fluxoProcesso);
        }

        // GET: FluxoProcessoParaEstudo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.dbSFluxosProcesso == null)
            {
                return NotFound();
            }

            var fluxoProcesso = await _context.dbSFluxosProcesso
                .Include(f => f.TipoEtapa)
                .Include(f => f.TipoProcesso)
                .FirstOrDefaultAsync(m => m.FluxoProcessoId == id);
            if (fluxoProcesso == null)
            {
                return NotFound();
            }

            return View(fluxoProcesso);
        }

        // POST: FluxoProcessoParaEstudo/Delete/5
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

        private bool FluxoProcessoExists(int id)
        {
          return (_context.dbSFluxosProcesso?.Any(e => e.FluxoProcessoId == id)).GetValueOrDefault();
        }
    }
}
