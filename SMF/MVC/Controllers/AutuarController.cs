using Application.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class AutuarController : Controller
    {
        private readonly IImovelAppService imovelAppService;
        IMapper mapper;

        public AutuarController(IImovelAppService imovelAppService, IMapper mapper)
        {
            this.imovelAppService = imovelAppService;
            this.mapper = mapper;
        }
        public ActionResult Index()
        {
            return View(new ImovelViewModel());
        }
        // GET: AutuarController

        [HttpPost]
        public ActionResult Imovel(ImovelViewModel imovel)
        {
            //var contextoAplicacao = _context.dbSEnderecos.Include(e => e.Bairro).Include(e => e.Cidade).Include(e => e.Logradouro);
            ImovelViewModel imovelvm = mapper.Map<ImovelViewModel>(imovelAppService.Find(imovel.ImovelId));
            //ServidorViewModel servidor = new ServidorViewModel();
            
            return View(imovelvm);
        }

        // GET: AutuarController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AutuarController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AutuarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AutuarController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AutuarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AutuarController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AutuarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
