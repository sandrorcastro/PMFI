using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities.MegaData;
using Domain.Entities.NFSEDB;
using Application.Services;
using Application.ViewModels;
using Domain.Filters;
using Domain.Interfaces.Specifications;
using Domain.Specs;
using Application.Interfaces;
using Application.ViewModels.MegaData;
using Infrastructure.Context;
using System.Text;
using System.Globalization;

namespace MegaData.Controllers
{
    public class MegaData_NFSEController : Controller
    {
        private readonly MegaDataDBContext _context;
        private NFSEDBContext _NFSEDBContext;
        private readonly IMegaData_NFSE_AppService megaData_Nfse_AppService;
        private readonly IMegaData_Export_AppService megaData_Export_AppService;


        public MegaData_NFSEController(MegaDataDBContext context, IMegaData_NFSE_AppService _nfseAppService, IMegaData_Export_AppService megaData_Export_AppService, NFSEDBContext nFSEDBContext)
        {
            _context = context;
            megaData_Nfse_AppService = _nfseAppService;
            this.megaData_Export_AppService = megaData_Export_AppService;
            _NFSEDBContext = nFSEDBContext;
        }

        /*
        // GET: MegaData_NFSE
        public async Task<IActionResult> Index()
        {
              return _context.MegaData_NFSEs != null ? 
                          View(await _context.MegaData_NFSEs.ToListAsync()) :
                          Problem("Entity set 'MegaDataDBContext.MegaData_NFSEs'  is null.");
        }
        */
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {

            ISpecification<MegaData_NFSE> spec = null;
            MegaData_NFSEFilter Filter = new MegaData_NFSEFilter();// { DataGeracao=DateTime.Parse(searchString)};

            ViewData["CurrentSort"] = sortOrder;
            ViewData["DataGeracaoSortParm"] = String.IsNullOrEmpty(sortOrder) ? "DataGeracao" : "";
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
            var result = await megaData_Nfse_AppService.ProjectToListAsync<MegaData_NFSE_ViewModel>(spec, Filter, new CancellationToken());
            var resultPVM = new PagedResponseViewModel<MegaData_NFSE_ViewModel>(result, Filter);
            //return View(result);
            return View(resultPVM);
        }


        // GET: MegaData_NFSE/Details/5
        public async Task<IActionResult> Details(DateTime? id)
        {

            if (id == null || megaData_Nfse_AppService == null)
            {
                return NotFound();
            }

            if (id == null || _context.MegaData_NFSEs == null)
            {
                return NotFound();
            }

            var megaData_NFSE = await _context.MegaData_NFSEs.FirstOrDefaultAsync(m => m.DataGeracao == id);
            //var megaData_NFSE = await megaData_Nfse_AppService.FirstOrDefaultAsync()
            if (megaData_NFSE == null)
            {
                return NotFound();
            }

            return View(megaData_NFSE);
        }

