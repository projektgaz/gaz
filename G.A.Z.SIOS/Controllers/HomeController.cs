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

        [Authorize(Roles = "Organizator,User")]
        public ActionResult Imprezy_studenckie()
        {
            ViewBag.Message = "Aktualne wydarzenia studenckie.";

            return RedirectToAction("EventList", "Event", 0);
        }
        
        [Authorize(Roles = "Organizator")]
        public ActionResult Dodaj_wydarzenie()
        {
            EventViewModels obj = new EventViewModels();
            Rodzaje rodzaje = new Rodzaje();
            var objekty = new Objekty()
            {
                EventViewModels = obj,
                Rodzaje = rodzaje
            };
            return View("Dodaj_wydarzenie", objekty);
        }
        [HttpPost]
        [Authorize(Roles = "Organizator")]
        public ActionResult Dodaj_wydarzenie(Objekty obj)
        {
            string typ = "";
            if (obj.Rodzaje.Targi_pracy == true)typ += "Targi_pracy,";
            if (obj.Rodzaje.Swiateczne == true) typ += "Swiateczne,";
            if (obj.Rodzaje.Sport == true) typ += "Sport,";
            if (obj.Rodzaje.Przysiega == true) typ += "Przysiega,";
            if (obj.Rodzaje.Promocja_wojskowa == true) typ += "Promocja_wojskowa,";
            if (obj.Rodzaje.Pozegnalne == true) typ += "Pozegnalne,";
            if (obj.Rodzaje.Piknik == true) typ += "Piknik,";
            if (obj.Rodzaje.Naukowe == true) typ += "Naukowe,";
            if (obj.Rodzaje.Konkurs == true) typ += "Konkurs,";
            if (obj.Rodzaje.Juwenalia == true) typ += "Juwenalia,";
            if (obj.Rodzaje.Inne == true) typ += "Inne,";
            obj.EventViewModels.Rodzaj = typ;
            if (!ModelState.IsValid)
            {
                return View("Dodaj_wydarzenie", obj);
            }
            EventDBContext eventDBContext = new EventDBContext();
            eventDBContext.Eventy.Add(new EventViewModels() { Nazwa = obj.EventViewModels.Nazwa, Miejsce = obj.EventViewModels.Miejsce, Cena_wejsciowki = obj.EventViewModels.Cena_wejsciowki, Rodzaj = obj.EventViewModels.Rodzaj, Data = obj.EventViewModels.Data, Opis = obj.EventViewModels.Opis, ID_organizator = User.Identity.Name });
            eventDBContext.SaveChanges();
            ViewBag.SuccessMessage = "Twoje wydarzenie zostało dodane pomyślnie!";
            return View("Dodaj_wydarzenie");

        }

        [Authorize(Roles = "Organizator,User")]
        public ActionResult Opinie_i_raporty()
        {
            OpiniaViewModels op = new OpiniaViewModels();
            OpiniaDBContext opiniaDBContext = new OpiniaDBContext();
            opiniaDBContext.Opinie.Add(new OpiniaViewModels() { Opinia = op.Opinia, IdUzytkownika = User.Identity.Name,  Data = op.Data,  IdWydarzenia = op.IdWydarzenia });
            opiniaDBContext.SaveChanges();
            ViewBag.SuccessMessage = "Twoja opinia została dodana pomyślnie!";
            return View("Opinie_i_raporty");
        }

    }
}