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
    public class CidadeController : Controller
    {
        private readonly ContextoAplicacao _context;

        public CidadeController(ContextoAplicacao context)
        {
            _context = context;
        }

        // GET: Cidade
        public async Task<IActionResult> Index()
        {
            var contextoAplicacao = _context.dbSCidades.Include(c => c.DDD).Include(c => c.Estado);
            return View(await contextoAplicacao.ToListAsync());
        }

        // GET: Cidade/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.dbSCidades == null)
            {
                return NotFound();
            }

            var cidade = await _context.dbSCidades
                .Include(c => c.DDD)
                .Include(c => c.Estado)
                .FirstOrDefaultAsync(m => m.CidadeId == id);
            if (cidade == null)
            {
                return NotFound();
            }

            return View(cidade);
        }

        // GET: Cidade/Create
        public IActionResult Create()
        {
            ViewData["DDDId"] = new SelectList(_context.dbSDDDs, "DDDId", "Numero");
            ViewData["EstadoId"] = new SelectList(_context.dbSEstados, "EstadoId", "EstadoId");
            return View();
        }

        // POST: Cidade/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CidadeId,Descricao,EstadoId,ibgeProsiga,ibge,IDCidadeProsiga,UFProsiga,DDDId")] Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cidade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DDDId"] = new SelectList(_context.dbSDDDs, "DDDId", "Numero", cidade.DDDId);
            ViewData["EstadoId"] = new SelectList(_context.dbSEstados, "EstadoId", "EstadoId", cidade.EstadoId);
            return View(cidade);
        }

        // GET: Cidade/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.dbSCidades == null)
            {
                return NotFound();
            }

            var cidade = await _context.dbSCidades.FindAsync(id);
            if (cidade == null)
            {
                return NotFound();
            }
            ViewData["DDDId"] = new SelectList(_context.dbSDDDs, "DDDId", "Numero", cidade.DDDId);
            ViewData["EstadoId"] = new SelectList(_context.dbSEstados, "EstadoId", "EstadoId", cidade.EstadoId);
            return View(cidade);
        }

        // POST: Cidade/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CidadeId,Descricao,EstadoId,ibgeProsiga,ibge,IDCidadeProsiga,UFProsiga,DDDId")] Cidade cidade)
        {
            if (id != cidade.CidadeId)
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
                    if (!CidadeExists(cidade.CidadeId))
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
            ViewData["DDDId"] = new SelectList(_context.dbSDDDs, "DDDId", "Numero", cidade.DDDId);
            ViewData["EstadoId"] = new SelectList(_context.dbSEstados, "EstadoId", "EstadoId", cidade.EstadoId);
            return View(cidade);
        }

        // GET: Cidade/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.dbSCidades == null)
            {
                return NotFound();
            }

            var cidade = await _context.dbSCidades
                .Include(c => c.DDD)
                .Include(c => c.Estado)
                .FirstOrDefaultAsync(m => m.CidadeId == id);
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
            if (_context.dbSCidades == null)
            {
                return Problem("Entity set 'ContextoAplicacao.dbSCidades'  is null.");
            }
            var cidade = await _context.dbSCidades.FindAsync(id);
            if (cidade != null)
            {
                _context.dbSCidades.Remove(cidade);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CidadeExists(int id)
        {
          return (_context.dbSCidades?.Any(e => e.CidadeId == id)).GetValueOrDefault();
        }
    }
}