        // GET: MegaData_NFSE/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MegaData_NFSE/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("DataGeracao,DataInicioPeriodo,DataFinalPeriodo,DataEnvio")] MegaData_NFSE megaData_NFSE)
        public async Task<IActionResult> Create([Bind("DataInicioPeriodo,DataFinalPeriodo")] MegaData_NFSE megaData_NFSE)
        {
            megaData_NFSE.DataGeracao=DateTime.Now;
            if (ModelState.IsValid)
            {
                //_context.Add(megaData_NFSE);
                //megaData_Export_AppService.ProjectToListAsync()

                NfseTblNfseFilter Filter = new NfseTblNfseFilter() { DataInicial=megaData_NFSE.DataInicioPeriodo,DataFinal=megaData_NFSE.DataFinalPeriodo};
                //ISpecification<NfseTblNfse> spec = new NfseTblNfseSpec(Filter);
                ISpecification<NfseTblNfse> spec = new NfseTblNfsePeriodoSpec(Filter);


                //var result = await megaData_Export_AppService.ProjectToListAsync<LayoutNFSE_MegaData>(spec, Filter, new CancellationToken());

                ///
                //var result = await megaData_Export_AppService.ProjectToListAsync<LayoutNFSE_MegaData>(spec, new CancellationToken());
                ///

                /*IEnumerable<NfseTblNfse> nfes = await _NFSEDBContext.NfseTblNfses.Join(_NFSEDBContext.NfseTblEmpresas, nfse => nfse.Idempresa, em => em.Idempresa, (nfse, em) => new { NfseTblNfse = nfse, NfseTblEmpresa = em })
                                                      // .Where(resultado=> resultado.NfseTblEmpresa.Idempresa==resultado.NfseTblNfse.Idempresa && resultado.NfseTblNfse.Dtcompetencia >= megaData_NFSE.DataInicioPeriodo && resultado.NfseTblNfse.Dtcompetencia < megaData_NFSE.DataFinalPeriodo);
                                                      .Where(resultado => resultado.NfseTblEmpresa.Idempresa == resultado.NfseTblNfse.Idempresa)
                                                      .Select(resultado => resultado.NfseTblNfse).Where(nf=>nf.Dtcompetencia>= megaData_NFSE.DataInicioPeriodo && nf.Dtcompetencia < megaData_NFSE.DataFinalPeriodo && nf.Stsituacao != "A"  )
                                                      .Include(e=>e.Empresa)
                                                      .ToListAsync();
                */
                /*                IEnumerable<NfseTblNfse> nfes = await _NFSEDBContext.NfseTblNfses.Join(_NFSEDBContext.NfseTblEmpresas, nfse => nfse.Idempresa, em => em.Idempresa, (nfse, em) => new { NfseTblNfse = nfse, NfseTblEmpresa = em })
                                                                      // .Where(resultado=> resultado.NfseTblEmpresa.Idempresa==resultado.NfseTblNfse.Idempresa && resultado.NfseTblNfse.Dtcompetencia >= megaData_NFSE.DataInicioPeriodo && resultado.NfseTblNfse.Dtcompetencia < megaData_NFSE.DataFinalPeriodo);
                                                                      .Where(resultado => resultado.NfseTblEmpresa.Idempresa == resultado.NfseTblNfse.Idempresa)
                                                                      .Select(resultado => resultado.NfseTblNfse).Where(nf => nf.Dtcompetencia >= megaData_NFSE.DataInicioPeriodo && nf.Dtcompetencia < megaData_NFSE.DataFinalPeriodo && nf.Stsituacao != "A")
                                                                      .Include(e => e.Empresa)
                                                                      .ToListAsync();*/


                /*IEnumerable<NfseTblNfse> nfes = await _NFSEDBContext.NfseTblNfses.Join(_NFSEDBContext.NfseTblEmpresas, nfse => nfse.Idempresa, em => em.Idempresa, (nfse, em) => new { NfseTblNfse = nfse, NfseTblEmpresa = em }).Where(resultado => resultado.NfseTblEmpresa.Idempresa == resultado.NfseTblNfse.Idempresa)
                                                      .Select(resultado => resultado.NfseTblNfse).Where(nf => nf.Dtcompetencia >= megaData_NFSE.DataInicioPeriodo && nf.Dtcompetencia < megaData_NFSE.DataFinalPeriodo && nf.Stsituacao != "A")
                    .Join(_NFSEDBContext.NfseTblContribuintes, c =>  c.nfse c.NfseTblEmpresa.Idcontribuinte, em => em.Idcontribuinte, (c, em) => new {NfseTblContribuinte = c, NfseTblEmpresa =em}).Where(r => r.NfseTblEmpresa.Idcontribuinte==r.NfseTblContribuinte.NfseTblEmpresa.Idcontribuinte)
                                                      .Include(e => e.Empresa)
                                                      .ToListAsync();*/
                var query = (from n in _NFSEDBContext.NfseTblNfses
                             join empresa in _NFSEDBContext.NfseTblEmpresas on n.Idempresa equals empresa.Idempresa
                             join contribuinte in _NFSEDBContext.NfseTblContribuintes on empresa.Idcontribuinte equals contribuinte.Idcontribuinte
                             where n.Dtcompetencia >= megaData_NFSE.DataInicioPeriodo && n.Dtcompetencia < megaData_NFSE.DataFinalPeriodo && n.Stsituacao != "A"
                             //where n.Dtcompetencia >= dti && n.Dtcompetencia < dtf && n.Stsituacao != "A"
                             
                             //select new LayoutNFSE_MegaData { Ano = n.Dtcompetencia.ToString(), Numero = n.Nunumero });
                             select new LayoutNFSE_MegaData {Stcpfcnpj=contribuinte.Idcontribuinte.ToString(),
                                                             Ano = n.Dtcompetencia.Value.Year.ToString(),
                                                             Mes = int.Parse(n.Dtcompetencia.Value.Month.ToString()),
                                                             Numero = n.Nunumero,
                                                             Situacao=1,
                                                             //Localtributacao=n.Idoperacao
                                                             Servico116=n.Idservico,
                                                             Issretido=n.Stissretido=="S" ? 1 : 0 ,
                                                             Basecalculo=n.Vlbasecalculo.ToString(),
                                                             Aliquota=n.Pcaliquota.ToString(),
                                                             Vlriss= n.Stissretido == "N" ? n.Vltotaliss.ToString(): "0",   ///
                                                             Vlrissretido=n.Stissretido == "S" ? n.Vlissretido.ToString(): "0",  ////
                                                             Cmeprestador=n.StpreIm,
                                                             Cpfcnpjtomador=n.SttomPessoaTipo,
                                                             Nometomador=n.SttomNome,
                                                             Tom=7563,
                                                             //Exigibilidade=int.Parse(n.Idoperacao),
                                                             Deducoes=n.Vldeducoes.ToString(),
                                                             Vlrservico=n.Vlservicos.ToString(),
                                                             Cdverificacao=n.Stcodigo
                             });




                //var nfse1 = from nfse in 

                //var q = _NFSEDBContext.NfseTblNfses.Join(_NFSEDBContext.NfseTblEmpresas,nfe => nfe.Idempresa, empresa => empresa.Idempresa, (nfe, empresa) => new  {NfseTblNfse=nfe,NfseTblEmpresa=empresa }).Where(resultado => resultado.NfseTblEmpresa.Idempresa == resultado.NfseTblNfse.Idempresa)
                //                                 .Join(_NFSEDBContext.NfseTblContribuintes, empresa=>empresa.idcontribuinte, contribuinte=>contribuinte.Idcontribuinte , (empresa,contribuinte) => new { NfseTblContribuinte = contribuinte, NfseTblEmpresa = empresa }).Where(resultado => resultado.NfseTblEmpresa.Idcontribuinte == resultado.NfseTblContribuinte.IdContribuinte)




                //List<NfseTblNfse>  query = (from n in _NFSEDBContext.NfseTblNfses

                /*var query = (from n in _NFSEDBContext.NfseTblNfses
                             join empresa in _NFSEDBContext.NfseTblEmpresas on n.Idempresa equals empresa.Idempresa
                             join contribuinte in _NFSEDBContext.NfseTblContribuintes on empresa.Idcontribuinte equals contribuinte.Idcontribuinte
                             where n.Dtcompetencia >= megaData_NFSE.DataInicioPeriodo && n.Dtcompetencia < megaData_NFSE.DataFinalPeriodo && n.Stsituacao != "A"
                             select n);*/



                //IEnumerable<NfseTblNfse> nfes = (IEnumerable<NfseTblNfse>) query.ToListAsync();
                //IEnumerable<NfseTblNfse> nfes = query.ToList();
                //List<NfseTblNfse> nfes = query.ToList();

                StringBuilder builder = new StringBuilder();

                //percore os funcionarios e gera o CSV
                foreach (var n in query.ToList())
                {
                    //builder.AppendLine($"n.Stcpfcnpj;{n.Dtcompetencia:yyyy};{n.Dtcompetencia:MM};{n.Nunumero};{1};{n.Idoperacao};{n.Idservico};{n.Stissretido};{n.Stissretido};{n.StpreIm};{n.SttomPessoaTipo};{n.SttomNome};{7563};{n.Idoperacao};{n.Vldeducoes};{n.Vlservicos};{n.Stcodigo}");
                    builder.AppendLine($"{n.Stcpfcnpj};{n.Ano};{n.Mes};{n.Numero};{1};{n.Localtributacao};{n.Servico116};{n.Issretido};{n.Basecalculo};{n.Aliquota};{n.Vlriss};{n.Vlrissretido};{n.Cmeprestador};{n.Cpfcnpjtomador};{n.Nometomador};{7563};{n.Exigibilidade};{n.Deducoes};{n.Vlrservico};{n.Cdverificacao}");
                }

                //return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "GridNotasFiscais.txt");
                //await megaData_Nfse_AppService.AddAsync(megaData_NFSE);
                await _context.AddAsync(megaData_NFSE);
                await _context.SaveChangesAsync();
                //              //return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", $"NotasFiscais-{megaData_NFSE.DataInicioPeriodo}-{megaData_NFSE.DataFinalPeriodo}.txt");
                //var file = File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", $"NotasFiscais-{megaData_NFSE.DataInicioPeriodo}-{megaData_NFSE.DataFinalPeriodo}.txt");
                //StoreInFolder(file,"teste");

                //var result = query.ToList()

                //&& resultado.NfseTblNfse.Dtcompetencia >= megaData_NFSE.DataInicioPeriodo && resultado.NfseTblNfse.Dtcompetencia < megaData_NFSE.DataFinalPeriodo);

                /*List<object> nfes = (from nfsetblnfse in _NFSEDBContext.NfseTblNfses.Where(n => n.Dtcompetencia >= megaData_NFSE.DataInicioPeriodo && n.Dtcompetencia <= megaData_NFSE.DataFinalPeriodo && n.Stsituacao != "A").Include(e=>e.Empresa).ToList()
                                             select new[] { nfsetblnfse.Idnfse .ToString(), 
                                          //                  employee.City,
                                            //                employee.Country
                                                 }).ToList<object>();*/




                // var result = await megaData_Export_AppService.ListAsync(spec);


                //await _context.SaveChangesAsync();
                 return RedirectToAction(nameof(Index));
                //return View("NFs",nfes);
                //return View("LayoutNFSE_MegaData", nfes);//LayoutNFSE_MegaData
                //return View();
            }
            return View(megaData_NFSE);
            
        }

