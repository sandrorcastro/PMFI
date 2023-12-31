﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Context;
using Domain.Filters;
using Application.Services.Base;
using Application.Interfaces;
using Application.Interfaces.Base;
using Domain.Specs;
using System.Threading;
using Application.ViewModels;
using Domain.Pagination;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using WEBMVC.ViewComponents;
using Microsoft.Data.SqlClient;
using System.Globalization;
using System.Xml.Linq;
using Domain.Interfaces.Specifications;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Text;

namespace WEBMVC.Controllers
{
    public class CidadesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ICidadeAppService cidadeAppService;
        public CidadesController(ApplicationDbContext context, ICidadeAppService cidadeAppService)
        {
            _context = context;
            this.cidadeAppService = cidadeAppService;
        }

        // GET: Cidades
        //public async Task<IActionResult> Index()
        //public async Task<IActionResult> Index(string CidadeFilter_SortBy, string? filter,string sortOrder)
        [HttpGet]

        /* public async Task<IActionResult> Index(CidadeFilter CidadeFilter, string sortOrder, string currentFilter, string searchString, int? pageNumber)
         {
             var spec=new CidadeSpec();
             ViewData["CurrentSort"] = sortOrder;
             ViewData["IdCidadeSortParm"] = String.IsNullOrEmpty(sortOrder) ? "idcidade_desc" : "";
             ViewData["NomeSortParm"] = sortOrder == "Nome" ? "nome_desc" : "Nome";
             if (searchString != null)
             {
                 pageNumber = 1;
             }
             else
             {
                 searchString = currentFilter;
             }

             ViewData["CurrentFilter"] = searchString;

             var cidades = from s in _context.Cidades
                            select s;


             CidadeFilter cidadeFilter = new CidadeFilter()
             {
                 Nome = String.IsNullOrEmpty(CidadeFilter.Nome) ? null : CidadeFilter.Nome,
                 IdCidade = null,
                 SortBy = String.IsNullOrEmpty(CidadeFilter.SortBy) ? "Nome" : null,
                 OrderBy = String.IsNullOrEmpty(CidadeFilter.OrderBy) ? "Desc" : null,
             };


             if (!String.IsNullOrEmpty(searchString))
             {
                 //
                 //
                 //this.spec = CidadePeloNomeSpec(cidadeFilter);
             }
             switch (sortOrder)
             {
                 case "idcidade_desc":
                     cidades = cidades.OrderByDescending(s => s.IdCidade);
                     break;
                 case "Nome":
                     cidades = cidades.OrderBy(s => s.Nome);
                     break;
                 case "nome_desc":
                     cidades = cidades.OrderByDescending(s => s.Nome);
                     break;
                 default:
                     cidades = cidades.OrderBy(s => s.IdCidade);
                     break;
             }

             int pageSize = 3;
             //return View(await PaginatedList<Student>.CreateAsync(Cidades.AsNoTracking(), pageNumber ?? 1, pageSize));














             ViewData["CidadeFilter"] = cidadeFilter;





             //filter.Nome = "Cacoal";
             //filter.IdCidade = 4;
             //////CidadeFilter cidadeFilter = new CidadeFilter() {Nome=filter };
            // var spec = new CidadeSpec(cidadeFilter);

             var result = await cidadeAppService.ProjectToListAsync<CidadeViewModel>(spec, cidadeFilter, new CancellationToken());
             var resultPVM = new PagedResponseViewModel<CidadeViewModel>(result, cidadeFilter);


             ///return ViewComponent("~/Views/Shared/Partials/_Buscar.cshtmlPagedResponse", result);
             //// return ViewComponent("Cidade",result);


             //return View(result);
             return View(resultPVM);
         }*/


