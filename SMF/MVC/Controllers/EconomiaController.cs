using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infra.Context;
using Application.Services;
using MVC.Models;
using MVC.ViewModels;
using Application.Interfaces;
using AutoMapper;
using MVC.Extensions;

namespace MVC.Controllers
{
    public class EconomiaController : Controller
    {
        private readonly ContextoAplicacao _context;
        private readonly IEconomiaAppService economiaAppService;
        IMapper mapper;
        public EconomiaController(ContextoAplicacao context, IEconomiaAppService economiaAppService, IMapper mapper)
        {
            _context = context;
            this.economiaAppService = economiaAppService;
            this.mapper = mapper;
        }

        // GET: Economia
        public async Task<IActionResult> Index(string sort, string filter, int p, SortDirection direction)
        {
            // var query = from s in _context.dbSImoveis.Filter(filter).OrderBy(sort, direction) select s;
            var query = from s in economiaAppService.GetIQueryable().Filter(filter).OrderBy(sort, direction) select s;
            EconomiaPaginatedListViewModel evm = new EconomiaPaginatedListViewModel(sort, filter);
            evm.values = await EconomiaPaginatedListViewModel.CreateAsync(query, p == 0 ? 1 : p, 10);
            evm.Filter = filter;
            evm.Sort = sort;
            return View(evm);
        }
        /*public async Task<IActionResult> Index()
        {
            var contextoAplicacao = _context.dbSEconomias.Include(e => e.Imovel);
            return View(await contextoAplicacao.ToListAsync());
        }*/

        // GET: Economia/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.dbSEconomias == null)
            {
                return NotFound();
            }

            var economia = await _context.dbSEconomias
                .Include(e => e.Imovel)
                .FirstOrDefaultAsync(m => m.ImovelId == id);
            if (economia == null)
            {
                return NotFound();
            }

            return View(economia);
        }

        // GET: Economia/Create
        public IActionResult Create()
        {
            ViewData["ImovelId"] = new SelectList(_context.dbSImoveis, "ImovelId", "ImovelId");
            return View();
        }

        // POST: Economia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ImovelId,EconomiaId,Latitude,Longitude,Complemento,AreaConstruida,AnoConstrucao,Numeracao,Caracteristica,Matricula,TemProcessos")] Economia economia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(economia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ImovelId"] = new SelectList(_context.dbSImoveis, "ImovelId", "ImovelId", economia.ImovelId);
            return View(economia);
        }

        // GET: Economia/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.dbSEconomias == null)
            {
                return NotFound();
            }

            var economia = await _context.dbSEconomias.FindAsync(id);
            if (economia == null)
            {
                return NotFound();
            }
            ViewData["ImovelId"] = new SelectList(_context.dbSImoveis, "ImovelId", "ImovelId", economia.ImovelId);
            return View(economia);
        }

        // POST: Economia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ImovelId,EconomiaId,Latitude,Longitude,Complemento,AreaConstruida,AnoConstrucao,Numeracao,Caracteristica,Matricula,TemProcessos")] Economia economia)
        {
            if (id != economia.ImovelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(economia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EconomiaExists(economia.ImovelId))
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
            ViewData["ImovelId"] = new SelectList(_context.dbSImoveis, "ImovelId", "ImovelId", economia.ImovelId);
            return View(economia);
        }

        // GET: Economia/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.dbSEconomias == null)
            {
                return NotFound();
            }

            var economia = await _context.dbSEconomias
                .Include(e => e.Imovel)
                .FirstOrDefaultAsync(m => m.ImovelId == id);
            if (economia == null)
            {
                return NotFound();
            }

            return View(economia);
        }

        // POST: Economia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.dbSEconomias == null)
            {
                return Problem("Entity set 'ContextoAplicacao.dbSEconomias'  is null.");
            }
            var economia = await _context.dbSEconomias.FindAsync(id);
            if (economia != null)
            {
                _context.dbSEconomias.Remove(economia);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EconomiaExists(long id)
        {
          return (_context.dbSEconomias?.Any(e => e.ImovelId == id)).GetValueOrDefault();
        }
    }
}
