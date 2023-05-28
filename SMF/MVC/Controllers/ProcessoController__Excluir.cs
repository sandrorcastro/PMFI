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

namespace MVC.Controllers
{
    public class ProcessoController__ : Controller
    {
        private readonly ContextoAplicacao _context;
        private IMapper mapper;

        public ProcessoController__(ContextoAplicacao context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: Processo
       public async Task<IActionResult> Index()
        {
            var contextoAplicacao = _context.dbSProcessos.Include(p => p.Orgao).Include(p => p.OrgaoDestinatario).Include(p => p.OrgaoRemetente).Include(p => p.TipoProcesso).Include(p => p.UnidadeDestinatario).Include(p => p.UnidadeRemetente);
           //ProcessoViewModel p = new ProcessoViewModel();
            
            // var pvm = mapper.Map<IEnumerable<ProcessoViewModel>>(contextoAplicacao.ToList());
            return View(mapper.Map<IEnumerable<ProcessoViewModel>>(contextoAplicacao.ToList()));
        }

        // GET: Processo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.dbSProcessos == null)
            {
                return NotFound();
            }

            var processo = await _context.dbSProcessos
               
                .Include(p => p.Orgao)
                .Include(p => p.OrgaoDestinatario)
                .Include(p => p.OrgaoRemetente)
                .Include(p => p.TipoProcesso)
                .Include(p => p.UnidadeDestinatario)
                .Include(p => p.UnidadeRemetente)
                .FirstOrDefaultAsync(m => m.OrgaoId == id);
            if (processo == null)
            {
                return NotFound();
            }

            return View(processo);
        }

        // GET: Processo/Create
        public IActionResult Create()
        {
            ViewData["FluxoProcessoId"] = new SelectList(_context.dbSFluxosProcesso, "FluxoProcessoId", "Descricao");
            ViewData["OrgaoId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId");
            ViewData["OrgaoDestinatarioId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId");
            ViewData["OrgaoRemetenteId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId");
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "TipoProcessoId");
            ViewData["UnidadeDestinatarioId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "UnidadeId");
            ViewData["UnidadeRemetenteId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "UnidadeId");
            return View();
        }

        // POST: Processo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrgaoId,SequenciaNumerica,Ano,DigitoVerificador,DataCadastro,TipoProcessoId,OrgaoRemetenteId,UnidadeRemetenteId,OrgaoDestinatarioId,UnidadeDestinatarioId,FluxoProcessoId,ObservacaoProcesso,ProcessoEnviado,ProcessoRecebido")] Processo processo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(processo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            ViewData["OrgaoId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId", processo.OrgaoId);
            ViewData["OrgaoDestinatarioId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId", processo.OrgaoDestinatarioId);
            ViewData["OrgaoRemetenteId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId", processo.OrgaoRemetenteId);
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "TipoProcessoId", processo.TipoProcessoId);
            ViewData["UnidadeDestinatarioId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "UnidadeId", processo.UnidadeDestinatarioId);
            ViewData["UnidadeRemetenteId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "UnidadeId", processo.UnidadeRemetenteId);
            return View(processo);
        }

        // GET: Processo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.dbSProcessos == null)
            {
                return NotFound();
            }

            var processo = await _context.dbSProcessos.FindAsync(id);
            if (processo == null)
            {
                return NotFound();
            }
            
            ViewData["OrgaoId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId", processo.OrgaoId);
            ViewData["OrgaoDestinatarioId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId", processo.OrgaoDestinatarioId);
            ViewData["OrgaoRemetenteId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId", processo.OrgaoRemetenteId);
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "TipoProcessoId", processo.TipoProcessoId);
            ViewData["UnidadeDestinatarioId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "UnidadeId", processo.UnidadeDestinatarioId);
            ViewData["UnidadeRemetenteId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "UnidadeId", processo.UnidadeRemetenteId);
            return View(processo);
        }

        // POST: Processo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrgaoId,SequenciaNumerica,Ano,DigitoVerificador,DataCadastro,TipoProcessoId,OrgaoRemetenteId,UnidadeRemetenteId,OrgaoDestinatarioId,UnidadeDestinatarioId,FluxoProcessoId,ObservacaoProcesso,ProcessoEnviado,ProcessoRecebido")] Processo processo)
        {
            if (id != processo?.OrgaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(processo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
               /*     if (!ProcessoExists(processo.OrgaoId?))
                    {
                        return NotFound();
                    }
                    else
                    {*/
                        throw;
                    //}
                }
                return RedirectToAction(nameof(Index));
            }
            
            ViewData["OrgaoId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId", processo.OrgaoId);
            ViewData["OrgaoDestinatarioId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId", processo.OrgaoDestinatarioId);
            ViewData["OrgaoRemetenteId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId", processo.OrgaoRemetenteId);
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "TipoProcessoId", processo.TipoProcessoId);
            ViewData["UnidadeDestinatarioId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "UnidadeId", processo.UnidadeDestinatarioId);
            ViewData["UnidadeRemetenteId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "UnidadeId", processo.UnidadeRemetenteId);
            return View(processo);
        }

        // GET: Processo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.dbSProcessos == null)
            {
                return NotFound();
            }

            var processo = await _context.dbSProcessos
            
                .Include(p => p.Orgao)
                .Include(p => p.OrgaoDestinatario)
                .Include(p => p.OrgaoRemetente)
                .Include(p => p.TipoProcesso)
                .Include(p => p.UnidadeDestinatario)
                .Include(p => p.UnidadeRemetente)
                .FirstOrDefaultAsync(m => m.OrgaoId == id);
            if (processo == null)
            {
                return NotFound();
            }

            return View(processo);
        }

        // POST: Processo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.dbSProcessos == null)
            {
                return Problem("Entity set 'ContextoAplicacao.dbSProcessos'  is null.");
            }
            var processo = await _context.dbSProcessos.FindAsync(id);
            if (processo != null)
            {
                _context.dbSProcessos.Remove(processo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProcessoExists(int id)
        {
          return (_context.dbSProcessos?.Any(e => e.OrgaoId == id)).GetValueOrDefault();
        }
    }
}
