using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using G.A.Z.SIOS.Models;

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
        
        public ActionResult Imprezy_studenckie()
        {
            ViewBag.Message = "Aktualne wydarzenia studenckie.";

            return RedirectToAction("EventList", "Event");
        }
        
        public ActionResult Dodaj_wydarzenie()
        {
            EventViewModels obj = new EventViewModels();

            return View("Dodaj_wydarzenie",obj);
        }
        [HttpPost]
        public ActionResult Dodaj_wydarzenie(EventViewModels obj)
        {
            if (!ModelState.IsValid)
            {
                return View("Dodaj_wydarzenie", obj);
            }

            EventDBContext eventDBContext = new EventDBContext();
            eventDBContext.Wydarzenia.Add(new EventViewModels() { Nazwa = obj.Nazwa, Miejsce = obj.Miejsce, Cena_wejsciowki = obj.Cena_wejsciowki, Rodzaj = obj.Rodzaj, Data = obj.Data });
            eventDBContext.SaveChanges();
            return View("Dodaj_wydarzenie", obj);

        }

        [Authorize]
        public ActionResult Opinie_i_raporty()
        {
            ViewBag.Message = "Aktualne wydarzenia studenckie.";

            return View();
        }
    }
}