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
    public class TipoProcessoController : Controller
    {
        private readonly ContextoAplicacao _context;

        public TipoProcessoController(ContextoAplicacao context)
        {
            _context = context;
        }

        // GET: TipoProcesso
        public async Task<IActionResult> Index()
        {
              return _context.dbSTiposProcesso != null ? 
                          View(await _context.dbSTiposProcesso.ToListAsync()) :
                          Problem("Entity set 'ContextoAplicacao.dbSTiposProcesso'  is null.");
        }

        // GET: TipoProcesso/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.dbSTiposProcesso == null)
            {
                return NotFound();
            }

            var tipoProcesso = await _context.dbSTiposProcesso
                .FirstOrDefaultAsync(m => m.TipoProcessoId == id);
            if (tipoProcesso == null)
            {
                return NotFound();
            }

            return View(tipoProcesso);
        }

        // GET: TipoProcesso/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoProcesso/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipoProcessoId,Descricao,DiasTramite,Permanencia,liberado")] TipoProcesso tipoProcesso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoProcesso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoProcesso);
        }

        // GET: TipoProcesso/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.dbSTiposProcesso == null)
            {
                return NotFound();
            }

            var tipoProcesso = await _context.dbSTiposProcesso.FindAsync(id);
            if (tipoProcesso == null)
            {
                return NotFound();
            }
            return View(tipoProcesso);
        }

        // POST: TipoProcesso/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TipoProcessoId,Descricao,DiasTramite,Permanencia,liberado")] TipoProcesso tipoProcesso)
        {
            if (id != tipoProcesso.TipoProcessoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoProcesso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoProcessoExists(tipoProcesso.TipoProcessoId))
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
            return View(tipoProcesso);
        }

        // GET: TipoProcesso/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.dbSTiposProcesso == null)
            {
                return NotFound();
            }

            var tipoProcesso = await _context.dbSTiposProcesso
                .FirstOrDefaultAsync(m => m.TipoProcessoId == id);
            if (tipoProcesso == null)
            {
                return NotFound();
            }

            return View(tipoProcesso);
        }

        // POST: TipoProcesso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.dbSTiposProcesso == null)
            {
                return Problem("Entity set 'ContextoAplicacao.dbSTiposProcesso'  is null.");
            }
            var tipoProcesso = await _context.dbSTiposProcesso.FindAsync(id);
            if (tipoProcesso != null)
            {
                _context.dbSTiposProcesso.Remove(tipoProcesso);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoProcessoExists(int id)
        {
          return (_context.dbSTiposProcesso?.Any(e => e.TipoProcessoId == id)).GetValueOrDefault();
        }
    }
}
