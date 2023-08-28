using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infra.Context;
using Domains.Spec;
using Domain;
using Domain.Filters;
using Application.ViewModels;

namespace WebMVC.Controllers
{
    public class CidadesController : Controller
    {
        private readonly AppDbContext _context;

        public CidadesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Cidades
        public async Task<IActionResult> Index(IReadRepository<Cidade> repo,CidadeFilter filter, CancellationToken cancellationToken)
        {
            var spec = new CidadeSpec(filter);
            var result = await repo.ProjectToFirstOrDefaultAsync<CidadeViewModel>(spec, cancellationToken).ConfigureAwait(false);
           // var applicationDbContext = _context.cidades.Include(c => c.IdPaisNavigation).Include(c => c.IdUfNavigation);
            return View(result);
        }

        // GET: Cidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.cidades == null)
            {
                return NotFound();
            }

            var cidade = await _context.cidades
                .Include(c => c.IdPaisNavigation)
                .Include(c => c.IdUfNavigation)
                .FirstOrDefaultAsync(m => m.IdCidade == id);
            if (cidade == null)
            {
                return NotFound();
            }

            return View(cidade);
        }

        // GET: Cidades/Create
        public IActionResult Create()
        {
            ViewData["IdPais"] = new SelectList(_context.paises, "IdPais", "Nome");
            ViewData["IdUf"] = new SelectList(_context.ufs, "IdUf", "Nome");
            return View();
        }

        // POST: Cidades/Create
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
            ViewData["IdPais"] = new SelectList(_context.paises, "IdPais", "Nome", cidade.IdPais);
            ViewData["IdUf"] = new SelectList(_context.ufs, "IdUf", "Nome", cidade.IdUf);
            return View(cidade);
        }

        // GET: Cidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.cidades == null)
            {
                return NotFound();
            }

            var cidade = await _context.cidades.FindAsync(id);
            if (cidade == null)
            {
                return NotFound();
            }
            ViewData["IdPais"] = new SelectList(_context.paises, "IdPais", "Nome", cidade.IdPais);
            ViewData["IdUf"] = new SelectList(_context.ufs, "IdUf", "Nome", cidade.IdUf);
            return View(cidade);
        }

        // POST: Cidades/Edit/5
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
            ViewData["IdPais"] = new SelectList(_context.paises, "IdPais", "Nome", cidade.IdPais);
            ViewData["IdUf"] = new SelectList(_context.ufs, "IdUf", "Nome", cidade.IdUf);
            return View(cidade);
        }

        // GET: Cidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.cidades == null)
            {
                return NotFound();
            }

            var cidade = await _context.cidades
                .Include(c => c.IdPaisNavigation)
                .Include(c => c.IdUfNavigation)
                .FirstOrDefaultAsync(m => m.IdCidade == id);
            if (cidade == null)
            {
                return NotFound();
            }

            return View(cidade);
        }

        // POST: Cidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.cidades == null)
            {
                return Problem("Entity set 'ApplicationDbContext.dbCidades'  is null.");
            }
            var cidade = await _context.cidades.FindAsync(id);
            if (cidade != null)
            {
                _context.cidades.Remove(cidade);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CidadeExists(int id)
        {
          return (_context.cidades?.Any(e => e.IdCidade == id)).GetValueOrDefault();
        }
    }
}
