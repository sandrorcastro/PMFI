using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities.MegaData;
using Domain.Entities.NFSEDB;

namespace MegaData.Controllers
{
    public class MegaData_NFSEController : Controller
    {
        private readonly MegaDataDBContext _context;

        public MegaData_NFSEController(MegaDataDBContext context)
        {
            _context = context;
        }

        // GET: MegaData_NFSE
        public async Task<IActionResult> Index()
        {
              return _context.MegaData_NFSEs != null ? 
                          View(await _context.MegaData_NFSEs.ToListAsync()) :
                          Problem("Entity set 'MegaDataDBContext.MegaData_NFSEs'  is null.");
        }

        // GET: MegaData_NFSE/Details/5
        public async Task<IActionResult> Details(DateTime? id)
        {
            if (id == null || _context.MegaData_NFSEs == null)
            {
                return NotFound();
            }

            var megaData_NFSE = await _context.MegaData_NFSEs
                .FirstOrDefaultAsync(m => m.DataGeracao == id);
            if (megaData_NFSE == null)
            {
                return NotFound();
            }

            return View(megaData_NFSE);
        }

        // GET: MegaData_NFSE/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MegaData_NFSE/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DataGeracao,DataInicioPeriodo,DataFinalPeriodo,DataEnvio")] MegaData_NFSE megaData_NFSE)
        {
            if (ModelState.IsValid)
            {
                _context.Add(megaData_NFSE);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(megaData_NFSE);
        }

        // GET: MegaData_NFSE/Edit/5
        public async Task<IActionResult> Edit(DateTime? id)
        {
            if (id == null || _context.MegaData_NFSEs == null)
            {
                return NotFound();
            }

            var megaData_NFSE = await _context.MegaData_NFSEs.FindAsync(id);
            if (megaData_NFSE == null)
            {
                return NotFound();
            }
            return View(megaData_NFSE);
        }

        // POST: MegaData_NFSE/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DateTime id, [Bind("DataGeracao,DataInicioPeriodo,DataFinalPeriodo,DataEnvio")] MegaData_NFSE megaData_NFSE)
        {
            if (id != megaData_NFSE.DataGeracao)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(megaData_NFSE);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MegaData_NFSEExists(megaData_NFSE.DataGeracao))
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
            return View(megaData_NFSE);
        }

        // GET: MegaData_NFSE/Delete/5
        public async Task<IActionResult> Delete(DateTime? id)
        {
            if (id == null || _context.MegaData_NFSEs == null)
            {
                return NotFound();
            }

            var megaData_NFSE = await _context.MegaData_NFSEs
                .FirstOrDefaultAsync(m => m.DataGeracao == id);
            if (megaData_NFSE == null)
            {
                return NotFound();
            }

            return View(megaData_NFSE);
        }

        // POST: MegaData_NFSE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(DateTime id)
        {
            if (_context.MegaData_NFSEs == null)
            {
                return Problem("Entity set 'MegaDataDBContext.MegaData_NFSEs'  is null.");
            }
            var megaData_NFSE = await _context.MegaData_NFSEs.FindAsync(id);
            if (megaData_NFSE != null)
            {
                _context.MegaData_NFSEs.Remove(megaData_NFSE);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MegaData_NFSEExists(DateTime id)
        {
          return (_context.MegaData_NFSEs?.Any(e => e.DataGeracao == id)).GetValueOrDefault();
        }
    }
}