        // GET: MegaData_NFSE/Edit/5
        //public async Task<IActionResult> Edit(DateTime? id)
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null || _context.MegaData_NFSEs == null)
            {
                return NotFound();
            }
           // DateTime dt = DateTime.ParseExact(id,"yyyy/MM/dd HH:mm:ss",CultureInfo.InvariantCulture);
            
            var megaData_NFSE = await _context.MegaData_NFSEs.FindAsync(id);
            if (megaData_NFSE == null)
            {
                return NotFound();
            }
            return View(megaData_NFSE);
        }

        // POST: MegaData_NFSE/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DateTime id, [Bind("DataGeracao,DataInicioPeriodo,DataFinalPeriodo,DataEnvio")] MegaData_NFSE megaData_NFSE)
        {
            if (id != megaData_NFSE.DataGeracao)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(megaData_NFSE);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MegaData_NFSEExists(megaData_NFSE.DataGeracao))
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
            return View(megaData_NFSE);
        }

        // GET: MegaData_NFSE/Delete/5
        public async Task<IActionResult> Delete(DateTime? id)
        {
            if (id == null || _context.MegaData_NFSEs == null)
            {
                return NotFound();
            }

            var megaData_NFSE = await _context.MegaData_NFSEs
                .FirstOrDefaultAsync(m => m.DataGeracao == id);
            if (megaData_NFSE == null)
            {
                return NotFound();
            }

            return View(megaData_NFSE);
        }

        // POST: MegaData_NFSE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(DateTime id)
        {
            if (_context.MegaData_NFSEs == null)
            {
                return Problem("Entity set 'MegaDataDBContext.MegaData_NFSEs'  is null.");
            }
            var megaData_NFSE = await _context.MegaData_NFSEs.FindAsync(id);
            if (megaData_NFSE != null)
            {
                _context.MegaData_NFSEs.Remove(megaData_NFSE);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MegaData_NFSEExists(DateTime id)
        {
          return (_context.MegaData_NFSEs?.Any(e => e.DataGeracao == id)).GetValueOrDefault();
        }
        /* public void StoreImage(IFormFileCollection files, AutuarViewModel aVM)
        {
            try
            {
                //var files = HttpContext.Request.Form.Files;
                if (files != null)
                {
                    foreach (var file in files)
                    {
                        if (file.Length > 0)
                        {
                            //ImageViewModel imageVM = aVM.Image;//   new ImageViewModel();

                            var fileName = file.FileName;
                            var myUniqueFileName = Convert.ToString(Guid.NewGuid());
                            //imageVM.ImageId = myUniqueFileName;
                            var fileExtension = Path.GetExtension(fileName);
                            var newFileName = String.Concat(myUniqueFileName, fileExtension);
                            var filePath = Path.Combine(environment.WebRootPath, "CameraPhotos") + $@"\{newFileName}";
                            ImageViewModel imageVM = new ImageViewModel()
                            {
                                ImageId = myUniqueFileName,
                                ProcessoId = aVM.Processo.ProcessoId,
                                TipoProcessoId = aVM.TipoProcesso.TipoProcessoId,
                                SituacaoProcessoId = aVM.SituacaoProcesso.SituacaoProcessoId,
                                ImovelId = aVM.Imovel.ImovelId,
                                EconomiaId = aVM.Economia.EconomiaId,
                                SituacaoEtapaId = aVM.SituacaoEtapa.SituacaoEtapaId,
                                TipoEtapaId = aVM.TipoEtapa.TipoEtapaId,
                                //PerspectivaId=aVM.Image.PerspectivaId,
                                NomeArquivo = newFileName,
                                Caminho = filePath
                            };
                            //                            imageVM.NomeArquivo = newFileName;
                            //                          imageVM.Caminho = filePath;

                            if (!string.IsNullOrEmpty(filePath))
                            {
                                StoreInFolder(file, filePath);

                            }
                            var imageBytes = System.IO.File.ReadAllBytes(filePath);
                            if (imageBytes != null)
                            {
                                StoreInDatabase(imageBytes, imageVM);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/
        private void StoreInFolder(IFormFile file, string filename)
        {
            using (FileStream fs = System.IO.File.Create(filename))
            {
                file.CopyTo(fs);
                fs.Flush();
            }
        }
        /*
        private void StoreInDatabase(byte[] imageBytes, ImageViewModel? imageVM)
        {
            //Saving captured into database
            try
            {
                if (imageBytes != null)
                {
                    string base64String = Convert.ToBase64String(imageBytes, 0, imageBytes.Length);
                    string imageUrl = string.Concat("data:image/jpg;base64,", base64String);
                    ImageViewModel NewimageVM = new ImageViewModel()
                    {
                        CreateDate = DateTime.Now,
                        ImageBase64String = imageUrl,
                        ImageId = imageVM.ImageId,
                        ImovelId = imageVM.ImovelId,
                        EconomiaId = imageVM.EconomiaId,
                        ProcessoId = imageVM.ProcessoId,
                        TipoProcessoId = imageVM.TipoProcessoId,
                        SituacaoProcessoId = imageVM.SituacaoProcessoId,
                        SituacaoEtapaId = imageVM.SituacaoEtapaId,
                        TipoEtapaId = imageVM.TipoEtapaId,
                        PerspectivaId = imageVM.PerspectivaId,
                        NomeArquivo = imageVM.NomeArquivo,
                        Caminho = imageVM.Caminho

                    };
                    imageAppService.Add(mapper.Map<Image>(NewimageVM));
                    //_cameraDatabaseContext.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/
    }
}