         public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
         {
            
            ISpecification<Cidade> spec = null;
            CidadeFilter cidadeFilter = new CidadeFilter();
            
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NomeSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Nome" : "";
            ViewData["IdCidadeSortParm"] = sortOrder == "IdCidade" ? "idcidade_desc" : "IdCidade";
            if (searchString != null)
            {
                pageNumber = 1;
                cidadeFilter.Page = pageNumber;
            }
            else
            {
                searchString = currentFilter;
                cidadeFilter.SortBy = sortOrder;
                //cidadeFilter.OrderBy = "desc";
                cidadeFilter.Page = pageNumber;
                spec = new CidadeSpec(cidadeFilter);

            }
            
            ViewData["CurrentFilter"] = searchString;
            if (!String.IsNullOrEmpty(searchString))
            {
                 long number1 = 0;
                if (long.TryParse(searchString, out number1))
                {
                    cidadeFilter.IdCidade = int.Parse(searchString);
                    spec = new CidadeByIdSpec(cidadeFilter);
                }
                else
                {
                    cidadeFilter.Nome=searchString;
                    spec = new CidadeSpec(cidadeFilter);
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
             var result = await cidadeAppService.ProjectToListAsync<CidadeViewModel>(spec, cidadeFilter, new CancellationToken());
             var resultPVM = new PagedResponseViewModel<CidadeViewModel>(result, cidadeFilter);
             //return View(result);
             return View(resultPVM);
         }






        /*
        [HttpPost]
        public async Task<IActionResult> Index(CidadeFilter CidadeFilter)
        //public async Task<IActionResult> Index(CidadeFilter filter)
        {

              //filter.Nome = "Cacoal";
              //filter.IdCidade = 4;
           // CidadeFilter filter = new CidadeFilter() {Nome=NomeCidadeFilter };
            var spec = new CidadeSpec(CidadeFilter);

            var result = await cidadeAppService.ProjectToListAsync<CidadeViewModel>(spec, CidadeFilter, new CancellationToken());
            var resultPVM = new PagedResponseViewModel<CidadeViewModel>(result, CidadeFilter);
            
            
            ///return ViewComponent("~/Views/Shared/Partials/_Buscar.cshtmlPagedResponse", result);
           //// return ViewComponent("Cidade",result);


            //return View(result);
            return View(resultPVM);






            //Cacoal
            //  filter.Nome = "Cacoal";
            //  filter.IdCidade = 4;
            //var spec = new CidadeSpec(filter);
            //var result = await cidadeAppService.FirstOrDefaultAsync<Cidade>(spec,filter); //, cancellationToken);
            //var result = await cidadeAppService.FirstOrDefaultAsync(spec);
            //  return View(nameof(Details),result);


            // var result=  await cidadeAppService.ListAsync();
            //return View(result);
            //var applicationDbContext = _context.Cidades.Include(c => c.IdPaisNavigation).Include(c => c.IdUfNavigation);
            //return View(await applicationDbContext.ToListAsync());
        }*/

        // GET: Cidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cidades == null)
            {
                return NotFound();
            }

            var cidade = await _context.Cidades
                .Include(c => c.IdPaisNavigation)
                .Include(c => c.IdUfNavigation)
                .FirstOrDefaultAsync(m => m.IdCidade == id);
            if (cidade == null)
            {
                return NotFound();
            }

            return View(cidade);
        }

        // GET: Cidades/Create
        public IActionResult Create()
        {
            ViewData["IdPais"] = new SelectList(_context.Paises, "IdPais", "Nome");
            ViewData["IdUf"] = new SelectList(_context.Ufs, "IdUf", "Nome");
            return View();
        }

        // POST: Cidades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCidade,IdUf,Nome,IdPais,CodigoIbge,SinCapital,Latitude,Longitude")] Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cidade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPais"] = new SelectList(_context.Paises, "IdPais", "Nome", cidade.IdPais);
            ViewData["IdUf"] = new SelectList(_context.Ufs, "IdUf", "Nome", cidade.IdUf);
            return View(cidade);
        }

        // GET: Cidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cidades == null)
            {
                return NotFound();
            }

