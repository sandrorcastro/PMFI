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
    public class Servidor_TipoProcessoController : Controller
    {
        private readonly ContextoAplicacao _context;

        public Servidor_TipoProcessoController(ContextoAplicacao context)
        {
            _context = context;
        }

        // GET: Servidor_TipoProcesso
        public async Task<IActionResult> Index()
        {
            var contextoAplicacao = _context.dbSServidores_TiposProcessos.Include(s => s.Servidor).Include(s => s.TipoProcesso);
            return View(await contextoAplicacao.ToListAsync());
        }

        // GET: Servidor_TipoProcesso/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.dbSServidores_TiposProcessos == null)
            {
                return NotFound();
            }

            var servidor_TipoProcesso = await _context.dbSServidores_TiposProcessos
                .Include(s => s.Servidor)
                .Include(s => s.TipoProcesso)
                .FirstOrDefaultAsync(m => m.ServidorId == id);
            if (servidor_TipoProcesso == null)
            {
                return NotFound();
            }

            return View(servidor_TipoProcesso);
        }

        // GET: Servidor_TipoProcesso/Create
        public IActionResult Create()
        {
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores.OrderBy(d => d.Nome), "ServidorId", "Nome");
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso.OrderBy(d => d.Descricao), "TipoProcessoId", "Descricao");
            return View();
        }

        // POST: Servidor_TipoProcesso/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ServidorId,TipoProcessoId")] Servidor_TipoProcesso servidor_TipoProcesso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(servidor_TipoProcesso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "Nome", servidor_TipoProcesso.ServidorId);
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "Descricao", servidor_TipoProcesso.TipoProcessoId);
            return View(servidor_TipoProcesso);
        }

        // GET: Servidor_TipoProcesso/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.dbSServidores_TiposProcessos == null)
            {
                return NotFound();
            }

            var servidor_TipoProcesso = await _context.dbSServidores_TiposProcessos.FindAsync(id);
            if (servidor_TipoProcesso == null)
            {
                return NotFound();
            }
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores.OrderBy(d=>d.Nome), "ServidorId", "ServidorId", servidor_TipoProcesso.ServidorId);
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso.OrderBy(d=>d.Descricao), "TipoProcessoId", "TipoProcessoId", servidor_TipoProcesso.TipoProcessoId);
            return View(servidor_TipoProcesso);
        }

        // POST: Servidor_TipoProcesso/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ServidorId,TipoProcessoId")] Servidor_TipoProcesso servidor_TipoProcesso)
        {
            if (id != servidor_TipoProcesso.ServidorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(servidor_TipoProcesso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Servidor_TipoProcessoExists(servidor_TipoProcesso.ServidorId))
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
            ViewData["ServidorId"] = new SelectList(_context.dbSServidores, "ServidorId", "ServidorId", servidor_TipoProcesso.ServidorId);
            ViewData["TipoProcessoId"] = new SelectList(_context.dbSTiposProcesso, "TipoProcessoId", "TipoProcessoId", servidor_TipoProcesso.TipoProcessoId);
            return View(servidor_TipoProcesso);
        }

        // GET: Servidor_TipoProcesso/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.dbSServidores_TiposProcessos == null)
            {
                return NotFound();
            }

            var servidor_TipoProcesso = await _context.dbSServidores_TiposProcessos
                .Include(s => s.Servidor)
                .Include(s => s.TipoProcesso)
                .FirstOrDefaultAsync(m => m.ServidorId == id);
            if (servidor_TipoProcesso == null)
            {
                return NotFound();
            }

            return View(servidor_TipoProcesso);
        }

        // POST: Servidor_TipoProcesso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.dbSServidores_TiposProcessos == null)
            {
                return Problem("Entity set 'ContextoAplicacao.dbSServidores_TiposProcessos'  is null.");
            }
            var servidor_TipoProcesso = await _context.dbSServidores_TiposProcessos.FindAsync(id);
            if (servidor_TipoProcesso != null)
            {
                _context.dbSServidores_TiposProcessos.Remove(servidor_TipoProcesso);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Servidor_TipoProcessoExists(long? id)
        {
          return (_context.dbSServidores_TiposProcessos?.Any(e => e.ServidorId == id)).GetValueOrDefault();
        }
    }
}
