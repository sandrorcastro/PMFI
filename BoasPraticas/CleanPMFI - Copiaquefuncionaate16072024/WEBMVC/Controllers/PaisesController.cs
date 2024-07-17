using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Context;
using Application.Services;
using Application.ViewModels;
using Domain.Filters;
using Domain.Interfaces.Specifications;
using Domain.Specs;
using Application.Interfaces;

namespace WEBMVC.Controllers
{
    public class PaisesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IPaisAppService paisAppService;
        public PaisesController(ApplicationDbContext context, IPaisAppService paisAppService)
        {
            _context = context;
            this.paisAppService = paisAppService;
        }

        // GET: Paises
        /*  public async Task<IActionResult> Index()
          {
                return _context.Paises != null ? 
                            View(await _context.Paises.ToListAsync()) :
                            Problem("Entity set 'ApplicationDbContext.Paises'  is null.");
          }*/
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {

            ISpecification<Pais> spec = null;
            PaisFilter paisFilter = new PaisFilter();

            ViewData["CurrentSort"] = sortOrder;
            ViewData["NomeSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Nome" : "";
            ViewData["IdCidadeSortParm"] = sortOrder == "IdCidade" ? "idcidade_desc" : "IdCidade";
            if (searchString != null)
            {
                pageNumber = 1;
                paisFilter.Page = pageNumber;
            }
            else
            {
                searchString = currentFilter;
                paisFilter.SortBy = sortOrder;
                //cidadeFilter.OrderBy = "desc";
                spec = new PaisSpec(paisFilter);
            }

            ViewData["CurrentFilter"] = searchString;
            if (!String.IsNullOrEmpty(searchString))
            {
                long number1 = 0;
                if (long.TryParse(searchString, out number1))
                {
                    paisFilter.IdPais = int.Parse(searchString);
                    spec = new PaisByIdSpec(paisFilter);
                }
                else
                {
                    paisFilter.Nome = searchString;
                    spec = new PaisSpec(paisFilter);
                }
            }
            /*  switch (sortOrder)
              {
                  case "nome_desc":
                      Cidades = Cidades.OrderByDescending(s => s.Nome);

                      break;
                  case "IdCidade":
                      Cidades = Cidades.OrderBy(s => s.IdCidade);
                      break;
                  case "idcidade_desc":
                      Cidades = Cidades.OrderByDescending(s => s.IdCidade);
                      break;
                  default:
                      //Cidades = Cidades.OrderBy(s => s.Nome);
                      spec = new CidadeSpec();
                      break;
              }*/

            //int pageSize = 3;

            // return View(await PaginatedList<Student>.CreateAsync(Cidades.AsNoTracking(), pageNumber ?? 1, pageSize));


            //  cidadeFilter.Nome = searchString;
            //spec=new CidadeSpec(cidadeFilter);

            //ViewData["CidadeFilter"] = cidadeFilter;
            var result = await paisAppService.ProjectToListAsync<PaisViewModel>(spec, paisFilter, new CancellationToken());
            var resultPVM = new PagedResponseViewModel<PaisViewModel>(result, paisFilter);
            //return View(result);
            return View(resultPVM);
        }

        // GET: Paises/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Paises == null)
            {
                return NotFound();
            }

            var pais = await _context.Paises
                .FirstOrDefaultAsync(m => m.IdPais == id);
            if (pais == null)
            {
                return NotFound();
            }

            return View(pais);
        }

        // GET: Paises/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Paises/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPais,Nome")] Pais pais)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pais);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pais);
        }

        // GET: Paises/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Paises == null)
            {
                return NotFound();
            }

            var pais = await _context.Paises.FindAsync(id);
            if (pais == null)
            {
                return NotFound();
            }
            return View(pais);
        }

        // POST: Paises/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPais,Nome")] Pais pais)
        {
            if (id != pais.IdPais)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pais);
                    await _context.SaveChangesAsync();
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

        // GET: Paises/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Paises == null)
            {
                return NotFound();
            }

            var pais = await _context.Paises
                .FirstOrDefaultAsync(m => m.IdPais == id);
            if (pais == null)
            {
                return NotFound();
            }

            return View(pais);
        }

        // POST: Paises/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Paises == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Paises'  is null.");
            }
            var pais = await _context.Paises.FindAsync(id);
            if (pais != null)
            {
                _context.Paises.Remove(pais);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaisExists(int id)
        {
          return (_context.Paises?.Any(e => e.IdPais == id)).GetValueOrDefault();
        }
    }
}
