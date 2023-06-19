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
    public class ObjetoProcessoController : Controller
    {
        private readonly ContextoAplicacao _context;

        public ObjetoProcessoController(ContextoAplicacao context)
        {
            _context = context;
        }

        // GET: ObjetoProcesso
        public async Task<IActionResult> Index()
        {
            var contextoAplicacao = _context.dbSObjetosProcesso.Include(o => o.Economia).Include(o => o.Endereco).Include(o => o.Imovel).Include(o => o.Pessoa).Include(o => o.Processo);
            return View(await contextoAplicacao.ToListAsync());
        }

        // GET: ObjetoProcesso/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.dbSObjetosProcesso == null)
            {
                return NotFound();
            }

            var objetoProcesso = await _context.dbSObjetosProcesso
                .Include(o => o.Economia)
                .Include(o => o.Endereco)
                .Include(o => o.Imovel)
                .Include(o => o.Pessoa)
                .Include(o => o.Processo)
                .FirstOrDefaultAsync(m => m.ProcessoId == id);
            if (objetoProcesso == null)
            {
                return NotFound();
            }

            return View(objetoProcesso);
        }

        // GET: ObjetoProcesso/Create
        public IActionResult Create()
        {
            ViewData["ImovelId"] = new SelectList(_context.dbSEconomias, "ImovelId", "ImovelId");
            ViewData["EnderecoId"] = new SelectList(_context.dbSEnderecos, "EnderecoId", "EnderecoId");
            ViewData["ImovelId"] = new SelectList(_context.dbSImoveis, "ImovelId", "ImovelId");
            ViewData["PessoaId"] = new SelectList(_context.dbSPessoas, "PessoaId", "Nome");
            ViewData["ProcessoId"] = new SelectList(_context.dbSProcessos, "ProcessoId", "ProcessoId");
            return View();
        }

        // POST: ObjetoProcesso/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProcessoId,TipoObjetoProcesso,DescricaoObjetoProcesso,PessoaId,EconomiaId,ImovelId,EnderecoId")] ObjetoProcesso objetoProcesso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(objetoProcesso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ImovelId"] = new SelectList(_context.dbSEconomias, "ImovelId", "ImovelId", objetoProcesso.ImovelId);
            ViewData["EnderecoId"] = new SelectList(_context.dbSEnderecos, "EnderecoId", "EnderecoId", objetoProcesso.EnderecoId);
            ViewData["ImovelId"] = new SelectList(_context.dbSImoveis, "ImovelId", "ImovelId", objetoProcesso.ImovelId);
            ViewData["PessoaId"] = new SelectList(_context.dbSPessoas, "PessoaId", "Nome", objetoProcesso.PessoaId);
            ViewData["ProcessoId"] = new SelectList(_context.dbSProcessos, "ProcessoId", "ProcessoId", objetoProcesso.ProcessoId);
            return View(objetoProcesso);
        }

        // GET: ObjetoProcesso/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.dbSObjetosProcesso == null)
            {
                return NotFound();
            }

            var objetoProcesso = await _context.dbSObjetosProcesso.FindAsync(id);
            if (objetoProcesso == null)
            {
                return NotFound();
            }
            ViewData["ImovelId"] = new SelectList(_context.dbSEconomias, "ImovelId", "ImovelId", objetoProcesso.ImovelId);
            ViewData["EnderecoId"] = new SelectList(_context.dbSEnderecos, "EnderecoId", "EnderecoId", objetoProcesso.EnderecoId);
            ViewData["ImovelId"] = new SelectList(_context.dbSImoveis, "ImovelId", "ImovelId", objetoProcesso.ImovelId);
            ViewData["PessoaId"] = new SelectList(_context.dbSPessoas, "PessoaId", "Nome", objetoProcesso.PessoaId);
            ViewData["ProcessoId"] = new SelectList(_context.dbSProcessos, "ProcessoId", "ProcessoId", objetoProcesso.ProcessoId);
            return View(objetoProcesso);
        }

        // POST: ObjetoProcesso/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ProcessoId,TipoObjetoProcesso,DescricaoObjetoProcesso,PessoaId,EconomiaId,ImovelId,EnderecoId")] ObjetoProcesso objetoProcesso)
        {
            if (id != objetoProcesso.ProcessoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(objetoProcesso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ObjetoProcessoExists(objetoProcesso.ProcessoId))
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
            ViewData["ImovelId"] = new SelectList(_context.dbSEconomias, "ImovelId", "ImovelId", objetoProcesso.ImovelId);
            ViewData["EnderecoId"] = new SelectList(_context.dbSEnderecos, "EnderecoId", "EnderecoId", objetoProcesso.EnderecoId);
            ViewData["ImovelId"] = new SelectList(_context.dbSImoveis, "ImovelId", "ImovelId", objetoProcesso.ImovelId);
            ViewData["PessoaId"] = new SelectList(_context.dbSPessoas, "PessoaId", "Nome", objetoProcesso.PessoaId);
            ViewData["ProcessoId"] = new SelectList(_context.dbSProcessos, "ProcessoId", "ProcessoId", objetoProcesso.ProcessoId);
            return View(objetoProcesso);
        }

        // GET: ObjetoProcesso/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.dbSObjetosProcesso == null)
            {
                return NotFound();
            }

            var objetoProcesso = await _context.dbSObjetosProcesso
                .Include(o => o.Economia)
                .Include(o => o.Endereco)
                .Include(o => o.Imovel)
                .Include(o => o.Pessoa)
                .Include(o => o.Processo)
                .FirstOrDefaultAsync(m => m.ProcessoId == id);
            if (objetoProcesso == null)
            {
                return NotFound();
            }

            return View(objetoProcesso);
        }

        // POST: ObjetoProcesso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.dbSObjetosProcesso == null)
            {
                return Problem("Entity set 'ContextoAplicacao.dbSObjetosProcesso'  is null.");
            }
            var objetoProcesso = await _context.dbSObjetosProcesso.FindAsync(id);
            if (objetoProcesso != null)
            {
                _context.dbSObjetosProcesso.Remove(objetoProcesso);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ObjetoProcessoExists(long id)
        {
          return (_context.dbSObjetosProcesso?.Any(e => e.ProcessoId == id)).GetValueOrDefault();
        }
    }
}
