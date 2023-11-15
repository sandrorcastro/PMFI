using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fazenda.Entities.DBProsiga;
using Fazenda.Models;

namespace Fazenda.Controllers
{
    public class IPTUSimuladoController : Controller
    {
        private readonly DbprosigaContext _context;

        public IPTUSimuladoController(DbprosigaContext context)
        {
            _context = context;
        }

        // GET: IPTUSimulado
        public async Task<IActionResult> Index()
        {
            var imoveis = await _context.TribEdificacoes.Where(e => ((e.EdifCaracteristica == "Predial" && e.EdifContinuacaoTerreno == "Não")
                                                                  ||
                                                                (e.EdifCaracteristica == "Territorial" && e.EdifContinuacaoTerreno == "Sim"))
                                                                  &&
                                                                 (e.EdifSituacao == "Normal")
                                                                   &&
                                                                   //  e.InscricaoImobiliaria == "06206021738001"
                                                                   e.Terreno.TerrAreaTerreno < 10000


                                                                ).Take(10).Include(t=>t.Terreno).ToListAsync(); //  .Take(10).ToListAsync();
            List<IPTU> iPTUs = new List<IPTU>();
            foreach (TribEdificaco imovel in imoveis)
            {
                iPTUs.Add(new IPTU(imovel));
            }
            return View(iPTUs);
        }

        // GET: IPTUSimulado/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.IPTU == null)
            {
                return NotFound();
            }

            var iPTU = await _context.IPTU
                .FirstOrDefaultAsync(m => m.IPTUID == id);
            if (iPTU == null)
            {
                return NotFound();
            }

            return View(iPTU);
        }

        // GET: IPTUSimulado/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IPTUSimulado/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IPTUID,ID")] IPTU iPTU)
        {
            if (ModelState.IsValid)
            {
                _context.Add(iPTU);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(iPTU);
        }

        // GET: IPTUSimulado/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.IPTU == null)
            {
                return NotFound();
            }

            var iPTU = await _context.IPTU.FindAsync(id);
            if (iPTU == null)
            {
                return NotFound();
            }
            return View(iPTU);
        }

        // POST: IPTUSimulado/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("IPTUID,ID")] IPTU iPTU)
        {
            if (id != iPTU.IPTUID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(iPTU);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IPTUExists(iPTU.IPTUID))
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
            return View(iPTU);
        }

        // GET: IPTUSimulado/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.IPTU == null)
            {
                return NotFound();
            }

            var iPTU = await _context.IPTU
                .FirstOrDefaultAsync(m => m.IPTUID == id);
            if (iPTU == null)
            {
                return NotFound();
            }

            return View(iPTU);
        }

        // POST: IPTUSimulado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.IPTU == null)
            {
                return Problem("Entity set 'DbprosigaContext.IPTU'  is null.");
            }
            var iPTU = await _context.IPTU.FindAsync(id);
            if (iPTU != null)
            {
                _context.IPTU.Remove(iPTU);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IPTUExists(long id)
        {
          return (_context.IPTU?.Any(e => e.IPTUID == id)).GetValueOrDefault();
        }
    }
}
