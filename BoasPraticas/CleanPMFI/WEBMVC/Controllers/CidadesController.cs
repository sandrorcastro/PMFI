using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Context;
using Domain.Filters;
using Application.Services.Base;
using Application.Interfaces;
using Application.Interfaces.Base;
using Domain.Specs;
using System.Threading;
using Application.ViewModels;
using Domain.Pagination;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using WEBMVC.ViewComponents;

namespace WEBMVC.Controllers
{
    public class CidadesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ICidadeAppService cidadeAppService;
        public CidadesController(ApplicationDbContext context, ICidadeAppService cidadeAppService)
        {
            _context = context;
            this.cidadeAppService = cidadeAppService;
        }

        // GET: Cidades
        //public async Task<IActionResult> Index()
        public async Task<IActionResult> Index(CidadeFilter filter)
        {

              //filter.Nome = "Cacoal";
              //filter.IdCidade = 4;
            var spec = new CidadeSpec(filter);

            var result = await cidadeAppService.ProjectToListAsync<CidadeViewModel>(spec, filter,new CancellationToken());
            var resultPVM = new PagedResponseViewModel<CidadeViewModel>(result);
            
            
            //return ViewComponent("~/Views/Shared/Partials/_Buscar.cshtmlPagedResponse", result);
            return ViewComponent("Cidade", result);


            //return View(result);
            //return View(resultPVM);






            //Cacoal
            //  filter.Nome = "Cacoal";
            //  filter.IdCidade = 4;
            //var spec = new CidadeSpec(filter);
            //var result = await cidadeAppService.FirstOrDefaultAsync<Cidade>(spec,filter); //, cancellationToken);
            //var result = await cidadeAppService.FirstOrDefaultAsync(spec);
            //  return View(nameof(Details),result);


            // var result=  await cidadeAppService.ListAsync();
            //return View(result);
            //var applicationDbContext = _context.Cidades.Include(c => c.IdPaisNavigation).Include(c => c.IdUfNavigation);
            //return View(await applicationDbContext.ToListAsync());
        }

        // GET: Cidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cidades == null)
            {
                return NotFound();
            }

            var cidade = await _context.Cidades
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
            ViewData["IdPais"] = new SelectList(_context.Paises, "IdPais", "Nome");
            ViewData["IdUf"] = new SelectList(_context.Ufs, "IdUf", "Nome");
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
            ViewData["IdPais"] = new SelectList(_context.Paises, "IdPais", "Nome", cidade.IdPais);
            ViewData["IdUf"] = new SelectList(_context.Ufs, "IdUf", "Nome", cidade.IdUf);
            return View(cidade);
        }

        // GET: Cidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cidades == null)
            {
                return NotFound();
            }

            var cidade = await _context.Cidades.FindAsync(id);
            if (cidade == null)
            {
                return NotFound();
            }
            ViewData["IdPais"] = new SelectList(_context.Paises, "IdPais", "Nome", cidade.IdPais);
            ViewData["IdUf"] = new SelectList(_context.Ufs, "IdUf", "Nome", cidade.IdUf);
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
            ViewData["IdPais"] = new SelectList(_context.Paises, "IdPais", "Nome", cidade.IdPais);
            ViewData["IdUf"] = new SelectList(_context.Ufs, "IdUf", "Nome", cidade.IdUf);
            return View(cidade);
        }

        // GET: Cidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cidades == null)
            {
                return NotFound();
            }

            var cidade = await _context.Cidades
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
            if (_context.Cidades == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Cidades'  is null.");
            }
            var cidade = await _context.Cidades.FindAsync(id);
            if (cidade != null)
            {
                _context.Cidades.Remove(cidade);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CidadeExists(int id)
        {
          return (_context.Cidades?.Any(e => e.IdCidade == id)).GetValueOrDefault();
        }
    }
}
