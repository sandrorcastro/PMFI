using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infra.Context;
using MVC.ViewModels;
using AutoMapper;
using MVC.Extensions;
using Application.Services;
using MVC.Models;
using Application.Interfaces;
using Mono.TextTemplating;

namespace MVC.Controllers
{
    public class ImovelController : Controller
    {
        private readonly ContextoAplicacao _context;
        private readonly IImovelAppService imovelAppService;
        private IMapper mapper;
        public ImovelController(ContextoAplicacao context, IMapper mapper, IImovelAppService imovelAppService)
        {
            _context = context;
            this.mapper = mapper;
            this.imovelAppService = imovelAppService;
        }

        // GET: Imovel

        public async Task<IActionResult> Index(string sort, string filter, int p, SortDirection direction)
        {
            // var query = from s in _context.dbSImoveis.Filter(filter).OrderBy(sort, direction) select s;
            var query = from s in imovelAppService.GetIQueryable().Filter(filter).OrderBy(sort, direction) select s;
            ImovelPaginatedListViewModel ivm = new ImovelPaginatedListViewModel(sort, filter);
            ivm.values = await ImovelPaginatedListViewModel.CreateAsync(query, p == 0 ? 1 : p, 10);
            ivm.Filter = filter;
            ivm.Sort = sort;
            return View(ivm);
        }





        /* public async Task<IActionResult> Index()
        {
            //return _context.dbSImoveis != null ? View(await _context.dbSImoveis.ToListAsync()) : Problem("Entity set 'ContextoAplicacao.dbSImoveis'  is null.");
            var query = from s in _context.dbSImoveis select s;// ToPagedList(1,1,10) ;
            PaginatedList<Imovel> imoveis =  new PaginatedList<Imovel>(await query.ToPagedList(),1,1,10);
            ImovelViewModel ivm = new ImovelViewModel();
            ivm.Imoveis = imoveis;
            return View(ivm);
        }*/

        // GET: Imovel/Details/5
        public async Task<IActionResult> Details(long id)
        {
             if (id == null || _context.dbSImoveis == null)
            //if (id == null || imovelAppService.GetIQueryable == null)
            {
                return NotFound();
            }

            //var imovel = _context.dbSImoveis.Find(id);
           //// var imovel = imovelAppService.Find(id);

            var query = from s in imovelAppService.GetIQueryable().Filter(id.ToString()) select s;
            var imovel = query.AsNoTracking().FirstOrDefault();
            //var query = imovelAppService.Find(id).FirstOrDefault()

            //.FirstOrDefaultAsync(m => m.ImovelId == id);
            if (imovel == null)
            {
                return NotFound();
            }

            //return View(mapper.Map<ImovelViewModel>(imovel));
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
        public async Task<IActionResult> Create([Bind("ImovelId,Matricula,Latitude,Longitude,Complemento,AreaTerreno,AreaConstruida,AnoConstrucao,Caracteristica")] ImovelViewModel imovel)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(mapper.Map<Imovel>(imovel));
                imovelAppService.Add(mapper.Map<Imovel>(imovel));
                // await _context.SaveChangesAsync();
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

            //var imovel = await _context.dbSImoveis.FindAsync(id);
            var imovel = imovelAppService.Find(id);
            if (imovel == null)
            {
                return NotFound();
            }
            return View(mapper.Map<ImovelViewModel>(imovel));
        }

        // POST: Imovel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ImovelId,Matricula,Latitude,Longitude,Complemento,AreaTerreno,AreaConstruida,AnoConstrucao,Caracteristica")] ImovelViewModel imovel)
        {
            if (id != imovel.ImovelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(mapper.Map<Imovel>(imovel));
                    imovelAppService.Update(mapper.Map<Imovel>(imovel));

                    //await _context.SaveChangesAsync();
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

            //var imovel = await _context.dbSImoveis.FirstOrDefaultAsync(m => m.ImovelId == id);
            var imovel = imovelAppService.Find(id);
            if (imovel == null)
            {
                return NotFound();
            }

            return View(mapper.Map<ImovelViewModel>(imovel));
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
            //var imovel = await _context.dbSImoveis.FindAsync(id);
            var imovel = imovelAppService.Find(id);
            if (imovel != null)
            {
                //_context.dbSImoveis.Remove(imovel);
                imovelAppService.Remove(imovel);
            }
            
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImovelExists(long id)
        {
            //return (_context.dbSImoveis?.Any(e => e.ImovelId == id)).GetValueOrDefault();
            return (imovelAppService?.GetTodos().Any(e => e.ImovelId == id)).GetValueOrDefault();
        }
    }
}

