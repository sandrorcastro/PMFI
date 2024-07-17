using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DBProsiga.Entities;

namespace MVC_Prosiga.Controllers
{
    public class DividasContribuintesController : Controller
    {
        private readonly DbproSigaContext _context;

        public DividasContribuintesController(DbproSigaContext context)
        {
            _context = context;
        }

        // GET: DividasContribuintes
        public async Task<IActionResult> Index()
        {
            var dbproSigaContext = _context.TribDividasContribuintes.Include(t => t.Con).Take(50);
            return View(await dbproSigaContext.ToListAsync());
        }

        // GET: DividasContribuintes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.TribDividasContribuintes == null)
            {
                return NotFound();
            }

            var tribDividasContribuinte = await _context.TribDividasContribuintes
                .Include(t => t.Con)
                .FirstOrDefaultAsync(m => m.ConIddivida == id);
            if (tribDividasContribuinte == null)
            {
                return NotFound();
            }

            return View(tribDividasContribuinte);
        }

        // GET: DividasContribuintes/Create
        public IActionResult Create()
        {
            ViewData["ConId"] = new SelectList(_context.Contribuintes, "ConId", "ConTipoPessoa");
            return View();
        }

        // POST: DividasContribuintes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ConIddivida,ConId,ConDivAno,TipoTribId,ConDivSubDivida,ConDivParcela,ConDivVencimento,ConDivDataGeracao,ConDivTipoDivida,ConDivDataBloqCorrecao,ConDivDataBloqJuros,ConDivDataBloqMulta,ConDivVlrUltimaCorrecao,ConDivDataUltimaCorrecao,ConDivOrigemLancamento,ConDivParcelaUnica,TipoBxId,ConDivMes,ConDivDataBaixa,ConDivValorHistorico,ConDivValorBaixa,ConDivMotivoBaixa,ConDivQtdeBaixas,AutoInfrId,UsuarioInclusao,ConDivBxVlrJuros,ConDivBxVlrMulta,ConDivBxVlrCorrecao,ConDivBxVlrDesconto,ConDivBxVlrMultaDa,ConDivObs,ConDivDescDivida,ConDivSaiBoleto,Idmoeda,EdiId,ConDivValor,Multa,Juros,Correcao,MultaDividaAtiva,DataCalculo,ConDivValorBkp,ConDivExcluido")] TribDividasContribuinte tribDividasContribuinte)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tribDividasContribuinte);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ConId"] = new SelectList(_context.Contribuintes, "ConId", "ConTipoPessoa", tribDividasContribuinte.ConId);
            return View(tribDividasContribuinte);
        }

        // GET: DividasContribuintes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.TribDividasContribuintes == null)
            {
                return NotFound();
            }

            var tribDividasContribuinte = await _context.TribDividasContribuintes.FindAsync(id);
            if (tribDividasContribuinte == null)
            {
                return NotFound();
            }
            ViewData["ConId"] = new SelectList(_context.Contribuintes, "ConId", "ConTipoPessoa", tribDividasContribuinte.ConId);
            return View(tribDividasContribuinte);
        }

        // POST: DividasContribuintes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ConIddivida,ConId,ConDivAno,TipoTribId,ConDivSubDivida,ConDivParcela,ConDivVencimento,ConDivDataGeracao,ConDivTipoDivida,ConDivDataBloqCorrecao,ConDivDataBloqJuros,ConDivDataBloqMulta,ConDivVlrUltimaCorrecao,ConDivDataUltimaCorrecao,ConDivOrigemLancamento,ConDivParcelaUnica,TipoBxId,ConDivMes,ConDivDataBaixa,ConDivValorHistorico,ConDivValorBaixa,ConDivMotivoBaixa,ConDivQtdeBaixas,AutoInfrId,UsuarioInclusao,ConDivBxVlrJuros,ConDivBxVlrMulta,ConDivBxVlrCorrecao,ConDivBxVlrDesconto,ConDivBxVlrMultaDa,ConDivObs,ConDivDescDivida,ConDivSaiBoleto,Idmoeda,EdiId,ConDivValor,Multa,Juros,Correcao,MultaDividaAtiva,DataCalculo,ConDivValorBkp,ConDivExcluido")] TribDividasContribuinte tribDividasContribuinte)
        {
            if (id != tribDividasContribuinte.ConIddivida)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tribDividasContribuinte);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TribDividasContribuinteExists(tribDividasContribuinte.ConIddivida))
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
            ViewData["ConId"] = new SelectList(_context.Contribuintes, "ConId", "ConTipoPessoa", tribDividasContribuinte.ConId);
            return View(tribDividasContribuinte);
        }

        // GET: DividasContribuintes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.TribDividasContribuintes == null)
            {
                return NotFound();
            }

            var tribDividasContribuinte = await _context.TribDividasContribuintes
                .Include(t => t.Con)
                .FirstOrDefaultAsync(m => m.ConIddivida == id);
            if (tribDividasContribuinte == null)
            {
                return NotFound();
            }

            return View(tribDividasContribuinte);
        }

        // POST: DividasContribuintes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.TribDividasContribuintes == null)
            {
                return Problem("Entity set 'DbproSigaContext.TribDividasContribuintes'  is null.");
            }
            var tribDividasContribuinte = await _context.TribDividasContribuintes.FindAsync(id);
            if (tribDividasContribuinte != null)
            {
                _context.TribDividasContribuintes.Remove(tribDividasContribuinte);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TribDividasContribuinteExists(long id)
        {
          return (_context.TribDividasContribuintes?.Any(e => e.ConIddivida == id)).GetValueOrDefault();
        }
    }
}
