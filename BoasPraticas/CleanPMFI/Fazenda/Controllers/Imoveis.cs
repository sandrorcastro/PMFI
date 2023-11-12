using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fazenda.Entities.DBProsiga;

namespace Fazenda.Controllers
{
    public class Imoveis : Controller
    {
        private readonly DbprosigaContext _context;

        public Imoveis(DbprosigaContext context)
        {
            _context = context;
        }

        // GET: Imoveis
        public async Task<IActionResult> Index()
        {
            var dbprosigaContext = _context.TribEdificacoes.Include(t => t.AcabExt).Include(t => t.AcabInt).Include(t => t.Agrupa).Include(t => t.Cobert).Include(t => t.Deno).Include(t => t.Eletrica).Include(t => t.Esquadrias).Include(t => t.EstConserv).Include(t => t.Estrut).Include(t => t.Forro).Include(t => t.IdloteamentoNavigation).Include(t => t.IdplantaNavigation).Include(t => t.Inci).Include(t => t.Lograd).Include(t => t.Ocupa).Include(t => t.Parede).Include(t => t.Piso).Include(t => t.Posicao).Include(t => t.Situacao).Include(t => t.Terreno).Include(t => t.TipoCon).Include(t => t.Uso).Include(t => t.Utiliz);
            return View(await dbprosigaContext.Where(s=>s.EdifSituacao=="Normal").Take(10).ToListAsync());
        }

        // GET: Imoveis/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.TribEdificacoes == null)
            {
                return NotFound();
            }

            var tribEdificaco = await _context.TribEdificacoes
                .Include(t => t.AcabExt)
                .Include(t => t.AcabInt)
                .Include(t => t.Agrupa)
                .Include(t => t.Cobert)
                .Include(t => t.Deno)
                .Include(t => t.Eletrica)
                .Include(t => t.Esquadrias)
                .Include(t => t.EstConserv)
                .Include(t => t.Estrut)
                .Include(t => t.Forro)
                .Include(t => t.IdloteamentoNavigation)
                .Include(t => t.IdplantaNavigation)
                .Include(t => t.Inci)
                .Include(t => t.Lograd)
                .Include(t => t.Ocupa)
                .Include(t => t.Parede)
                .Include(t => t.Piso)
                .Include(t => t.Posicao)
                .Include(t => t.Situacao)
                .Include(t => t.Terreno)
                .Include(t => t.TipoCon)
                .Include(t => t.Uso)
                .Include(t => t.Utiliz)
                .FirstOrDefaultAsync(m => m.EdificacaoId == id);
            if (tribEdificaco == null)
            {
                return NotFound();
            }

            return View(tribEdificaco);
        }

        // GET: Imoveis/Create
        public IActionResult Create()
        {
            ViewData["AcabExtId"] = new SelectList(_context.TribAcabamentoExternos, "AcabExtId", "AcabExtId");
            ViewData["AcabIntId"] = new SelectList(_context.TribAcabamentoInternos, "AcabIntId", "AcabIntId");
            ViewData["AgrupaId"] = new SelectList(_context.TribAgrupamentos, "AgrupaId", "AgrupaId");
            ViewData["CobertId"] = new SelectList(_context.TribCoberturas, "CobertId", "CobertId");
            ViewData["DenoId"] = new SelectList(_context.TribDenominacaos, "DenoId", "DenoId");
            ViewData["EletricaId"] = new SelectList(_context.TribInstalacaoEletricas, "EletricaId", "EletricaId");
            ViewData["EsquadriasId"] = new SelectList(_context.TribEsquadrias, "EsquadriasId", "EsquadriasId");
            ViewData["EstConservId"] = new SelectList(_context.TribEstadoConservacaos, "EstConservId", "EstConservId");
            ViewData["EstrutId"] = new SelectList(_context.TribEstruturaParedes, "EstrutId", "EstrutId");
            ViewData["ForroId"] = new SelectList(_context.TribForros, "ForroId", "ForroId");
            ViewData["Idloteamento"] = new SelectList(_context.Loteamentos, "Idloteamento", "Idloteamento");
            ViewData["Idplanta"] = new SelectList(_context.TribTipoPlantasValores, "Idplanta", "Idplanta");
            ViewData["InciId"] = new SelectList(_context.TribIncidencia, "InciId", "InciId");
            ViewData["LogradId"] = new SelectList(_context.Logradouros, "LogradId", "LogradId");
            ViewData["OcupaId"] = new SelectList(_context.TribOcupacaos, "OcupaId", "OcupaId");
            ViewData["ParedeId"] = new SelectList(_context.TribParedes, "ParedeId", "ParedeId");
            ViewData["PisoId"] = new SelectList(_context.TribPisos, "PisoId", "PisoId");
            ViewData["PosicaoId"] = new SelectList(_context.TribPosicaoEdificacaos, "PosicaoId", "PosicaoId");
            ViewData["SituacaoId"] = new SelectList(_context.TribSituacaoEdificacaos, "SituacaoId", "SituacaoId");
            ViewData["TerrenoId"] = new SelectList(_context.TribTerrenos, "TerrenoId", "TerrenoId");
            ViewData["TipoConId"] = new SelectList(_context.TribTiposConstrucaos, "TipoConId", "TipoConId");
            ViewData["UsoId"] = new SelectList(_context.TribUsos, "UsoId", "UsoId");
            ViewData["UtilizId"] = new SelectList(_context.TribUtilizacaos, "UtilizId", "UtilizId");
            return View();
        }

