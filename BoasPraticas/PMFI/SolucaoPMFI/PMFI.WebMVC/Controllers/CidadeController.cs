using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PMFI.Domain.Entities;
using PMFI.Infra.Context;

namespace PMFI.WebMVC.Controllers
{
    public class CidadeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CidadeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cidade
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.dbCidades.Include(c => c.IdPaisNavigation).Include(c => c.IdUfNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Cidade/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.dbCidades == null)
            {
                return NotFound();
            }

            var cidade = await _context.dbCidades
                .Include(c => c.IdPaisNavigation)
                .Include(c => c.IdUfNavigation)
                .FirstOrDefaultAsync(m => m.IdCidade == id);
            if (cidade == null)
            {
                return NotFound();
            }

            return View(cidade);
        }

        // GET: Cidade/Create
        public IActionResult Create()
        {
            ViewData["IdPais"] = new SelectList(_context.dbPaises, "IdPais", "Nome");
            ViewData["IdUf"] = new SelectList(_context.dbUfs, "IdUf", "Nome");
            return View();
        }

        // POST: Cidade/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCidade,IdUf,Nome,IdPais,CodigoIbge,SinCapital,Latitude,Longitude")] Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cidade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPais"] = new SelectList(_context.dbPaises, "IdPais", "Nome", cidade.IdPais);
            ViewData["IdUf"] = new SelectList(_context.dbUfs, "IdUf", "Nome", cidade.IdUf);
            return View(cidade);
        }

        // GET: Cidade/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.dbCidades == null)
            {
                return NotFound();
            }

            var cidade = await _context.dbCidades.FindAsync(id);
            if (cidade == null)
            {
                return NotFound();
            }
            ViewData["IdPais"] = new SelectList(_context.dbPaises, "IdPais", "Nome", cidade.IdPais);
            ViewData["IdUf"] = new SelectList(_context.dbUfs, "IdUf", "Nome", cidade.IdUf);
            return View(cidade);
        }

        // POST: Cidade/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCidade,IdUf,Nome,IdPais,CodigoIbge,SinCapital,Latitude,Longitude")] Cidade cidade)
        {
            if (id != cidade.IdCidade)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CidadeExists(cidade.IdCidade))
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
            ViewData["IdPais"] = new SelectList(_context.dbPaises, "IdPais", "Nome", cidade.IdPais);
            ViewData["IdUf"] = new SelectList(_context.dbUfs, "IdUf", "Nome", cidade.IdUf);
            return View(cidade);
        }

        // GET: Cidade/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.dbCidades == null)
            {
                return NotFound();
            }

            var cidade = await _context.dbCidades
                .Include(c => c.IdPaisNavigation)
                .Include(c => c.IdUfNavigation)
                .FirstOrDefaultAsync(m => m.IdCidade == id);
            if (cidade == null)
            {
                return NotFound();
            }

            return View(cidade);
        }

        // POST: Cidade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.dbCidades == null)
            {
                return Problem("Entity set 'ApplicationDbContext.dbCidades'  is null.");
            }
            var cidade = await _context.dbCidades.FindAsync(id);
            if (cidade != null)
            {
                _context.dbCidades.Remove(cidade);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CidadeExists(int id)
        {
          return (_context.dbCidades?.Any(e => e.IdCidade == id)).GetValueOrDefault();
        }
    }
}
