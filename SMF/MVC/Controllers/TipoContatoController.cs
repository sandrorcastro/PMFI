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
    public class TipoContatoController : Controller
    {
        private readonly ContextoAplicacao _context;

        public TipoContatoController(ContextoAplicacao context)
        {
            _context = context;
        }

        // GET: TipoContato
        public async Task<IActionResult> Index()
        {
              return _context.dbSTiposContato != null ? 
                          View(await _context.dbSTiposContato.ToListAsync()) :
                          Problem("Entity set 'ContextoAplicacao.dbSTiposContato'  is null.");
        }

        // GET: TipoContato/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.dbSTiposContato == null)
            {
                return NotFound();
            }

            var tipoContato = await _context.dbSTiposContato
                .FirstOrDefaultAsync(m => m.TipoContatoId == id);
            if (tipoContato == null)
            {
                return NotFound();
            }

            return View(tipoContato);
        }

        // GET: TipoContato/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoContato/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipoContatoId,Descricao")] TipoContato tipoContato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoContato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoContato);
        }

        // GET: TipoContato/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.dbSTiposContato == null)
            {
                return NotFound();
            }

            var tipoContato = await _context.dbSTiposContato.FindAsync(id);
            if (tipoContato == null)
            {
                return NotFound();
            }
            return View(tipoContato);
        }

        // POST: TipoContato/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TipoContatoId,Descricao")] TipoContato tipoContato)
        {
            if (id != tipoContato.TipoContatoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoContato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoContatoExists(tipoContato.TipoContatoId))
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
            return View(tipoContato);
        }

        // GET: TipoContato/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.dbSTiposContato == null)
            {
                return NotFound();
            }

            var tipoContato = await _context.dbSTiposContato
                .FirstOrDefaultAsync(m => m.TipoContatoId == id);
            if (tipoContato == null)
            {
                return NotFound();
            }

            return View(tipoContato);
        }

        // POST: TipoContato/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.dbSTiposContato == null)
            {
                return Problem("Entity set 'ContextoAplicacao.dbSTiposContato'  is null.");
            }
            var tipoContato = await _context.dbSTiposContato.FindAsync(id);
            if (tipoContato != null)
            {
                _context.dbSTiposContato.Remove(tipoContato);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoContatoExists(int id)
        {
          return (_context.dbSTiposContato?.Any(e => e.TipoContatoId == id)).GetValueOrDefault();
        }
    }
}
