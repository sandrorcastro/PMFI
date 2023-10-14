using Application.Interfaces;
using Application.Services;
using Application.ViewModels;
using Application.ViewModels.MegaData;
using Domain.Entities.MegaData;
using Domain.Entities.NFSEDB;
using Domain.Filters;
using Domain.Interfaces.Entities;
using Domain.Interfaces.Specifications;
using Domain.Specs;
using MegaData.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Data;
using System.Text;

namespace MegaData.Controllers
{
    public class MegaDataController : Controller
    {
        private NFSEDBContext _NFSEDBContext;
        private readonly IMegaDataAppService megaDataAppService;
        private readonly IWebHostEnvironment environment;

        public MegaDataController(IMegaDataAppService megaDataAppService, NFSEDBContext nFSEDBContext, IWebHostEnvironment environment)
        {
            this.megaDataAppService = megaDataAppService;
            _NFSEDBContext = nFSEDBContext;
            this.environment = environment;
        }

        // GET: MegaDataController
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            
            ISpecification<MegaData_NFSE> spec = null;
            MegaData_NFSEFilter Filter = new MegaData_NFSEFilter();// { DataGeracao=DateTime.Parse(searchString)};
            
            ViewData["CurrentSort"] = sortOrder;
            ViewData["DataGeracaoSortParm"] = String.IsNullOrEmpty(sortOrder) ? "DaataGeracao" : "";
            ViewData["DataGeracaoSortParm"] = sortOrder == "dtGeracao" ? "dtGeracao_desc" : "dtGeracao";
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
                Filter.DataGeracao = DateTime.Now.AddMonths(-1);

                spec = new MegaData_NFSESpec(Filter);
                
                //spec = new MegaData_NFSESpec();

            }

            ViewData["CurrentFilter"] = searchString;
            if (!String.IsNullOrEmpty(searchString))
            {
                long number1 = 0;
                if (long.TryParse(searchString, out number1))
                {
                    //Filter.DataGeracao = int.Parse(searchString);
                    Filter.DataGeracao = DateTime.Parse(searchString);
                    spec = new MegaData_NFSEByDataGeracaoSpec(Filter);
                }
                else
                {
                    Filter.DataGeracao = DateTime.Parse(searchString);
                    spec = new MegaData_NFSESpec(Filter);
                }
            }
          

            //  cidadeFilter.Nome = searchString;
            //spec=new CidadeSpec(cidadeFilter);

