using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Context;

namespace WEBMVC.Controllers
{
    public class AlvarasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AlvarasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Alvaras
        public async Task<IActionResult> Index()
        {
            return _context.TribAlvDocumentos != null ?
                        View(await _context.TribAlvDocumentos.Skip(10).Take(100).ToListAsync()): 
                          Problem("Entity set 'ApplicationDbContext.TribAlvDocumentos'  is null.");
        }

        // GET: Alvaras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TribAlvDocumentos == null)
            {
                return NotFound();
            }

            var tribAlvDocumento = await _context.TribAlvDocumentos
                .FirstOrDefaultAsync(m => m.IdDocumento == id);
            if (tribAlvDocumento == null)
            {
                return NotFound();
            }

            return View(tribAlvDocumento);
        }

        // GET: Alvaras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Alvaras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDocumento,NrAno,NrSequencia,NrCmcExecucao,NrCmcProjeto,DsObraEndereco,DsObra,NrArt,NrCreaExecucao,NrCreaProjeto,NmProprietario,NrPropCpfcnpj,DsPropFone,DsPropEndereco,DsArea,NrInscricao,DtDocumento,NrNossoNumero,FlComValor,NrProtocolo,NrLote,NrQuadra,DsObservacao,DsAvaliacaoIssqn,ImDocumento,DsTipoDocumento,DsTitulo,DsTexto,IdDocumentoOrigem,NrAreaTerreno,NrSequenciaOrigem,NrAnoOrigem,Dispensado,CepObra,CepProprietario,VlTotalAreaConstrucao,FlOutorga,VlVenalTerreno,VlAreaInfracionadaTerreno,VlTaxaOutorga,DsInscricaoEstatual,Situacao,DsMotivoCancelamento,RefAnterior,DsDescAreaConstrucao,DtExclusaoAlvara,DsUsuarioExclusao,IdCpfcnpjExecucao,IdCpfcnpjProjeto,NrProcessoAno,NrProcessoSequencia,DsUsuarioInclusao,FlTipoAlvara,TpRespObraProjeto,TpRespObraExecucao")] TribAlvDocumento tribAlvDocumento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tribAlvDocumento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tribAlvDocumento);
        }

        // GET: Alvaras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TribAlvDocumentos == null)
            {
                return NotFound();
            }

            var tribAlvDocumento = await _context.TribAlvDocumentos.FindAsync(id);
            if (tribAlvDocumento == null)
            {
                return NotFound();
            }
            return View(tribAlvDocumento);
        }

        // POST: Alvaras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDocumento,NrAno,NrSequencia,NrCmcExecucao,NrCmcProjeto,DsObraEndereco,DsObra,NrArt,NrCreaExecucao,NrCreaProjeto,NmProprietario,NrPropCpfcnpj,DsPropFone,DsPropEndereco,DsArea,NrInscricao,DtDocumento,NrNossoNumero,FlComValor,NrProtocolo,NrLote,NrQuadra,DsObservacao,DsAvaliacaoIssqn,ImDocumento,DsTipoDocumento,DsTitulo,DsTexto,IdDocumentoOrigem,NrAreaTerreno,NrSequenciaOrigem,NrAnoOrigem,Dispensado,CepObra,CepProprietario,VlTotalAreaConstrucao,FlOutorga,VlVenalTerreno,VlAreaInfracionadaTerreno,VlTaxaOutorga,DsInscricaoEstatual,Situacao,DsMotivoCancelamento,RefAnterior,DsDescAreaConstrucao,DtExclusaoAlvara,DsUsuarioExclusao,IdCpfcnpjExecucao,IdCpfcnpjProjeto,NrProcessoAno,NrProcessoSequencia,DsUsuarioInclusao,FlTipoAlvara,TpRespObraProjeto,TpRespObraExecucao")] TribAlvDocumento tribAlvDocumento)
        {
            if (id != tribAlvDocumento.IdDocumento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tribAlvDocumento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TribAlvDocumentoExists(tribAlvDocumento.IdDocumento))
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
            return View(tribAlvDocumento);
        }

        // GET: Alvaras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TribAlvDocumentos == null)
            {
                return NotFound();
            }

            var tribAlvDocumento = await _context.TribAlvDocumentos
                .FirstOrDefaultAsync(m => m.IdDocumento == id);
            if (tribAlvDocumento == null)
            {
                return NotFound();
            }

            return View(tribAlvDocumento);
        }

        // POST: Alvaras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TribAlvDocumentos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TribAlvDocumentos'  is null.");
            }
            var tribAlvDocumento = await _context.TribAlvDocumentos.FindAsync(id);
            if (tribAlvDocumento != null)
            {
                _context.TribAlvDocumentos.Remove(tribAlvDocumento);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TribAlvDocumentoExists(int id)
        {
          return (_context.TribAlvDocumentos?.Any(e => e.IdDocumento == id)).GetValueOrDefault();
        }
    }
}
