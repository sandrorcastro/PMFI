﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infra.Context;
using AutoMapper;
using MVC.ViewModels;
using MVC.Extensions;
using MVC.Models;
//using Mono.TextTemplating;

namespace MVC.Controllers
{
    public class PessoaController : Controller
    {
        private readonly ContextoAplicacao _context;
        private IMapper mapper;

        public PessoaController(ContextoAplicacao context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: Pessoa
        
        public async Task<IActionResult> Index(string sort,string  filter, int p, SortDirection direction)
        {
            var query = from s in _context.dbSPessoas.Filter(filter).OrderBy(sort,direction) select s;// ToPagedList(1,1,10) ;
            PessoaPaginatedListViewModel pvm = new PessoaPaginatedListViewModel(sort,filter);
            pvm.values = await PessoaPaginatedListViewModel.CreateAsync(query,p==0?1:p,10);
            pvm.Filter = filter;
            pvm.Sort= sort; 
            return View(pvm);
        }

        // GET: Pessoa/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.dbSPessoas == null)
            {
                return NotFound();
            }

            var pessoa = await _context.dbSPessoas
                .Include(p => p.TipoPessoa)
                .FirstOrDefaultAsync(m => m.PessoaId == id);
            if (pessoa == null)
            {
                return NotFound();
            }

            return View(pessoa);
        }

        // GET: Pessoa/Create
        public IActionResult Create()
        {
            ViewData["TipoPessoaId"] = new SelectList(_context.dbSTiposPessoa, "TipoPessoaId", "Descricao");
            return View();
        }

        // POST: Pessoa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PessoaId,Nome,TipoPessoaId,DataCadastro,Ativo,conId")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pessoa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TipoPessoaId"] = new SelectList(_context.dbSTiposPessoa, "TipoPessoaId", "Descricao", pessoa.TipoPessoaId);
            return View(pessoa);
        }

        // GET: Pessoa/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.dbSPessoas == null)
            {
                return NotFound();
            }

            var pessoa = await _context.dbSPessoas.FindAsync(id);
            if (pessoa == null)
            {
                return NotFound();
            }
            ViewData["TipoPessoaId"] = new SelectList(_context.dbSTiposPessoa, "TipoPessoaId", "Descricao", pessoa.TipoPessoaId);
            return View(mapper.Map<PessoaViewModel>(pessoa));
        }

        // POST: Pessoa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("PessoaId,Nome,TipoPessoaId,DataCadastro,Ativo,conId")] PessoaViewModel pessoa)
        //public async Task<IActionResult> Edit(long id,  PessoaViewMode pessoa)
        {
            if (id != pessoa.PessoaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mapper.Map<Pessoa>(pessoa));
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PessoaExists(pessoa.PessoaId))
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
            ViewData["TipoPessoaId"] = new SelectList(_context.dbSTiposPessoa, "TipoPessoaId", "Descricao", pessoa.TipoPessoaId);
            return View(pessoa);
        }

        // GET: Pessoa/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.dbSPessoas == null)
            {
                return NotFound();
            }

            var pessoa = await _context.dbSPessoas
                .Include(p => p.TipoPessoa)
                .FirstOrDefaultAsync(m => m.PessoaId == id);
            if (pessoa == null)
            {
                return NotFound();
            }

            return View(pessoa);
        }

        // POST: Pessoa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.dbSPessoas == null)
            {
                return Problem("Entity set 'ContextoAplicacao.dbSPessoas'  is null.");
            }
            var pessoa = await _context.dbSPessoas.FindAsync(id);
            if (pessoa != null)
            {
                _context.dbSPessoas.Remove(pessoa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PessoaExists(long id)
        {
          return (_context.dbSPessoas?.Any(e => e.PessoaId == id)).GetValueOrDefault();
        }
    }
}
