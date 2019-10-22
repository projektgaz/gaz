using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace G.A.Z.SIOS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult Imprezy_studenckie()
        {
            ViewBag.Message = "Aktualne wydarzenia studenckie.";

            return View();
        }

        [Authorize]
        public ActionResult Dodaj_wydarzenie()
        {
            ViewBag.Message = "Aktualne wydarzenia studenckie.";

            return View();
        }

        [Authorize]
        public ActionResult Opinie_i_raporty()
        {
            ViewBag.Message = "Aktualne wydarzenia studenckie.";

            return View();
        }
    }
}