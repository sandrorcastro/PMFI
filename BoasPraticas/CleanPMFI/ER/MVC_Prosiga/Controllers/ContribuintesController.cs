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
    public class ContribuintesController : Controller
    {
        private readonly DbproSigaContext _context;

        public ContribuintesController(DbproSigaContext context)
        {
            _context = context;
        }

        // GET: Contribuintes
        public async Task<IActionResult> Index()
        {
            var dbproSigaContext = _context.Contribuintes.Include(c => c.ConBairro).Include(c => c.ConCidade).Take(50);
            return View(await dbproSigaContext.ToListAsync());
        }

        // GET: Contribuintes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.Contribuintes == null)
            {
                return NotFound();
            }

            var contribuinte = await _context.Contribuintes
                .Include(c => c.ConBairro)
                .Include(c => c.ConCidade)
                .FirstOrDefaultAsync(m => m.ConId == id);
            if (contribuinte == null)
            {
                return NotFound();
            }

            return View(contribuinte);
        }

        // GET: Contribuintes/Create
        public IActionResult Create()
        {
            ViewData["ConBairroId"] = new SelectList(_context.Bairros, "BairroId", "BairroId");
            ViewData["ConCidadeId"] = new SelectList(_context.Cidades, "CidadeId", "CidadeId");
            return View();
        }

        // POST: Contribuintes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ConId,ConTipoPessoa,ConNome,ConCnpjcpf,ConNomeFantasia,ConInscrEstadual,ConCargo,ConFuncao,ConCmc,ConDtNasc,ConSexo,ConRg,ConRgdtEmissao,ConRgorgaoExp,ConRgufexp,ConNumTitulo,ConNumHabilitacao,ConCatHabilitacao,ConIdtipoDocumento,ConNrDocumento,ConUfdocumento,ConNacionalidade,ConNacCorrigida,ConEstadoCivil,ConProfissao,ConTelefones,ConTelefoneResidencial,ConTelefoneComercial,ConTelefoneCelular,ConEmail,ConCep,ConTipoLograd,ConEndereco,ConNumero,ConComplemento,ConBairroId,ConCidadeId,ConCidNascId,ConRespRg,ConRespNome,ConFoto,ConIdconjuge,ConSite,ConIdanterior,ConRendaMensal,ConFalecido,ConGrafica,ConDtBaseTce,ConIdcbo,ConNomeMae,ConTecUltAlt,ConDtUltAlt,ConSenha,ConDtValidadeSenha,ConDtCriaSenha,ConFonetizado,ConIdnacionalidade,TmpConFoneAuxiliar,TmpTipoPessoa")] Contribuinte contribuinte)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contribuinte);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ConBairroId"] = new SelectList(_context.Bairros, "BairroId", "BairroId", contribuinte.ConBairroId);
            ViewData["ConCidadeId"] = new SelectList(_context.Cidades, "CidadeId", "CidadeId", contribuinte.ConCidadeId);
            return View(contribuinte);
        }

        // GET: Contribuintes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.Contribuintes == null)
            {
                return NotFound();
            }

            var contribuinte = await _context.Contribuintes.FindAsync(id);
            if (contribuinte == null)
            {
                return NotFound();
            }
            ViewData["ConBairroId"] = new SelectList(_context.Bairros, "BairroId", "BairroId", contribuinte.ConBairroId);
            ViewData["ConCidadeId"] = new SelectList(_context.Cidades, "CidadeId", "CidadeId", contribuinte.ConCidadeId);
            return View(contribuinte);
        }

        // POST: Contribuintes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ConId,ConTipoPessoa,ConNome,ConCnpjcpf,ConNomeFantasia,ConInscrEstadual,ConCargo,ConFuncao,ConCmc,ConDtNasc,ConSexo,ConRg,ConRgdtEmissao,ConRgorgaoExp,ConRgufexp,ConNumTitulo,ConNumHabilitacao,ConCatHabilitacao,ConIdtipoDocumento,ConNrDocumento,ConUfdocumento,ConNacionalidade,ConNacCorrigida,ConEstadoCivil,ConProfissao,ConTelefones,ConTelefoneResidencial,ConTelefoneComercial,ConTelefoneCelular,ConEmail,ConCep,ConTipoLograd,ConEndereco,ConNumero,ConComplemento,ConBairroId,ConCidadeId,ConCidNascId,ConRespRg,ConRespNome,ConFoto,ConIdconjuge,ConSite,ConIdanterior,ConRendaMensal,ConFalecido,ConGrafica,ConDtBaseTce,ConIdcbo,ConNomeMae,ConTecUltAlt,ConDtUltAlt,ConSenha,ConDtValidadeSenha,ConDtCriaSenha,ConFonetizado,ConIdnacionalidade,TmpConFoneAuxiliar,TmpTipoPessoa")] Contribuinte contribuinte)
        {
            if (id != contribuinte.ConId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contribuinte);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContribuinteExists(contribuinte.ConId))
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
            ViewData["ConBairroId"] = new SelectList(_context.Bairros, "BairroId", "BairroId", contribuinte.ConBairroId);
            ViewData["ConCidadeId"] = new SelectList(_context.Cidades, "CidadeId", "CidadeId", contribuinte.ConCidadeId);
            return View(contribuinte);
        }

        // GET: Contribuintes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.Contribuintes == null)
            {
                return NotFound();
            }

            var contribuinte = await _context.Contribuintes
                .Include(c => c.ConBairro)
                .Include(c => c.ConCidade)
                .FirstOrDefaultAsync(m => m.ConId == id);
            if (contribuinte == null)
            {
                return NotFound();
            }

            return View(contribuinte);
        }

        // POST: Contribuintes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.Contribuintes == null)
            {
                return Problem("Entity set 'DbproSigaContext.Contribuintes'  is null.");
            }
            var contribuinte = await _context.Contribuintes.FindAsync(id);
            if (contribuinte != null)
            {
                _context.Contribuintes.Remove(contribuinte);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContribuinteExists(long id)
        {
          return (_context.Contribuintes?.Any(e => e.ConId == id)).GetValueOrDefault();
        }
    }
}
