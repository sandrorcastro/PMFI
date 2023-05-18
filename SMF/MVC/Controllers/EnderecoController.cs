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
    public class EnderecoController : Controller
    {
        private readonly ContextoAplicacao _context;

        public EnderecoController(ContextoAplicacao context)
        {
            _context = context;
        }

        // GET: Endereco
        public async Task<IActionResult> Index()
        {
            var contextoAplicacao = _context.dbSEnderecos.Include(e => e.Bairro).Include(e => e.Cidade).Include(e => e.Logradouro);
            return View(await contextoAplicacao.ToListAsync());
        }

        // GET: Endereco/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.dbSEnderecos == null)
            {
                return NotFound();
            }

            var endereco = await _context.dbSEnderecos
                .Include(e => e.Bairro)
                .Include(e => e.Cidade)
                .Include(e => e.Logradouro)
                .FirstOrDefaultAsync(m => m.EnderecoId == id);
            if (endereco == null)
            {
                return NotFound();
            }

            return View(endereco);
        }

        // GET: Endereco/Create
        public IActionResult Create()
        {
            ViewData["BairroId"] = new SelectList(_context.dbSBairros, "BairroId", "BairroId");
            ViewData["CidadeId"] = new SelectList(_context.dbSCidades, "CidadeId", "Descricao");
            ViewData["LogradouroId"] = new SelectList(_context.dbSLogradouros, "LogradouroId", "LogradouroId");
            return View();
        }

        // POST: Endereco/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EnderecoId,CidadeId,LogradouroId,BairroId,Complemento,Referencia,Ativo")] Endereco endereco)
        {
            if (ModelState.IsValid)
            {
                _context.Add(endereco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BairroId"] = new SelectList(_context.dbSBairros, "BairroId", "BairroId", endereco.BairroId);
            ViewData["CidadeId"] = new SelectList(_context.dbSCidades, "CidadeId", "Descricao", endereco.CidadeId);
            ViewData["LogradouroId"] = new SelectList(_context.dbSLogradouros, "LogradouroId", "LogradouroId", endereco.LogradouroId);
            return View(endereco);
        }

        // GET: Endereco/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.dbSEnderecos == null)
            {
                return NotFound();
            }

            var endereco = await _context.dbSEnderecos.FindAsync(id);
            if (endereco == null)
            {
                return NotFound();
            }
            ViewData["BairroId"] = new SelectList(_context.dbSBairros, "BairroId", "BairroId", endereco.BairroId);
            ViewData["CidadeId"] = new SelectList(_context.dbSCidades, "CidadeId", "Descricao", endereco.CidadeId);
            ViewData["LogradouroId"] = new SelectList(_context.dbSLogradouros, "LogradouroId", "LogradouroId", endereco.LogradouroId);
            return View(endereco);
        }

        // POST: Endereco/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("EnderecoId,CidadeId,LogradouroId,BairroId,Complemento,Referencia,Ativo")] Endereco endereco)
        {
            if (id != endereco.EnderecoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(endereco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnderecoExists(endereco.EnderecoId))
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
            ViewData["BairroId"] = new SelectList(_context.dbSBairros, "BairroId", "BairroId", endereco.BairroId);
            ViewData["CidadeId"] = new SelectList(_context.dbSCidades, "CidadeId", "Descricao", endereco.CidadeId);
            ViewData["LogradouroId"] = new SelectList(_context.dbSLogradouros, "LogradouroId", "LogradouroId", endereco.LogradouroId);
            return View(endereco);
        }

        // GET: Endereco/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.dbSEnderecos == null)
            {
                return NotFound();
            }

            var endereco = await _context.dbSEnderecos
                .Include(e => e.Bairro)
                .Include(e => e.Cidade)
                .Include(e => e.Logradouro)
                .FirstOrDefaultAsync(m => m.EnderecoId == id);
            if (endereco == null)
            {
                return NotFound();
            }

            return View(endereco);
        }

        // POST: Endereco/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.dbSEnderecos == null)
            {
                return Problem("Entity set 'ContextoAplicacao.dbSEnderecos'  is null.");
            }
            var endereco = await _context.dbSEnderecos.FindAsync(id);
            if (endereco != null)
            {
                _context.dbSEnderecos.Remove(endereco);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnderecoExists(long id)
        {
          return (_context.dbSEnderecos?.Any(e => e.EnderecoId == id)).GetValueOrDefault();
        }
    }
}
