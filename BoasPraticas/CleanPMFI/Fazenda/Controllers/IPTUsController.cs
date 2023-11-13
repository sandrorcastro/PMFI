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
    public class IPTUsController : Controller
    {
        private readonly DbprosigaContext _context;

        public IPTUsController(DbprosigaContext context)
        {
            _context = context;
        }

        // GET: IPTUs
        public async Task<IActionResult> Index()
        {
            //return _context.TribEdificacoes  != null ? View(await _context.IPTU.ToListAsync()) : Problem("Entity set 'DbprosigaContext.IPTU'  is null.");

            var imoveis = from Imoveis in _context.TribEdificacoes.Where(es => es.EdifSituacao == "Normal" && es.InscricaoImobiliaria.Length==14 && es.Terreno.TerrAreaTerreno > 10000)
                                                                              .Include(te => te.Terreno).ThenInclude(p => p.Pedo)
                                                                              .Include(to => to.Terreno).ThenInclude(to => to.Topo)
                                                                              .Include(to => to.Terreno).ThenInclude(lq => lq.LocQ)
                                                                              .Take(10)
                          select Imoveis;

            /*            IEnumerable<TribEdificaco> imoveis = await _context.TribEdificacoes.Where(es=>es.EdifSituacao=="Normal")
                                                                                           .Include(te=>te.Terreno).ThenInclude(p=>p.Pedo)
                                                                                           .Include(to=>to.Terreno).ThenInclude(to=>to.Topo)
                                                                                           .Include(to => to.Terreno).ThenInclude(lq => lq.LocQ)
                                                                                           .Take(10).ToListAsync();*/
            List < IPTU > iPTUs = new List<IPTU>();
            foreach (TribEdificaco imovel in imoveis.AsNoTracking())
            {
                //Console.WriteLine($"Id: {imovel.Id}, Nome: {imovel.Nome}");
                //  TribFatorCorArea  fatorA = imovel.Terreno.TerrAreaTerreno < 10000 ? new TribFatorCorArea() { FatCorAreaAte=1}  :  _context.TribFatorCorAreas.Where(fa => fa.FatCorAreaDe < imovel.Terreno.TerrAreaTerreno && fa.FatCorAreaAte >= imovel.Terreno.TerrAreaTerreno).FirstOrDefault();
                //iPTUs.Add(new IPTU(imovel) { FatorA= (decimal) fatorA.FatCorAreaFator.GetValueOrDefault()});
                //IPTU iptu = new IPTU(imovel);
                //iptu.obterInscricoesImobiliariaPorQuadra();
                iPTUs.Add(new IPTU(imovel));
                //iPTUs.Add(iptu);

            }

            //var  imovel = await _context.TribEdificacoes.FindAsync((long) 78);
            //IPTU iPTU = new IPTU(imovel);
            //List<IPTU> iPTUs = new List<IPTU>();
            //iPTUs.Add(iPTU);
            return View(iPTUs);
        }

        // GET: IPTUs/Details/5
        public async Task<IActionResult> Details(long id)
        {
            if (id == null || _context.TribEdificacoes == null)
            {
                return NotFound();
            }
            
            var imovel = await _context.TribEdificacoes
                                        .Include(te => te.Terreno).ThenInclude(p => p.Pedo)
                                        .Include(to => to.Terreno).ThenInclude(to => to.Topo)
                                        .Include(to => to.Terreno).ThenInclude(lq => lq.LocQ).FirstOrDefaultAsync(m => m.EdificacaoId == id);
            
            IPTU iPTU = new IPTU(imovel);
            if (iPTU == null)
            {
                return NotFound();
            }

            return View(iPTU);
        }

        // GET: IPTUs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IPTUs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,InscricaoImobiliaria")] IPTU iPTU)
        {
            if (ModelState.IsValid)
            {
                _context.Add(iPTU);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(iPTU);
        }

        // GET: IPTUs/Edit/5
        public async Task<IActionResult> Edit(long id)
        {
            if (id == null || _context.TribEdificacoes == null)
            {
                return NotFound();
            }

            var iPTU = await _context.TribEdificacoes.FindAsync(id);
            if (iPTU == null)
            {
                return NotFound();
            }
            return View(iPTU);
        }

        // POST: IPTUs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ID,InscricaoImobiliaria")] IPTU iPTU)
        {
            if (id != iPTU.ID)
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
                    if (!IPTUExists(iPTU.ID))
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

        // GET: IPTUs/Delete/5
        public async Task<IActionResult> Delete(long id)
        {
            if (id == null || _context.IPTU == null)
            {
                return NotFound();
            }

            var iPTU = await _context.IPTU
                .FirstOrDefaultAsync(m => m.ID == id);
            if (iPTU == null)
            {
                return NotFound();
            }

            return View(iPTU);
        }

        // POST: IPTUs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
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
          return (_context.IPTU?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
