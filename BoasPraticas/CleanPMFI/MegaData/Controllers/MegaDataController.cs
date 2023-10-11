using Application.ViewModels.MegaData;
using Domain.Entities.MegaData;
using Domain.Entities.NFSEDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace MegaData.Controllers
{
    public class MegaDataController : Controller
    {

        private NFSEDBContext NFSEDBContext;

        public MegaDataController(NFSEDBContext nFSEDBContext)
        {

             NFSEDBContext = nFSEDBContext;
        }

        // GET: MegaDataController
        public ActionResult Index()
        {
            DateTime dti=DateTime.Now.AddDays(-15);
            DateTime dtf = DateTime.Now.AddDays(-14);
            var query = (from n in NFSEDBContext.NfseTblNfses
                         join empresa in NFSEDBContext.NfseTblEmpresas on n.Idempresa equals empresa.Idempresa
                         join contribuinte in NFSEDBContext.NfseTblContribuintes on empresa.Idcontribuinte equals contribuinte.Idcontribuinte
                         //where n.Dtcompetencia >= megaData_NFSE.DataInicioPeriodo && n.Dtcompetencia < megaData_NFSE.DataFinalPeriodo && n.Stsituacao != "A"
                         where n.Dtcompetencia >= dti && n.Dtcompetencia < dtf && n.Stsituacao != "A"

                         select new  LayoutNFSE_MegaData{Ano= n.Dtcompetencia.ToString(), Numero = n.Nunumero  });
            return View(query);
        }

        // GET: MegaDataController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MegaDataController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MegaDataController/Create
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

        // GET: MegaDataController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MegaDataController/Edit/5
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

        // GET: MegaDataController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MegaDataController/Delete/5
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
