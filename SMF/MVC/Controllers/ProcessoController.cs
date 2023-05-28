using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infra.Context;

namespace MVC.Controllers
{
    public class ProcessoController : Controller
    {
        private readonly ContextoAplicacao _context;

        public ProcessoController(ContextoAplicacao context)
        {
            _context = context;
        }

        // GET: Processo
        public async Task<IActionResult> Index()
        {
            var contextoAplicacao = _context.dbSProcessos.Include(p => p.Orgao).Include(p => p.OrgaoDestinatario).Include(p => p.OrgaoRemetente).Include(p => p.Servidor).Include(p => p.SituacaoProcesso).Include(p => p.TipoProcesso).Include(p => p.UnidadeDestinatario).Include(p => p.UnidadeRemetente);
            return View(await contextoAplicacao.ToListAsync());
        }

        // GET: Processo/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.dbSProcessos == null)
            {
                return NotFound();
            }

            var processo = await _context.dbSProcessos
                .Include(p => p.Orgao)
                .Include(p => p.OrgaoDestinatario)
                .Include(p => p.OrgaoRemetente)
                .Include(p => p.Servidor)
                .Include(p => p.SituacaoProcesso)
                .Include(p => p.TipoProcesso)
                .Include(p => p.UnidadeDestinatario)
                .Include(p => p.UnidadeRemetente)
                .FirstOrDefaultAsync(m => m.ProcessoId == id);
            if (processo == null)
            {
                return NotFound();
            }

            return View(processo);
        }

        // GET: Processo/Create
        public IActionResult Create()
        {
            ViewData["OrgaoId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId");
            ViewData["OrgaoDestinatarioId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId");
            ViewData["OrgaoRemetenteId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId");
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "ServidorId");
            ViewData["SituacaoProcessoId"] = new SelectList(_context.dbSSituacoesProcesso, "SituacaoProcessoId", "SituacaoProcessoId");
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
        public async Task<IActionResult> Create([Bind("ProcessoId,OrgaoId,Ano,DataInicio,DataFim,TipoProcessoId,SituacaoProcessoId,OrgaoRemetenteId,UnidadeRemetenteId,OrgaoDestinatarioId,UnidadeDestinatarioId,ServidorId,ObservacaoProcesso,ProcessoEnviado,ProcessoRecebido,ProcessoAntigo")] Processo processo)
        {
            if (ModelState.IsValid)
            {
                ObjetoProcesso op = new ObjetoProcesso();
                
                //op.TipoObjetoProcesso = 1;
                //op.DescricaoObjetoProcesso = "Ainda não sei";
                processo.ObjetoProcesso = op;
                //_context.Add(op);
                _context.AddRangeAsync(processo);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrgaoId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId", processo.OrgaoId);
            ViewData["OrgaoDestinatarioId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId", processo.OrgaoDestinatarioId);
            ViewData["OrgaoRemetenteId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId", processo.OrgaoRemetenteId);
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "ServidorId", processo.ServidorId);
            ViewData["SituacaoProcessoId"] = new SelectList(_context.dbSSituacoesProcesso, "SituacaoProcessoId", "SituacaoProcessoId", processo.SituacaoProcessoId);
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "TipoProcessoId", processo.TipoProcessoId);
            ViewData["UnidadeDestinatarioId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "UnidadeId", processo.UnidadeDestinatarioId);
            ViewData["UnidadeRemetenteId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "UnidadeId", processo.UnidadeRemetenteId);
            return View(processo);
        }

        // GET: Processo/Edit/5
        public async Task<IActionResult> Edit(long? id)
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
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "ServidorId", processo.ServidorId);
            ViewData["SituacaoProcessoId"] = new SelectList(_context.dbSSituacoesProcesso, "SituacaoProcessoId", "SituacaoProcessoId", processo.SituacaoProcessoId);
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
        public async Task<IActionResult> Edit(long id, [Bind("ProcessoId,OrgaoId,Ano,DataInicio,DataFim,TipoProcessoId,SituacaoProcessoId,OrgaoRemetenteId,UnidadeRemetenteId,OrgaoDestinatarioId,UnidadeDestinatarioId,ServidorId,ObservacaoProcesso,ProcessoEnviado,ProcessoRecebido,ProcessoAntigo")] Processo processo)
        {
            if (id != processo.ProcessoId)
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
                    if (!ProcessoExists(processo.ProcessoId))
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
            ViewData["OrgaoId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId", processo.OrgaoId);
            ViewData["OrgaoDestinatarioId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId", processo.OrgaoDestinatarioId);
            ViewData["OrgaoRemetenteId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "OrgaoId", processo.OrgaoRemetenteId);
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "ServidorId", processo.ServidorId);
            ViewData["SituacaoProcessoId"] = new SelectList(_context.dbSSituacoesProcesso, "SituacaoProcessoId", "SituacaoProcessoId", processo.SituacaoProcessoId);
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "TipoProcessoId", processo.TipoProcessoId);
            ViewData["UnidadeDestinatarioId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "UnidadeId", processo.UnidadeDestinatarioId);
            ViewData["UnidadeRemetenteId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "UnidadeId", processo.UnidadeRemetenteId);
            return View(processo);
        }

        // GET: Processo/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.dbSProcessos == null)
            {
                return NotFound();
            }

            var processo = await _context.dbSProcessos
                .Include(p => p.Orgao)
                .Include(p => p.OrgaoDestinatario)
                .Include(p => p.OrgaoRemetente)
                .Include(p => p.Servidor)
                .Include(p => p.SituacaoProcesso)
                .Include(p => p.TipoProcesso)
                .Include(p => p.UnidadeDestinatario)
                .Include(p => p.UnidadeRemetente)
                .FirstOrDefaultAsync(m => m.ProcessoId == id);
            if (processo == null)
            {
                return NotFound();
            }

            return View(processo);
        }

        // POST: Processo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
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

        private bool ProcessoExists(long id)
        {
          return (_context.dbSProcessos?.Any(e => e.ProcessoId == id)).GetValueOrDefault();
        }
    }
}
