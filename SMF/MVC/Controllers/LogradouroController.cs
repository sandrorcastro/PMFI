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
using MVC.Extensions;
using MVC.Models;
using Application.Interfaces;
using AutoMapper;

namespace MVC.Controllers
{
    public class LogradouroController : Controller
    {
        private readonly ContextoAplicacao _context;
        private readonly ILogradouroAppService logradouroAppService;
        IMapper mapper;

        public LogradouroController(ContextoAplicacao context, ILogradouroAppService logradouroAppService, IMapper mapper)
        {
            _context = context;
            this.logradouroAppService = logradouroAppService;
            this.mapper = mapper;
        }

        // GET: Logradouro

        public async Task<IActionResult> Index(string sort, string filter, int p, SortDirection direction)
        {
            //var query = from s in _context.dbSLogradouros.Filter(filter).OrderBy(sort, direction) select s;// ToPagedList(1,1,10) ;
            var query = from s in logradouroAppService.GetIQueryable().Filter(filter).OrderBy(sort, direction) select s;// ToPagedList(1,1,10) ;
            LogradouroPaginatedListViewModel lvm = new LogradouroPaginatedListViewModel(sort, filter);
            lvm.values = await LogradouroPaginatedListViewModel.CreateAsync(query, p == 0 ? 1 : p, 10);
            lvm.Filter = filter;
            lvm.Sort = sort;
            return View(lvm);
        }





        /* public async Task<IActionResult> Index()
         {
             var contextoAplicacao = _context.dbSLogradouros.Include(l => l.Bairro).Include(l => l.Cidade).Include(l => l.TipoLogradouro);
             return View(await contextoAplicacao.ToListAsync());
         }*/

        // GET: Logradouro/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.dbSLogradouros == null)
            {
                return NotFound();
            }

            //var logradouro = await _context.dbSLogradouros
            var logradouro = logradouroAppService.GetById(id)
                .Include(l => l.Bairro)
                .Include(l => l.Cidade)
                .Include(l => l.TipoLogradouro)
                .FirstOrDefault();
            if (logradouro == null)
            {
                return NotFound();
            }

            return View(mapper.Map<LogradouroViewModel>(logradouro));
        }

        // GET: Logradouro/Create
        public IActionResult Create()
        {
            ViewData["BairroId"] = new SelectList(_context.dbSBairros, "BairroId", "BairroId");
            ViewData["CidadeId"] = new SelectList(_context.dbSCidades, "CidadeId", "Descricao");
            ViewData["TipoLogradouroId"] = new SelectList(_context.dbSTiposLogradouro, "TipoLogradouroId", "TipoLogradouroId");
            return View();
        }

        // POST: Logradouro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LogradouroId,Descricao,CidadeId,BairroId,TipoLogradouroId,descricaoTipoLogradouro,CEP,Ativo")] LogradouroViewModel logradouro)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(logradouro);
                logradouroAppService.Add(mapper.Map<Logradouro>(logradouro));
               // await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BairroId"] = new SelectList(_context.dbSBairros, "BairroId", "BairroId", logradouro.BairroId);
            ViewData["CidadeId"] = new SelectList(_context.dbSCidades, "CidadeId", "Descricao", logradouro.CidadeId);
            ViewData["TipoLogradouroId"] = new SelectList(_context.dbSTiposLogradouro, "TipoLogradouroId", "TipoLogradouroId", logradouro.TipoLogradouroId);
            return View(logradouro);
        }

        // GET: Logradouro/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.dbSLogradouros == null)
            {
                return NotFound();
            }

            //var logradouro = await _context.dbSLogradouros.FindAsync(id);
            var logradouro = logradouroAppService.Find(id);
            if (logradouro == null)
            {
                return NotFound();
            }
            ViewData["BairroId"] = new SelectList(_context.dbSBairros, "BairroId", "BairroId", logradouro.BairroId);
            ViewData["CidadeId"] = new SelectList(_context.dbSCidades, "CidadeId", "Descricao", logradouro.CidadeId);
            ViewData["TipoLogradouroId"] = new SelectList(_context.dbSTiposLogradouro, "TipoLogradouroId", "TipoLogradouroId", logradouro.TipoLogradouroId);
            return View(mapper.Map<LogradouroViewModel>(logradouro));
        }

        // POST: Logradouro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("LogradouroId,Descricao,CidadeId,BairroId,TipoLogradouroId,descricaoTipoLogradouro,CEP,Ativo")] LogradouroViewModel logradouro)
        {
            if (id != logradouro.LogradouroId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(logradouro);
                    logradouroAppService.Update(mapper.Map<Logradouro>(logradouro));
                    //await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LogradouroExists(logradouro.LogradouroId))
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
            ViewData["BairroId"] = new SelectList(_context.dbSBairros, "BairroId", "BairroId", logradouro.BairroId);
            ViewData["CidadeId"] = new SelectList(_context.dbSCidades, "CidadeId", "Descricao", logradouro.CidadeId);
            ViewData["TipoLogradouroId"] = new SelectList(_context.dbSTiposLogradouro, "TipoLogradouroId", "TipoLogradouroId", logradouro.TipoLogradouroId);
            return View(logradouro);
        }

        // GET: Logradouro/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.dbSLogradouros == null)
            {
                return NotFound();
            }

            //var logradouro = await _context.dbSLogradouros
            var logradouro = logradouroAppService.GetById(id)
                .Include(l => l.Bairro)
                .Include(l => l.Cidade)
                .Include(l => l.TipoLogradouro)
                .FirstOrDefault(m => m.LogradouroId == id);
            if (logradouro == null)
            {
                return NotFound();
            }

            return View(mapper.Map<LogradouroViewModel>(logradouro));
        }

        // POST: Logradouro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.dbSLogradouros == null)
            {
                return Problem("Entity set 'ContextoAplicacao.dbSLogradouros'  is null.");
            }
            //var logradouro = await _context.dbSLogradouros.FindAsync(id);
            var logradouro = logradouroAppService.Find(id);
            if (logradouro != null)
            {
                //_context.dbSLogradouros.Remove(logradouro);
                logradouroAppService.Remove(logradouro);
            }
            
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LogradouroExists(long id)
        {
          return (_context.dbSLogradouros?.Any(e => e.LogradouroId == id)).GetValueOrDefault();
            //return (logradouroAppService?.Any(e => e.LogradouroId == id)).GetValueOrDefault();
        }
    }
}