            //ViewData["CidadeFilter"] = cidadeFilter;
            var result = await megaDataAppService.ProjectToListAsync<MegaData_NFSE_ViewModel>(spec, Filter, new CancellationToken());
            var resultPVM = new PagedResponseViewModel<MegaData_NFSE_ViewModel>(result, Filter);
            return View(resultPVM);
        }

        // GET: MegaDataController/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            /*
            if (id == null || megaData_Nfse_AppService == null)
            {
                return NotFound();
            }*/

            if (id == null || megaDataAppService== null)
            {
                return NotFound();
            }

            var megaData_NFSE = await megaDataAppService.FindAsync(id);
            //var megaData_NFSE = await megaData_Nfse_AppService.FirstOrDefaultAsync()
            if (megaData_NFSE == null)
            {
                return NotFound();
            }

            return View(megaData_NFSE);
        }
        public IActionResult Download(string arquivo)
        {
            //var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "MegaData", arquivo);
            //var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "MegaData", arquivo);
            var filePath = Path.Combine(environment.WebRootPath, "MegaData", arquivo);

            if (System.IO.File.Exists(filePath))
            {
                var fileName = Path.GetFileName(filePath);
                var cd = new System.Net.Mime.ContentDisposition
                {
                    FileName = fileName,
                    Inline = false,
                };

                Response.Headers.Add("Content-Disposition", cd.ToString());

                return File(new FileStream(filePath, FileMode.Open), "application/octet-stream");

                //return File(new FileStream(filePath, FileMode.Open), "application/octet-stream", arquivo);
            }

            return NotFound();
        }

        // GET: MegaDataController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MegaDataController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DataInicioPeriodo,DataFinalPeriodo,TipoArquivo")] MegaData_NFSE megaData_NFSE)
        {
            if (ModelState.IsValid)
            {
                string mensagem = megaDataAppService.ValidarPeriodo(megaData_NFSE);
                

                if (mensagem == "Valido")
                {
                    megaData_NFSE.DataGeracao = DateTime.Now;
                    string dtLimpa = new string(megaData_NFSE.DataGeracao.ToString().Where(char.IsDigit).ToArray());
                    megaData_NFSE.IDMegaData_NFSE = long.Parse(dtLimpa);              //Guid.NewGuid();
                    if (megaDataAppService.ExportarPeriodo(environment, _NFSEDBContext, megaData_NFSE)) { 
                        await megaDataAppService.AddAsync(megaData_NFSE);
                        this.MostrarMensagem("Período Do Tipo: "  + megaData_NFSE.TipoArquivo.ToString()+  " Entre: " + megaData_NFSE.DataInicioPeriodo + " a "+ megaData_NFSE.DataFinalPeriodo +" Adicionado!");
                    };
                }
                else
                {
                    this.MostrarMensagem("Período Do Tipo: " + megaData_NFSE.TipoArquivo.ToString() + " Entre: " + megaData_NFSE.DataInicioPeriodo + " a " + megaData_NFSE.DataFinalPeriodo + " Inválido",true);
                }
                // this.MostrarMensagem("O Imóvel de inscrição: " + megaData_NFSE.IDMegaData_NFSE + " Não Existe!");
                return RedirectToAction(nameof(Index));
            }
            return View(megaData_NFSE);
        }

        // GET: MegaDataController/Edit/5
        public async Task<IActionResult> Edit(long id)
        {
            if (id == null || megaDataAppService == null)
            {
                return NotFound();
            }
            //  DateTime dt = DateTime.ParseExact(id.ToString(), "yyyy-MM-dd HH:mm:ss", null); // CultureInfo.InvariantCulture, DateTimeStyles.None, out var dataGeracao);
            //DateTime dt = DateTime.TryParseExact(id, "yyyy-MM-dd HH:mm:ss.fff",null);

            var megaData_NFSE = await megaDataAppService.FindAsync(id);
            if (megaData_NFSE == null)
            {
                return NotFound();
            }
            return View(megaData_NFSE);
        }

        // POST: MegaDataController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("DataGeracao,DataInicioPeriodo,DataFinalPeriodo,DataEnvio")] MegaData_NFSE megaData_NFSE)
        {
            /* if (id != megaData_NFSE.IDMegaData_NFSE)
             {
                 return NotFound();
             }*/

            if (ModelState.IsValid)
            {
                try
                {
                    await megaDataAppService.UpdateAsync(megaData_NFSE);
                    //await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    /*if (!MegaData_NFSEExists(megaData_NFSE))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }*/
                }
                return RedirectToAction(nameof(Index));
            }
            return View(megaData_NFSE);
        }

        // GET: MegaDataController/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || megaDataAppService == null)
            {
                return NotFound();
            }

            var megaData_NFSE = await megaDataAppService.FindAsync(id);
            if (megaData_NFSE == null)
            {
                return NotFound();
            }

            return View(megaData_NFSE);
        }

        // POST: MegaDataController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (megaDataAppService == null)
            {
                return Problem("Entity set 'MegaDataDBContext.MegaData_NFSEs'  is null.");
            }
            var megaData_NFSE = await megaDataAppService.FindAsync(id);
            if (megaData_NFSE != null)
            {
                megaDataAppService.DeleteAsync(megaData_NFSE);
            }
            
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        /*private bool MegaData_NFSEExists(MegaData_NFSE m)
        {
            //return (megaDataAppService.AnyAsync(e => e.IDMegaData_NFSE == id)).GetValueOrDefault();
            return (megaDataAppService.AnyAsync(m);   //(m.IDMegaData_NFSE);
        }*/
    }
}
