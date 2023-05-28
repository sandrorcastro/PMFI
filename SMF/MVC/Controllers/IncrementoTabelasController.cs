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
    public class IncrementoTabelasController : Controller
    {
        private readonly ContextoAplicacao _context;

        public IncrementoTabelasController(ContextoAplicacao context)
        {
            _context = context;
        }

        // GET: IncrementoTabelas
        public async Task<IActionResult> Index()
        {
              return _context.dbSIncrementoTabelas != null ? 
                          View(await _context.dbSIncrementoTabelas.ToListAsync()) :
                          Problem("Entity set 'ContextoAplicacao.dbSIncrementoTabelas'  is null.");
        }

        // GET: IncrementoTabelas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.dbSIncrementoTabelas == null)
            {
                return NotFound();
            }

            var incrementoTabelas = await _context.dbSIncrementoTabelas
                .FirstOrDefaultAsync(m => m.IncrementoTabelasId == id);
            if (incrementoTabelas == null)
            {
                return NotFound();
            }

            return View(incrementoTabelas);
        }

        // GET: IncrementoTabelas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IncrementoTabelas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IncrementoTabelasId,Tabela,Parametro,valorAtual,Ano,valorInicial,valorFinal,valorincrementar")] IncrementoTabelas incrementoTabelas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(incrementoTabelas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(incrementoTabelas);
        }

        // GET: IncrementoTabelas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.dbSIncrementoTabelas == null)
            {
                return NotFound();
            }

            var incrementoTabelas = await _context.dbSIncrementoTabelas.FindAsync(id);
            if (incrementoTabelas == null)
            {
                return NotFound();
            }
            return View(incrementoTabelas);
        }

        // POST: IncrementoTabelas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IncrementoTabelasId,Tabela,Parametro,valorAtual,Ano,valorInicial,valorFinal,valorincrementar")] IncrementoTabelas incrementoTabelas)
        {
            if (id != incrementoTabelas.IncrementoTabelasId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(incrementoTabelas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IncrementoTabelasExists(incrementoTabelas.IncrementoTabelasId))
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
            return View(incrementoTabelas);
        }

        // GET: IncrementoTabelas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.dbSIncrementoTabelas == null)
            {
                return NotFound();
            }

            var incrementoTabelas = await _context.dbSIncrementoTabelas
                .FirstOrDefaultAsync(m => m.IncrementoTabelasId == id);
            if (incrementoTabelas == null)
            {
                return NotFound();
            }

            return View(incrementoTabelas);
        }

        // POST: IncrementoTabelas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.dbSIncrementoTabelas == null)
            {
                return Problem("Entity set 'ContextoAplicacao.dbSIncrementoTabelas'  is null.");
            }
            var incrementoTabelas = await _context.dbSIncrementoTabelas.FindAsync(id);
            if (incrementoTabelas != null)
            {
                _context.dbSIncrementoTabelas.Remove(incrementoTabelas);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IncrementoTabelasExists(int id)
        {
          return (_context.dbSIncrementoTabelas?.Any(e => e.IncrementoTabelasId == id)).GetValueOrDefault();
        }
    }
}
