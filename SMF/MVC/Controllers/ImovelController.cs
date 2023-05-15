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
    public class ImovelController : Controller
    {
        private readonly ContextoAplicacao _context;

        public ImovelController(ContextoAplicacao context)
        {
            _context = context;
        }

        // GET: Imovel
        public async Task<IActionResult> Index()
        {
              return _context.dbSImoveis != null ? 
                          View(await _context.dbSImoveis.ToListAsync()) :
                          Problem("Entity set 'ContextoAplicacao.dbSImoveis'  is null.");
        }

        // GET: Imovel/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.dbSImoveis == null)
            {
                return NotFound();
            }

            var imovel = await _context.dbSImoveis
                .FirstOrDefaultAsync(m => m.ImovelId == id);
            if (imovel == null)
            {
                return NotFound();
            }

            return View(imovel);
        }

        // GET: Imovel/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Imovel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ImovelId,Matricula,Latitude,Longitude,Complemento,AreaTerreno,AreaConstruida,AnoConstrucao,Caracteristica")] Imovel imovel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(imovel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(imovel);
        }

        // GET: Imovel/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.dbSImoveis == null)
            {
                return NotFound();
            }

            var imovel = await _context.dbSImoveis.FindAsync(id);
            if (imovel == null)
            {
                return NotFound();
            }
            return View(imovel);
        }

        // POST: Imovel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ImovelId,Matricula,Latitude,Longitude,Complemento,AreaTerreno,AreaConstruida,AnoConstrucao,Caracteristica")] Imovel imovel)
        {
            if (id != imovel.ImovelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imovel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImovelExists(imovel.ImovelId))
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
            return View(imovel);
        }

        // GET: Imovel/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.dbSImoveis == null)
            {
                return NotFound();
            }

            var imovel = await _context.dbSImoveis
                .FirstOrDefaultAsync(m => m.ImovelId == id);
            if (imovel == null)
            {
                return NotFound();
            }

            return View(imovel);
        }

        // POST: Imovel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.dbSImoveis == null)
            {
                return Problem("Entity set 'ContextoAplicacao.dbSImoveis'  is null.");
            }
            var imovel = await _context.dbSImoveis.FindAsync(id);
            if (imovel != null)
            {
                _context.dbSImoveis.Remove(imovel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImovelExists(long id)
        {
          return (_context.dbSImoveis?.Any(e => e.ImovelId == id)).GetValueOrDefault();
        }
    }
}
