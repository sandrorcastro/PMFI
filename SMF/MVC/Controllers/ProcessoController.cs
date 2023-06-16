using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infra.Context;
using Microsoft.AspNetCore.Authorization;
using Application.Services;
using MVC.ViewModels;
using Application.Interfaces;
using MVC.Models;
using MVC.Extensions;

namespace MVC.Controllers
{
    [Authorize]
    public class ProcessoController : Controller
    {
        private readonly ContextoAplicacao _context;
        private readonly IProcessoAppService processoAppService;
        public ProcessoController(ContextoAplicacao context, IProcessoAppService processoAppService)
        {
            _context = context;
            this.processoAppService = processoAppService;
        }

        // GET: Processo
        public async Task<IActionResult> Index(string sort, string filter, int p, SortDirection direction)
        {
            /*var contextoAplicacao = _context.dbSProcessos.Where(pi=>pi.ProcessoInativo==false)
                                                         .Include(p => p.Orgao)
                                                         .Include(p => p.Unidade)
                                                         .Include(p => p.Divisao)
                                                         .Include(p => p.OrgaoDestinatario)
                                                         .Include(p => p.UnidadeDestinatario)
                                                         .Include(p => p.DivisaoDestinatario)
                                                         .Include(p => p.OrgaoRemetente)
                                                         .Include(p => p.UnidadeRemetente)
                                                         .Include(p => p.DivisaoRemetente)
                                                         .Include(p => p.Servidor)
                                                         .Include(p => p.ServidorExecutor)
                                                         .Include(p => p.SituacaoProcesso)
                                                         .Include(p => p.TipoProcesso);*/
           // return View(await contextoAplicacao.ToListAsync());

            var query = from s in processoAppService.GetIQueryable().Filter(filter).OrderBy(sort, direction) select s;// ToPagedList(1,1,10) ;
            ProcessoPaginatedListViewModel pPLVM = new ProcessoPaginatedListViewModel(sort, filter);
            pPLVM.values = await ProcessoPaginatedListViewModel.CreateAsync(query, p == 0 ? 1 : p, 10);
            pPLVM.Filter = filter;
            pPLVM.Sort = sort;
            return View(pPLVM);





        }

        // GET: Processo/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.dbSProcessos == null)
            {
                return NotFound();
            }

            var processo = await _context.dbSProcessos.Where(pi => pi.ProcessoInativo == false)
                .Include(p => p.Orgao)
                .Include(p => p.OrgaoDestinatario)
                .Include(p => p.OrgaoRemetente)
                .Include(p => p.Servidor)
                .Include(p => p.ServidorExecutor)
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
            var matriculaservidorId = User.Claims.FirstOrDefault().Value;
            var Servidor = _context.dbSServidores.Where(m => m.Matricula == matriculaservidorId && m.Ativo == true).Include(tp => tp.PodeExecutar).ThenInclude(tp => tp.TipoProcesso).Include(d => d.Divisao).ThenInclude(u => u.Unidade).ThenInclude(o => o.Orgao).FirstOrDefault();

            ViewData["OrgaoId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "Descricao",Servidor.Divisao.Unidade.OrgaoId);
            ViewData["OrgaoDestinatarioId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "Descricao", Servidor.Divisao.Unidade.OrgaoId);
            ViewData["OrgaoRemetenteId"] = new SelectList(_context.dbSOrgaos, "OrgaoId", "Descricao", Servidor.Divisao.Unidade.OrgaoId);
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "Nome",Servidor.ServidorId);
            ViewData["ServidorExecutorId"] = new SelectList(_context.dbSServidores, "ServidorId", "Nome");
            ViewData["SituacaoProcessoId"] = new SelectList(_context.dbSSituacoesProcesso, "SituacaoProcessoId", "Descricao");
            //ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "Descricao");
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso.Join(_context.dbSServidores_TiposProcessos, tipoprocesso => tipoprocesso.TipoProcessoId,
                            servidortipoprocesso => servidortipoprocesso.TipoProcessoId, (tipoprocesso, servidortipoprocesso) => new { TipoProcesso = tipoprocesso, ServidorTipoProcesso = servidortipoprocesso })
                .Where(resultado => resultado.ServidorTipoProcesso.ServidorId == Servidor.ServidorId)
                .Select(resultado => new { resultado.TipoProcesso.TipoProcessoId, resultado.TipoProcesso.Descricao }).ToList(), "TipoProcessoId", "Descricao");


            ViewData["UnidadeId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "Descricao", Servidor.Divisao.UnidadeId);
            ViewData["UnidadeDestinatarioId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "Descricao", Servidor.Divisao.UnidadeId);
            ViewData["UnidadeRemetenteId"] = new SelectList(_context.dbSUnidades, "UnidadeId", "Descricao", Servidor.Divisao.UnidadeId);
            ViewData["DivisaoId"] = new SelectList(_context.dbSDivisoes, "DivisaoId", "Descricao", Servidor.DivisaoId);
            ViewData["DivisaoDestinatarioId"] = new SelectList(_context.dbSDivisoes, "DivisaoId", "Descricao", Servidor.DivisaoId);
            ViewData["DivisaoRemetenteId"] = new SelectList(_context.dbSDivisoes, "DivisaoId", "Descricao", Servidor.DivisaoId);
            return View();
        }

        // POST: Processo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProcessoId,OrgaoId,Ano,DataInicio,DataFim,TipoProcessoId,SituacaoProcessoId,OrgaoRemetenteId,UnidadeRemetenteId,OrgaoDestinatarioId,UnidadeDestinatarioId,ServidorId,ServidorExecutorId,ObservacaoProcesso,ProcessoEnviado,ProcessoRecebido,ProcessoAntigo")] Processo processo)
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
