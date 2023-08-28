using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PMFI.Application.Interfaces;
using PMFI.Application.Interfaces.Base;
using PMFI.Application.ViewModels;
using PMFI.Domain.Entities;
using PMFI.Infra.Context;
//using PMFI.WebMVC.Context;

namespace PMFI.WebMVC.Controllers
{
    public class PaisController : Controller
    {
       //private readonly ApplicationDbContext _context;
       private readonly IPaisAppService  paisAppService;


        //public PaisController(ApplicationDbContext context, IPaisAppService paisAppService)
        public PaisController(IPaisAppService paisAppService)
        {
           // _context = context;
            this.paisAppService = paisAppService;
        }

        // GET: Pais
        public async Task<IActionResult> Index()
        {
            /* return _context.dbPaises != null ? 
            return await paisAppService.ListAsync() != null ?
                         View(await _context.dbPaises.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.dbPaises'  is null.");*/

            return View(await paisAppService.ListAsync());

        }

        // GET: Pais/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null || paisAppService == null)
            {
                return NotFound();
            }

            var pais = await paisAppService.GetById(id);
               // .FirstOrDefaultAsync(m => m.IdPais == id);
            if (pais == null)
            {
                return NotFound();
            }

            return View(pais);
        }

        // GET: Pais/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPais,Nome")] PaisViewModel pais)
        {
            if (ModelState.IsValid)
            {
                paisAppService.AddAsync(pais);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pais);
        }

        // GET: Pais/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null || paisAppService == null)
            {
                return NotFound();
            }

            var pais = await paisAppService.GetById(id);
            if (pais == null)
            {
                return NotFound();
            }
            return View(pais);
        }

        // POST: Pais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPais,Nome")] PaisViewModel pais)
        {
            if (id != pais.IdPais)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(pais);
                    //await _context.SaveChangesAsync();
                    await paisAppService.EditAsync(pais);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaisExists(pais.IdPais))
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
            return View(pais);
        }

        // GET: Pais/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null || paisAppService == null)
            {
                return NotFound();
            }

            var pais = await paisAppService.GetById(id);
                //.FirstOrDefaultAsync(m => m.IdPais == id);
            if (pais == null)
            {
                return NotFound();
            }

            return View(pais);
        }

        // POST: Pais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (paisAppService == null)
            {
                return Problem("Entity set 'ApplicationDbContext.dbPaises'  is null.");
            }
            var pais = await paisAppService.GetById(id);
            if (pais != null)
            {
                paisAppService.DeleteAsync(pais);
            }
            
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaisExists(int id)
        {
            // return (_context.dbPaises?.Any(e => e.IdPais == id)).GetValueOrDefault();
            return false; // (paisAppService.GetById(id));
        }
    }
}
