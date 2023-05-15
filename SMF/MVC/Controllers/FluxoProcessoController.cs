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
using Application.Interfaces;
using MVC.Extensions;
using MVC.Models;

namespace MVC.Controllers
{
    public class FluxoProcessoController : Controller
    {
        //private readonly ContextoAplicacao fluxoProcessoAppService;
        private readonly IFluxoProcessoAppService fluxoProcessoAppService;
        private readonly ITipoProcessoAppService tipoProcessoAppService;
        private readonly ITipoEtapaAppService tipoEtapaAppService;
        private IMapper mapper;

        public FluxoProcessoController(IMapper mapper, IFluxoProcessoAppService fluxoProcessoAppService, ITipoProcessoAppService tipoProcessoAppService, ITipoEtapaAppService tipoEtapaAppService)
        {
            //fluxoProcessoAppService = context;
            this.mapper = mapper;
            this.fluxoProcessoAppService = fluxoProcessoAppService;
            this.tipoProcessoAppService = tipoProcessoAppService;
            this.tipoEtapaAppService = tipoEtapaAppService;
        }

        // GET: FluxoProcesso
        public async Task<IActionResult> Index()
        {
            //var contextoAplicacao = fluxoProcessoAppService.dbSFluxosProcesso.Include(f => f.TipoEtapa).Include(f => f.TipoProcesso);
            ///var contextoAplicacao = fluxoProcessoAppService.GetTodos().Include(f => f.TipoEtapa).Include(f => f.TipoProcesso);
            var contextoAplicacao = from s in fluxoProcessoAppService.GetTodos().Filter("").OrderBy("FluxoProcessoId", SortDirection.Desc) select s;
            return View(mapper.Map<IEnumerable<FluxoProcessoViewModel>>(contextoAplicacao.ToList()));
        }

        // GET: FluxoProcesso/Details/5
        public async Task<IActionResult> Details(int id)
        {
            //if (id == null || fluxoProcessoAppService.dbSFluxosProcesso == null)
            if (id == null || fluxoProcessoAppService.Find(id) == null)
            {
                return NotFound();
            }
            var fluxoProcesso = fluxoProcessoAppService.GetById().Filter(id.ToString());//.FirstOrDefault();
            //var fluxoProcesso = from s in fluxoProcessoAppService.GetById(fp=>fp.FluxoProcessoId==id).Include(te=>te.TipoEtapa).Include(tp=>tp.TipoProcesso) select s;
            if (fluxoProcesso == null)
            {
                return NotFound();
            }

            return View(mapper.Map<FluxoProcessoViewModel>(fluxoProcesso.FirstOrDefault()));
        }

        // GET: FluxoProcesso/Create
        public IActionResult Create()
        {
            //ViewData["TipoEtapaId"] = new SelectList(fluxoProcessoAppService.dbSTiposEtapa, "TipoEtapaId", "Descricao");
            //ViewData["TipoProcessoId"] = new SelectList(fluxoProcessoAppService.dbSTiposProcesso, "TipoProcessoId", "Descricao");
            ViewData["TipoEtapaId"] = new SelectList(tipoEtapaAppService.GetTodos(), "TipoEtapaId", "Descricao");
            ViewData["TipoProcessoId"] = new SelectList(tipoProcessoAppService.GetTodos(), "TipoProcessoId", "Descricao");
            return View();
        }

        // POST: FluxoProcesso/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FluxoProcessoId,Descricao,TipoProcessoId,TipoEtapaId")] FluxoProcessoViewModel fluxoProcesso)
        //public async Task<IActionResult> Create(FluxoProcessoViewModel fluxoProcesso)
        {
            if (ModelState.IsValid)
            {
                fluxoProcessoAppService.Add(mapper.Map<FluxoProcesso>(fluxoProcesso));
                //await fluxoProcessoAppService.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //ViewData["TipoEtapaId"] = new SelectList(fluxoProcessoAppService.dbSTiposEtapa, "TipoEtapaId", "Descricao", fluxoProcesso.TipoEtapaId);
            //ViewData["TipoProcessoId"] = new SelectList(fluxoProcessoAppService.dbSTiposProcesso, "TipoProcessoId", "Descricao", fluxoProcesso.TipoProcessoId);
            ViewData["TipoEtapaId"] = new SelectList(tipoEtapaAppService.GetTodos(), "TipoEtapaId", "Descricao", fluxoProcesso.TipoEtapaId);
            ViewData["TipoProcessoId"] = new SelectList(tipoProcessoAppService.GetTodos(), "TipoProcessoId", "Descricao", fluxoProcesso.TipoProcessoId);
            return View(fluxoProcesso);
        }

        // GET: FluxoProcesso/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            
            if (id == null || fluxoProcessoAppService.GetById(id) == null)
            {
                return NotFound();
            }

            //var fluxoProcesso = await fluxoProcessoAppService.dbSFluxosProcesso.FindAsync(id);
            //var fluxoProcesso = fluxoProcessoAppService.Get(fp => fp.FluxoProcessoId == id);
            var fluxoProcesso = fluxoProcessoAppService.GetById().Filter(id.ToString());
            if (fluxoProcesso == null)
            {
                return NotFound();
            }
            // ViewData["TipoEtapaId"] = new SelectList(fluxoProcessoAppService.dbSTiposEtapa, "TipoEtapaId", "Descricao", fluxoProcesso.TipoEtapaId);
            //ViewData["TipoProcessoId"] = new SelectList(fluxoProcessoAppService.dbSTiposProcesso, "TipoProcessoId", "Descricao", fluxoProcesso.TipoProcessoId);
            ViewData["TipoEtapaId"] = new SelectList(tipoEtapaAppService.GetTodos(), "TipoEtapaId", "Descricao"); //, fluxoProcesso.TipoEtapaId);
            ViewData["TipoProcessoId"] = new SelectList(tipoProcessoAppService.GetTodos(), "TipoProcessoId", "Descricao");//, fluxoProcesso.TipoProcessoId);
            return View(mapper.Map<FluxoProcessoViewModel>(fluxoProcesso.FirstOrDefault()));
        }