        // POST: Imoveis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EdificacaoId,TerrenoId,EdifMatricula,EdifNumOficio,EdifAlvara,EdifCaracteristica,EdifNumeracao,DenoId,EdifEdificacaoEnglobamento,EdifDtUltTransfPropriedade,EdifDtInicioConstrucao,EdifDtParalizacaoConstrucao,AgrupaId,AcabIntId,SituacaoId,PosicaoId,UsoId,UtilizId,PisoId,EletricaId,ForroId,CobertId,AcabExtId,CategId,EstrutId,TipoConId,OcupaId,EdifNumElevadores,EdifAnoConstrucao,EdifNumPavimento,EdifAndarConstrucao,EdifAreaConstruida,EdifAreaCoberta,EdifContinuacaoTerreno,EdifEconomia,InscricaoImobiliaria,InscricaoImobiliariaGeo,EdifFracaoIdealEdificacao,EdifPontosEdificacao,EdifComplemento,EdifNumAptoSalaLoja,EdifBloco,ParedeId,EsquadriasId,EstConservId,ValorVenalCalculo,NumeroCadastroCanadas,UnidadeLote,EdifJuntarAoCarne,ValorVenalEdificacao,EdifSituacao,InciId,UsuarioInclusao,DataInclusao,LogradId,Idloteamento,EdifCep,ProcId,EdifMotivoAlteracao,EdifDtMatricula,EdifCentroGrauLon,EdifCentroGrauLat,Idplanta,ValorVenalTerrenoParaEdificacao,EdifObs,EdifDataAtualizacaoEndereco,EdifUsuarioAtualizacaoEndereco,Flconferido,Dsobservacao,TmpIdlogradouro,TmpIdzoneamento,Idusuariorevisao")] TribEdificaco tribEdificaco)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tribEdificaco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AcabExtId"] = new SelectList(_context.TribAcabamentoExternos, "AcabExtId", "AcabExtId", tribEdificaco.AcabExtId);
            ViewData["AcabIntId"] = new SelectList(_context.TribAcabamentoInternos, "AcabIntId", "AcabIntId", tribEdificaco.AcabIntId);
            ViewData["AgrupaId"] = new SelectList(_context.TribAgrupamentos, "AgrupaId", "AgrupaId", tribEdificaco.AgrupaId);
            ViewData["CobertId"] = new SelectList(_context.TribCoberturas, "CobertId", "CobertId", tribEdificaco.CobertId);
            ViewData["DenoId"] = new SelectList(_context.TribDenominacaos, "DenoId", "DenoId", tribEdificaco.DenoId);
            ViewData["EletricaId"] = new SelectList(_context.TribInstalacaoEletricas, "EletricaId", "EletricaId", tribEdificaco.EletricaId);
            ViewData["EsquadriasId"] = new SelectList(_context.TribEsquadrias, "EsquadriasId", "EsquadriasId", tribEdificaco.EsquadriasId);
            ViewData["EstConservId"] = new SelectList(_context.TribEstadoConservacaos, "EstConservId", "EstConservId", tribEdificaco.EstConservId);
            ViewData["EstrutId"] = new SelectList(_context.TribEstruturaParedes, "EstrutId", "EstrutId", tribEdificaco.EstrutId);
            ViewData["ForroId"] = new SelectList(_context.TribForros, "ForroId", "ForroId", tribEdificaco.ForroId);
            ViewData["Idloteamento"] = new SelectList(_context.Loteamentos, "Idloteamento", "Idloteamento", tribEdificaco.Idloteamento);
            ViewData["Idplanta"] = new SelectList(_context.TribTipoPlantasValores, "Idplanta", "Idplanta", tribEdificaco.Idplanta);
            ViewData["InciId"] = new SelectList(_context.TribIncidencia, "InciId", "InciId", tribEdificaco.InciId);
            ViewData["LogradId"] = new SelectList(_context.Logradouros, "LogradId", "LogradId", tribEdificaco.LogradId);
            ViewData["OcupaId"] = new SelectList(_context.TribOcupacaos, "OcupaId", "OcupaId", tribEdificaco.OcupaId);
            ViewData["ParedeId"] = new SelectList(_context.TribParedes, "ParedeId", "ParedeId", tribEdificaco.ParedeId);
            ViewData["PisoId"] = new SelectList(_context.TribPisos, "PisoId", "PisoId", tribEdificaco.PisoId);
            ViewData["PosicaoId"] = new SelectList(_context.TribPosicaoEdificacaos, "PosicaoId", "PosicaoId", tribEdificaco.PosicaoId);
            ViewData["SituacaoId"] = new SelectList(_context.TribSituacaoEdificacaos, "SituacaoId", "SituacaoId", tribEdificaco.SituacaoId);
            ViewData["TerrenoId"] = new SelectList(_context.TribTerrenos, "TerrenoId", "TerrenoId", tribEdificaco.TerrenoId);
            ViewData["TipoConId"] = new SelectList(_context.TribTiposConstrucaos, "TipoConId", "TipoConId", tribEdificaco.TipoConId);
            ViewData["UsoId"] = new SelectList(_context.TribUsos, "UsoId", "UsoId", tribEdificaco.UsoId);
            ViewData["UtilizId"] = new SelectList(_context.TribUtilizacaos, "UtilizId", "UtilizId", tribEdificaco.UtilizId);
            return View(tribEdificaco);
        }

        // GET: Imoveis/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.TribEdificacoes == null)
            {
                return NotFound();
            }

            var tribEdificaco = await _context.TribEdificacoes.FindAsync(id);
            if (tribEdificaco == null)
            {
                return NotFound();
            }
            ViewData["AcabExtId"] = new SelectList(_context.TribAcabamentoExternos, "AcabExtId", "AcabExtId", tribEdificaco.AcabExtId);
            ViewData["AcabIntId"] = new SelectList(_context.TribAcabamentoInternos, "AcabIntId", "AcabIntId", tribEdificaco.AcabIntId);
            ViewData["AgrupaId"] = new SelectList(_context.TribAgrupamentos, "AgrupaId", "AgrupaId", tribEdificaco.AgrupaId);
            ViewData["CobertId"] = new SelectList(_context.TribCoberturas, "CobertId", "CobertId", tribEdificaco.CobertId);
            ViewData["DenoId"] = new SelectList(_context.TribDenominacaos, "DenoId", "DenoId", tribEdificaco.DenoId);
            ViewData["EletricaId"] = new SelectList(_context.TribInstalacaoEletricas, "EletricaId", "EletricaId", tribEdificaco.EletricaId);
            ViewData["EsquadriasId"] = new SelectList(_context.TribEsquadrias, "EsquadriasId", "EsquadriasId", tribEdificaco.EsquadriasId);
            ViewData["EstConservId"] = new SelectList(_context.TribEstadoConservacaos, "EstConservId", "EstConservId", tribEdificaco.EstConservId);
            ViewData["EstrutId"] = new SelectList(_context.TribEstruturaParedes, "EstrutId", "EstrutId", tribEdificaco.EstrutId);
            ViewData["ForroId"] = new SelectList(_context.TribForros, "ForroId", "ForroId", tribEdificaco.ForroId);
            ViewData["Idloteamento"] = new SelectList(_context.Loteamentos, "Idloteamento", "Idloteamento", tribEdificaco.Idloteamento);
            ViewData["Idplanta"] = new SelectList(_context.TribTipoPlantasValores, "Idplanta", "Idplanta", tribEdificaco.Idplanta);
            ViewData["InciId"] = new SelectList(_context.TribIncidencia, "InciId", "InciId", tribEdificaco.InciId);
            ViewData["LogradId"] = new SelectList(_context.Logradouros, "LogradId", "LogradId", tribEdificaco.LogradId);
            ViewData["OcupaId"] = new SelectList(_context.TribOcupacaos, "OcupaId", "OcupaId", tribEdificaco.OcupaId);
            ViewData["ParedeId"] = new SelectList(_context.TribParedes, "ParedeId", "ParedeId", tribEdificaco.ParedeId);
            ViewData["PisoId"] = new SelectList(_context.TribPisos, "PisoId", "PisoId", tribEdificaco.PisoId);
            ViewData["PosicaoId"] = new SelectList(_context.TribPosicaoEdificacaos, "PosicaoId", "PosicaoId", tribEdificaco.PosicaoId);
            ViewData["SituacaoId"] = new SelectList(_context.TribSituacaoEdificacaos, "SituacaoId", "SituacaoId", tribEdificaco.SituacaoId);
            ViewData["TerrenoId"] = new SelectList(_context.TribTerrenos, "TerrenoId", "TerrenoId", tribEdificaco.TerrenoId);
            ViewData["TipoConId"] = new SelectList(_context.TribTiposConstrucaos, "TipoConId", "TipoConId", tribEdificaco.TipoConId);
            ViewData["UsoId"] = new SelectList(_context.TribUsos, "UsoId", "UsoId", tribEdificaco.UsoId);
            ViewData["UtilizId"] = new SelectList(_context.TribUtilizacaos, "UtilizId", "UtilizId", tribEdificaco.UtilizId);
            return View(tribEdificaco);
        }

        // POST: Imoveis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("EdificacaoId,TerrenoId,EdifMatricula,EdifNumOficio,EdifAlvara,EdifCaracteristica,EdifNumeracao,DenoId,EdifEdificacaoEnglobamento,EdifDtUltTransfPropriedade,EdifDtInicioConstrucao,EdifDtParalizacaoConstrucao,AgrupaId,AcabIntId,SituacaoId,PosicaoId,UsoId,UtilizId,PisoId,EletricaId,ForroId,CobertId,AcabExtId,CategId,EstrutId,TipoConId,OcupaId,EdifNumElevadores,EdifAnoConstrucao,EdifNumPavimento,EdifAndarConstrucao,EdifAreaConstruida,EdifAreaCoberta,EdifContinuacaoTerreno,EdifEconomia,InscricaoImobiliaria,InscricaoImobiliariaGeo,EdifFracaoIdealEdificacao,EdifPontosEdificacao,EdifComplemento,EdifNumAptoSalaLoja,EdifBloco,ParedeId,EsquadriasId,EstConservId,ValorVenalCalculo,NumeroCadastroCanadas,UnidadeLote,EdifJuntarAoCarne,ValorVenalEdificacao,EdifSituacao,InciId,UsuarioInclusao,DataInclusao,LogradId,Idloteamento,EdifCep,ProcId,EdifMotivoAlteracao,EdifDtMatricula,EdifCentroGrauLon,EdifCentroGrauLat,Idplanta,ValorVenalTerrenoParaEdificacao,EdifObs,EdifDataAtualizacaoEndereco,EdifUsuarioAtualizacaoEndereco,Flconferido,Dsobservacao,TmpIdlogradouro,TmpIdzoneamento,Idusuariorevisao")] TribEdificaco tribEdificaco)
        {
            if (id != tribEdificaco.EdificacaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tribEdificaco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TribEdificacoExists(tribEdificaco.EdificacaoId))
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
            ViewData["AcabExtId"] = new SelectList(_context.TribAcabamentoExternos, "AcabExtId", "AcabExtId", tribEdificaco.AcabExtId);
            ViewData["AcabIntId"] = new SelectList(_context.TribAcabamentoInternos, "AcabIntId", "AcabIntId", tribEdificaco.AcabIntId);
            ViewData["AgrupaId"] = new SelectList(_context.TribAgrupamentos, "AgrupaId", "AgrupaId", tribEdificaco.AgrupaId);
            ViewData["CobertId"] = new SelectList(_context.TribCoberturas, "CobertId", "CobertId", tribEdificaco.CobertId);
            ViewData["DenoId"] = new SelectList(_context.TribDenominacaos, "DenoId", "DenoId", tribEdificaco.DenoId);
            ViewData["EletricaId"] = new SelectList(_context.TribInstalacaoEletricas, "EletricaId", "EletricaId", tribEdificaco.EletricaId);
            ViewData["EsquadriasId"] = new SelectList(_context.TribEsquadrias, "EsquadriasId", "EsquadriasId", tribEdificaco.EsquadriasId);
            ViewData["EstConservId"] = new SelectList(_context.TribEstadoConservacaos, "EstConservId", "EstConservId", tribEdificaco.EstConservId);
            ViewData["EstrutId"] = new SelectList(_context.TribEstruturaParedes, "EstrutId", "EstrutId", tribEdificaco.EstrutId);
            ViewData["ForroId"] = new SelectList(_context.TribForros, "ForroId", "ForroId", tribEdificaco.ForroId);
            ViewData["Idloteamento"] = new SelectList(_context.Loteamentos, "Idloteamento", "Idloteamento", tribEdificaco.Idloteamento);
            ViewData["Idplanta"] = new SelectList(_context.TribTipoPlantasValores, "Idplanta", "Idplanta", tribEdificaco.Idplanta);
            ViewData["InciId"] = new SelectList(_context.TribIncidencia, "InciId", "InciId", tribEdificaco.InciId);
            ViewData["LogradId"] = new SelectList(_context.Logradouros, "LogradId", "LogradId", tribEdificaco.LogradId);
            ViewData["OcupaId"] = new SelectList(_context.TribOcupacaos, "OcupaId", "OcupaId", tribEdificaco.OcupaId);
            ViewData["ParedeId"] = new SelectList(_context.TribParedes, "ParedeId", "ParedeId", tribEdificaco.ParedeId);
            ViewData["PisoId"] = new SelectList(_context.TribPisos, "PisoId", "PisoId", tribEdificaco.PisoId);
            ViewData["PosicaoId"] = new SelectList(_context.TribPosicaoEdificacaos, "PosicaoId", "PosicaoId", tribEdificaco.PosicaoId);
            ViewData["SituacaoId"] = new SelectList(_context.TribSituacaoEdificacaos, "SituacaoId", "SituacaoId", tribEdificaco.SituacaoId);
            ViewData["TerrenoId"] = new SelectList(_context.TribTerrenos, "TerrenoId", "TerrenoId", tribEdificaco.TerrenoId);
            ViewData["TipoConId"] = new SelectList(_context.TribTiposConstrucaos, "TipoConId", "TipoConId", tribEdificaco.TipoConId);
            ViewData["UsoId"] = new SelectList(_context.TribUsos, "UsoId", "UsoId", tribEdificaco.UsoId);
            ViewData["UtilizId"] = new SelectList(_context.TribUtilizacaos, "UtilizId", "UtilizId", tribEdificaco.UtilizId);
            return View(tribEdificaco);
        }

        // GET: Imoveis/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.TribEdificacoes == null)
            {
                return NotFound();
            }

            var tribEdificaco = await _context.TribEdificacoes
                .Include(t => t.AcabExt)
                .Include(t => t.AcabInt)
                .Include(t => t.Agrupa)
                .Include(t => t.Cobert)
                .Include(t => t.Deno)
                .Include(t => t.Eletrica)
                .Include(t => t.Esquadrias)
                .Include(t => t.EstConserv)
                .Include(t => t.Estrut)
                .Include(t => t.Forro)
                .Include(t => t.IdloteamentoNavigation)
                .Include(t => t.IdplantaNavigation)
                .Include(t => t.Inci)
                .Include(t => t.Lograd)
                .Include(t => t.Ocupa)
                .Include(t => t.Parede)
                .Include(t => t.Piso)
                .Include(t => t.Posicao)
                .Include(t => t.Situacao)
                .Include(t => t.Terreno)
                .Include(t => t.TipoCon)
                .Include(t => t.Uso)
                .Include(t => t.Utiliz)
                .FirstOrDefaultAsync(m => m.EdificacaoId == id);
            if (tribEdificaco == null)
            {
                return NotFound();
            }

            return View(tribEdificaco);
        }

        // POST: Imoveis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.TribEdificacoes == null)
            {
                return Problem("Entity set 'DbprosigaContext.TribEdificacoes'  is null.");
            }
            var tribEdificaco = await _context.TribEdificacoes.FindAsync(id);
            if (tribEdificaco != null)
            {
                _context.TribEdificacoes.Remove(tribEdificaco);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TribEdificacoExists(long id)
        {
          return (_context.TribEdificacoes?.Any(e => e.EdificacaoId == id)).GetValueOrDefault();
        }
    }
}
