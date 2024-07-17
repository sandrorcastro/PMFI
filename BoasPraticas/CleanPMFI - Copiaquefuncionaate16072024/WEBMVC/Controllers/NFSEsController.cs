using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities.NFSEDB;
using Application.Services;
using Application.ViewModels;
using Domain.Filters;
using Domain.Interfaces.Specifications;
using Domain.Specs;
using Application.Interfaces;
using Infrastructure.Context;
using Application.ViewModels.NFSEDB;

namespace WEBMVC.Controllers
{
    public class NFSEsController : Controller
    {
        private readonly NFSEDBContext _context;
        private readonly INFSE_To_MegaData_AppService NFSEAppService;
        
        public NFSEsController(NFSEDBContext context, INFSE_To_MegaData_AppService _NFSEAppService)
        {
            _context = context;
            NFSEAppService = _NFSEAppService;
        }

        // GET: NFSEs
        /*public async Task<IActionResult> Index()
        {
              return _context.NfseTblNfses != null ? 
                          View(await _context.NfseTblNfses.ToListAsync()) :
                          Problem("Entity set 'NFSEDBContext.NfseTblNfses'  is null.");
        }*/
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {

            ISpecification<NfseTblNfse> spec = null;
            NfseTblNfseFilter Filter = new NfseTblNfseFilter();

            ViewData["CurrentSort"] = sortOrder;
            ViewData["NomeSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Nome" : "";
            ViewData["IdCidadeSortParm"] = sortOrder == "IdCidade" ? "idcidade_desc" : "IdCidade";
            if (searchString != null)
            {
                pageNumber = 1;
                Filter.Page = pageNumber;
            }
            else
            {
                searchString = currentFilter;
                Filter.SortBy = sortOrder;
                //cidadeFilter.OrderBy = "desc";
                Filter.Page = pageNumber;
                spec = new NfseTblNfseSpec(Filter);

            }

            ViewData["CurrentFilter"] = searchString;
            if (!String.IsNullOrEmpty(searchString))
            {
                long number1 = 0;
                if (long.TryParse(searchString, out number1))
                {
                    //Filter. = int.Parse(searchString);
                    spec = new NfseTblNfseSpec(Filter);
                }
                else
                {
                    //Filter.Dtcompetencia = searchString;
                    spec = new NfseTblNfseSpec(Filter);
                }
            }
            /*  switch (sortOrder)
              {
                  case "nome_desc":
                      Cidades = Cidades.OrderByDescending(s => s.Nome);

                      break;
                  case "IdCidade":
                      Cidades = Cidades.OrderBy(s => s.IdCidade);
                      break;
                  case "idcidade_desc":
                      Cidades = Cidades.OrderByDescending(s => s.IdCidade);
                      break;
                  default:
                      //Cidades = Cidades.OrderBy(s => s.Nome);
                      spec = new CidadeSpec();
                      break;
              }*/

            //int pageSize = 3;

            // return View(await PaginatedList<Student>.CreateAsync(Cidades.AsNoTracking(), pageNumber ?? 1, pageSize));


            //  cidadeFilter.Nome = searchString;
            //spec=new CidadeSpec(cidadeFilter);

            //ViewData["CidadeFilter"] = cidadeFilter;
            var result = await NFSEAppService.ProjectToListAsync<NFSEViewModel>(spec, Filter, new CancellationToken());
            var resultPVM = new PagedResponseViewModel<NFSEViewModel>(result, Filter);
            //return View(result);
            return View(resultPVM);
        }

        // GET: NFSEs/Details/5
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

        // GET: NFSEs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NFSEs/Create
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

        // GET: NFSEs/Edit/5
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

        // POST: NFSEs/Edit/5
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

        // GET: NFSEs/Delete/5
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

        // POST: NFSEs/Delete/5
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
