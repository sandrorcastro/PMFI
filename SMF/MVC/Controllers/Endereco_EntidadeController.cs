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
    public class Endereco_EntidadeController : Controller
    {
        private readonly ContextoAplicacao _context;

        public Endereco_EntidadeController(ContextoAplicacao context)
        {
            _context = context;
        }

        // GET: Endereco_Entidade
        public async Task<IActionResult> Index()
        {
            var contextoAplicacao = _context.dbSEnderecos_Entidades.Include(e => e.Endereco);
            return View(await contextoAplicacao.ToListAsync());
        }

        // GET: Endereco_Entidade/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.dbSEnderecos_Entidades == null)
            {
                return NotFound();
            }

            var endereco_Entidade = await _context.dbSEnderecos_Entidades
                .Include(e => e.Endereco)
                .FirstOrDefaultAsync(m => m.EntidadeId == id);
            if (endereco_Entidade == null)
            {
                return NotFound();
            }

            return View(endereco_Entidade);
        }

        // GET: Endereco_Entidade/Create
        public IActionResult Create()
        {
            ViewData["EnderecoId"] = new SelectList(_context.dbSEnderecos, "EnderecoId", "EnderecoId");
            return View();
        }

        // POST: Endereco_Entidade/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EntidadeId,EnderecoId,Numero,DataCadastro,DataUltimaAlteracao,CEP,TipoEntidadeId,Correspondencia,Principal,Ativo")] Endereco_Entidade endereco_Entidade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(endereco_Entidade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EnderecoId"] = new SelectList(_context.dbSEnderecos, "EnderecoId", "EnderecoId", endereco_Entidade.EnderecoId);
            return View(endereco_Entidade);
        }

        // GET: Endereco_Entidade/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.dbSEnderecos_Entidades == null)
            {
                return NotFound();
            }

            var endereco_Entidade = await _context.dbSEnderecos_Entidades.FindAsync(id);
            if (endereco_Entidade == null)
            {
                return NotFound();
            }
            ViewData["EnderecoId"] = new SelectList(_context.dbSEnderecos, "EnderecoId", "EnderecoId", endereco_Entidade.EnderecoId);
            return View(endereco_Entidade);
        }

        // POST: Endereco_Entidade/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("EntidadeId,EnderecoId,Numero,DataCadastro,DataUltimaAlteracao,CEP,TipoEntidadeId,Correspondencia,Principal,Ativo")] Endereco_Entidade endereco_Entidade)
        {
            if (id != endereco_Entidade.EntidadeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(endereco_Entidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Endereco_EntidadeExists(endereco_Entidade.EntidadeId))
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
            ViewData["EnderecoId"] = new SelectList(_context.dbSEnderecos, "EnderecoId", "EnderecoId", endereco_Entidade.EnderecoId);
            return View(endereco_Entidade);
        }

        // GET: Endereco_Entidade/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.dbSEnderecos_Entidades == null)
            {
                return NotFound();
            }

            var endereco_Entidade = await _context.dbSEnderecos_Entidades
                .Include(e => e.Endereco)
                .FirstOrDefaultAsync(m => m.EntidadeId == id);
            if (endereco_Entidade == null)
            {
                return NotFound();
            }

            return View(endereco_Entidade);
        }

        // POST: Endereco_Entidade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.dbSEnderecos_Entidades == null)
            {
                return Problem("Entity set 'ContextoAplicacao.dbSEnderecos_Entidades'  is null.");
            }
            var endereco_Entidade = await _context.dbSEnderecos_Entidades.FindAsync(id);
            if (endereco_Entidade != null)
            {
                _context.dbSEnderecos_Entidades.Remove(endereco_Entidade);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Endereco_EntidadeExists(long id)
        {
          return (_context.dbSEnderecos_Entidades?.Any(e => e.EntidadeId == id)).GetValueOrDefault();
        }
    }
}