        // POST: FluxoProcesso/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FluxoProcessoId,Descricao,TipoProcessoId,TipoEtapaId")] FluxoProcessoViewModel fluxoProcesso)
        {
            if (id != fluxoProcesso.FluxoProcessoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    fluxoProcessoAppService.Update(mapper.Map<FluxoProcesso>(fluxoProcesso));
                  //  await fluxoProcessoAppService.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FluxoProcessoExists(fluxoProcesso.FluxoProcessoId))
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
            // ViewData["TipoEtapaId"] = new SelectList(fluxoProcessoAppService.dbSTiposEtapa, "TipoEtapaId", "TipoEtapaId", fluxoProcesso.TipoEtapaId);
            // ViewData["TipoProcessoId"] = new SelectList(fluxoProcessoAppService.dbSTiposProcesso, "TipoProcessoId", "TipoProcessoId", fluxoProcesso.TipoProcessoId);
            ViewData["TipoEtapaId"] = new SelectList(tipoEtapaAppService.GetTodos(), "TipoEtapaId", "TipoEtapaId", fluxoProcesso.TipoEtapaId);
            ViewData["TipoProcessoId"] = new SelectList(tipoProcessoAppService.GetTodos(), "TipoProcessoId", "TipoProcessoId", fluxoProcesso.TipoProcessoId);
            return View(fluxoProcesso);
        }

        // GET: FluxoProcesso/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //if (id == null || fluxoProcessoAppService.dbSFluxosProcesso == null)
            if (id == null || fluxoProcessoAppService == null)
            {
                return NotFound();
            }

            //var fluxoProcesso = await fluxoProcessoAppService.dbSFluxosProcesso
            //var fluxoProcesso = fluxoProcessoAppService.Get(fp=>fp.FluxoProcessoId==id)
            var fluxoProcesso = fluxoProcessoAppService.GetById().Filter(id.ToString()).FirstOrDefault();
                //.Include(f => f.TipoEtapa)
                //.Include(f => f.TipoProcesso)
                //.FirstOrDefaultAsync(m => m.FluxoProcessoId == id);
            if (fluxoProcesso == null)
            {
                return NotFound();
            }

            return View(mapper.Map<FluxoProcessoViewModel>(fluxoProcesso));
        }

        // POST: FluxoProcesso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //if (fluxoProcessoAppService.dbSFluxosProcesso == null)
            if (fluxoProcessoAppService == null)
            {
                return Problem("Entity set 'ContextoAplicacao.dbSFluxosProcesso'  is null.");
            }
            //var fluxoProcesso = await fluxoProcessoAppService.dbSFluxosProcesso.FindAsync(id);
            //var fluxoProcesso = fluxoProcessoAppService.Find(id);
            var fluxoProcesso = fluxoProcessoAppService.GetById(id);
            if (fluxoProcesso != null)
            {
                //fluxoProcessoAppService.dbSFluxosProcesso.Remove(fluxoProcesso);
                fluxoProcessoAppService.Remove(fluxoProcesso);
            }
            
            //await fluxoProcessoAppService.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FluxoProcessoExists(int id)
        {
            //return (fluxoProcessoAppService.dbSFluxosProcesso?.Any(e => e.FluxoProcessoId == id)).GetValueOrDefault();
            return (fluxoProcessoAppService.Get(fp=>fp.FluxoProcessoId==id)?.Any(e => e.FluxoProcessoId == id)).GetValueOrDefault();
        }
    }
}
