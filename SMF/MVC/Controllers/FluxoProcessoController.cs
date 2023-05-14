using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infra.Context;
using MVC.ViewModels;
using AutoMapper;

namespace MVC.Controllers
{
    public class FluxoProcessoController : Controller
    {
        private readonly ContextoAplicacao _context;
        private IMapper mapper;

        public FluxoProcessoController(ContextoAplicacao context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: FluxoProcesso
        public async Task<IActionResult> Index()
        {
            var contextoAplicacao = _context.dbSFluxosProcesso.Include(f => f.TipoEtapa).Include(f => f.TipoProcesso);
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
                .Include(f => f.TipoEtapa)
                .Include(f => f.TipoProcesso)
                .FirstOrDefaultAsync(m => m.FluxoProcessoId == id);
            if (fluxoProcesso == null)
            {
                return NotFound();
            }

            return View(mapper.Map<FluxoProcessoViewModel>(fluxoProcesso));
        }

        // GET: FluxoProcesso/Create
        public IActionResult Create()
        {
            ViewData["TipoEtapaId"] = new SelectList(_context.dbSTiposEtapa, "TipoEtapaId", "Descricao");
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "Descricao");
            return View();
        }

        // POST: FluxoProcesso/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FluxoProcessoId,Descricao,TipoProcessoId,TipoEtapaId")] FluxoProcessoViewModel fluxoProcesso)
        //public async Task<IActionResult> Create(FluxoProcessoViewModel fluxoProcesso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mapper.Map<FluxoProcesso>(fluxoProcesso));
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TipoEtapaId"] = new SelectList(_context.dbSTiposEtapa, "TipoEtapaId", "Descricao", fluxoProcesso.TipoEtapaId);
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
            ViewData["TipoEtapaId"] = new SelectList(_context.dbSTiposEtapa, "TipoEtapaId", "Descricao", fluxoProcesso.TipoEtapaId);
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "Descricao", fluxoProcesso.TipoProcessoId);
            return View(mapper.Map<FluxoProcessoViewModel>(fluxoProcesso));
        }

        // POST: FluxoProcesso/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FluxoProcessoId,Descricao,TipoProcessoId,TipoEtapaId")] FluxoProcessoViewModel fluxoProcesso)
        {
            if (id != fluxoProcesso.FluxoProcessoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mapper.Map<FluxoProcesso>(fluxoProcesso));
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

        // GET: FluxoProcesso/Delete/5
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

            return View(mapper.Map<FluxoProcessoViewModel>(fluxoProcesso));
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

        private bool FluxoProcessoExists(int id)
        {
          return (_context.dbSFluxosProcesso?.Any(e => e.FluxoProcessoId == id)).GetValueOrDefault();
        }
    }
}
