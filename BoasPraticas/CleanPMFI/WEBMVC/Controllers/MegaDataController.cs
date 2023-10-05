using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities.NFSEDB;

namespace WEBMVC.Controllers
{
    public class MegaDataController : Controller
    {
        private readonly NFSEDBContext _context;

        public MegaDataController(NFSEDBContext context)
        {
            _context = context;
        }

        // GET: MegaData
        public async Task<IActionResult> Index()
        {
              return _context.NfseTblNfses != null ? 
                          View(await _context.NfseTblNfses.ToListAsync()) :
                          Problem("Entity set 'NFSEDBContext.NfseTblNfses'  is null.");
        }

        // GET: MegaData/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.NfseTblNfses == null)
            {
                return NotFound();
            }

            var nfseTblNfse = await _context.NfseTblNfses
                .FirstOrDefaultAsync(m => m.Idnfse == id);
            if (nfseTblNfse == null)
            {
                return NotFound();
            }

            return View(nfseTblNfse);
        }

        // GET: MegaData/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MegaData/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idnfse,Idempresa,Nunumero,Stcodigo,Dtdata,Idoperacao,Idregime,Stoptantesimplesnacional,StincentivadorCultural,Dtcompetencia,Idnfsesubst,Stoutrasinf,IdcnaeSubclasse,IdpreIdcidade,Stcodigotributacaomunicipio,StservicoDescricao,Idservico,Pcaliquota,Vlbasecalculo,Vldesccondicionado,Vldescincondicionado,Stissretido,Vloutrasretencoes,Vlcofins,Vliof,Vlcsll,Vldeducoes,Vlinss,Vlir,Vltotaliss,Vlissretido,Vltotalliquido,Vlpis,Vlservicos,Vlcredito,SttomCpfcnpj,SttomPessoaTipo,SttomIm,SttomNome,SttomEndLogr,SttomEndNumero,SttomEndComplemento,SttomEndBairro,IdtomIdcidade,SttomCep,SttomEmail,SttomTelefone,StintNome,StintIm,StintCpfcnpj,NucodigomunicipioOrgaogerador,Stcei,Stnumeroart,Stsituacao,Stenviaporemail,Idusuarioinclusao,Strecolheiss,StpreCpfcnpj,StpreIm,StpreRazaosocial,StpreNomefantasia,StpreEndlogradouro,StpreEndnumero,StpreEndcomplemento,StpreEndbairro,IdpresIdcidade,StpreEmail,StpreCep,StpreTelefone,Stserie,Stunideco,Stobservacao,Idempincfisc")] NfseTblNfse nfseTblNfse)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nfseTblNfse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nfseTblNfse);
        }

        // GET: MegaData/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.NfseTblNfses == null)
            {
                return NotFound();
            }

            var nfseTblNfse = await _context.NfseTblNfses.FindAsync(id);
            if (nfseTblNfse == null)
            {
                return NotFound();
            }
            return View(nfseTblNfse);
        }

        // POST: MegaData/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Idnfse,Idempresa,Nunumero,Stcodigo,Dtdata,Idoperacao,Idregime,Stoptantesimplesnacional,StincentivadorCultural,Dtcompetencia,Idnfsesubst,Stoutrasinf,IdcnaeSubclasse,IdpreIdcidade,Stcodigotributacaomunicipio,StservicoDescricao,Idservico,Pcaliquota,Vlbasecalculo,Vldesccondicionado,Vldescincondicionado,Stissretido,Vloutrasretencoes,Vlcofins,Vliof,Vlcsll,Vldeducoes,Vlinss,Vlir,Vltotaliss,Vlissretido,Vltotalliquido,Vlpis,Vlservicos,Vlcredito,SttomCpfcnpj,SttomPessoaTipo,SttomIm,SttomNome,SttomEndLogr,SttomEndNumero,SttomEndComplemento,SttomEndBairro,IdtomIdcidade,SttomCep,SttomEmail,SttomTelefone,StintNome,StintIm,StintCpfcnpj,NucodigomunicipioOrgaogerador,Stcei,Stnumeroart,Stsituacao,Stenviaporemail,Idusuarioinclusao,Strecolheiss,StpreCpfcnpj,StpreIm,StpreRazaosocial,StpreNomefantasia,StpreEndlogradouro,StpreEndnumero,StpreEndcomplemento,StpreEndbairro,IdpresIdcidade,StpreEmail,StpreCep,StpreTelefone,Stserie,Stunideco,Stobservacao,Idempincfisc")] NfseTblNfse nfseTblNfse)
        {
            if (id != nfseTblNfse.Idnfse)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nfseTblNfse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NfseTblNfseExists(nfseTblNfse.Idnfse))
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
            return View(nfseTblNfse);
        }

        // GET: MegaData/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.NfseTblNfses == null)
            {
                return NotFound();
            }

            var nfseTblNfse = await _context.NfseTblNfses
                .FirstOrDefaultAsync(m => m.Idnfse == id);
            if (nfseTblNfse == null)
            {
                return NotFound();
            }

            return View(nfseTblNfse);
        }

        // POST: MegaData/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.NfseTblNfses == null)
            {
                return Problem("Entity set 'NFSEDBContext.NfseTblNfses'  is null.");
            }
            var nfseTblNfse = await _context.NfseTblNfses.FindAsync(id);
            if (nfseTblNfse != null)
            {
                _context.NfseTblNfses.Remove(nfseTblNfse);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NfseTblNfseExists(long id)
        {
          return (_context.NfseTblNfses?.Any(e => e.Idnfse == id)).GetValueOrDefault();
        }
    }
}
