using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Context;

namespace WEBMVC.Controllers
{
    public class UfsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UfsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ufs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Ufs.Include(u => u.IdPaisNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Ufs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Ufs == null)
            {
                return NotFound();
            }

            var uf = await _context.Ufs
                .Include(u => u.IdPaisNavigation)
                .FirstOrDefaultAsync(m => m.IdUf == id);
            if (uf == null)
            {
                return NotFound();
            }

            return View(uf);
        }

        // GET: Ufs/Create
        public IActionResult Create()
        {
            ViewData["IdPais"] = new SelectList(_context.Paises, "IdPais", "Nome");
            return View();
        }

        // POST: Ufs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUf,Sigla,Nome,IdPais,CodigoIbge")] Uf uf)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uf);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPais"] = new SelectList(_context.Paises, "IdPais", "Nome", uf.IdPais);
            return View(uf);
        }

        // GET: Ufs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Ufs == null)
            {
                return NotFound();
            }

            var uf = await _context.Ufs.FindAsync(id);
            if (uf == null)
            {
                return NotFound();
            }
            ViewData["IdPais"] = new SelectList(_context.Paises, "IdPais", "Nome", uf.IdPais);
            return View(uf);
        }

        // POST: Ufs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUf,Sigla,Nome,IdPais,CodigoIbge")] Uf uf)
        {
            if (id != uf.IdUf)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uf);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UfExists(uf.IdUf))
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
            ViewData["IdPais"] = new SelectList(_context.Paises, "IdPais", "Nome", uf.IdPais);
            return View(uf);
        }

        // GET: Ufs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Ufs == null)
            {
                return NotFound();
            }

            var uf = await _context.Ufs
                .Include(u => u.IdPaisNavigation)
                .FirstOrDefaultAsync(m => m.IdUf == id);
            if (uf == null)
            {
                return NotFound();
            }

            return View(uf);
        }

        // POST: Ufs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Ufs == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Ufs'  is null.");
            }
            var uf = await _context.Ufs.FindAsync(id);
            if (uf != null)
            {
                _context.Ufs.Remove(uf);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UfExists(int id)
        {
          return (_context.Ufs?.Any(e => e.IdUf == id)).GetValueOrDefault();
        }
    }
}