            var cidade = await _context.Cidades.FindAsync(id);
            if (cidade == null)
            {
                return NotFound();
            }
            ViewData["IdPais"] = new SelectList(_context.Paises, "IdPais", "Nome", cidade.IdPais);
            ViewData["IdUf"] = new SelectList(_context.Ufs, "IdUf", "Nome", cidade.IdUf);
            return View(cidade);
        }

        // POST: Cidades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCidade,IdUf,Nome,IdPais,CodigoIbge,SinCapital,Latitude,Longitude")] Cidade cidade)
        {
            if (id != cidade.IdCidade)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CidadeExists(cidade.IdCidade))
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
            ViewData["IdPais"] = new SelectList(_context.Paises, "IdPais", "Nome", cidade.IdPais);
            ViewData["IdUf"] = new SelectList(_context.Ufs, "IdUf", "Nome", cidade.IdUf);
            return View(cidade);
        }

        // GET: Cidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cidades == null)
            {
                return NotFound();
            }

            var cidade = await _context.Cidades
                .Include(c => c.IdPaisNavigation)
                .Include(c => c.IdUfNavigation)
                .FirstOrDefaultAsync(m => m.IdCidade == id);
            if (cidade == null)
            {
                return NotFound();
            }

            return View(cidade);
        }

        // POST: Cidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cidades == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Cidades'  is null.");
            }
            var cidade = await _context.Cidades.FindAsync(id);
            if (cidade != null)
            {
                _context.Cidades.Remove(cidade);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public FileResult Exportar()
        {
            //AppDbContext db = new AppDbContext();

            //obtem uma lista de objetos Employee
            List<object> cidades = (from Cidade in _context.Cidades.ToList().Take(9)
                                         select new[] { Cidade.IdCidade.ToString(),
                                                            Cidade.Nome}).ToList<object>();

            //Insere o nome das colunas
            //notasfiscais.Insert(0, new string[4] { "ID NF", "Employee Name", "City", "Country" });
            cidades.Insert(0, new string[2] { "ID_Cidade","Nome" });

            StringBuilder sb = new StringBuilder();

            //percore os funcionarios e gera o CSV
            for (int i = 0; i < cidades.Count; i++)
            {
                string[] cidade = (string[])cidades[i];
                for (int j = 0; j < cidade.Length; j++)
                {
                    //anexa dados com separador
                    sb.Append(cidade[j] + ';');
                }

                //Anexa uma nova linha
                sb.Append("\r\n");
            }
            return File(Encoding.UTF8.GetBytes(sb.ToString()), "text/csv", "GridCidades.csv");
        }
        [HttpPost]

        /*public ActionResult Exportar2(string returnView, ArquivoRemessaVM model)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    using (var db = new Model.Context())
                    {
                        var bll = new BLL.ArquivoRemessaBLL(db, _idUsuario);


                        byte[] streamByte = null;

                        var texto = bll.GeraRemessaRCB800(model.nrConvenio.Value, model.nrAgencia.Value, model.cdCliente.Value, model.flTipoArquivo, model.nrSequencial.Value, model.nrAno.Value, model.cdDivida.Value);

                        streamByte = Encoding.Convert(Encoding.GetEncoding("ISO-8859-1"), Encoding.GetEncoding(1252), Encoding.GetEncoding("ISO-8859-1").GetBytes(texto));

                        if (Request.IsAjaxRequest())
                        {
                            var file64 = Convert.ToBase64String(streamByte);

                            return Json(new { File = file64, MimeType = "text/plain", FileName = "ARQUIVO_REMESSA_RCB800" + "_" + model.nrAno + ".txt" });
                        }
                        else
                            return File(streamByte, "text/plain", "ARQUIVO_REMESSA_RCB800" + "_" + model.nrAno + ".txt");
                    }
                }
                catch (Util.Exception.RPException rpEx)
                {
                    this.AddFlashMessage(Util.Exception.Message.Get(rpEx), FlashMessage.ERROR);
                    return View(model);
                }
                catch (Exception ex)
                {
                    Util.Entity.ErroLog.Add(ex, Session.SessionID, _idUsuario);
                    return RedirectToAction("Index", "Erro", new { area = string.Empty });
                }
            }

            return View(model);
        }*/
        private bool CidadeExists(int id)
        {
          return (_context.Cidades?.Any(e => e.IdCidade == id)).GetValueOrDefault();
        }
    }
}
