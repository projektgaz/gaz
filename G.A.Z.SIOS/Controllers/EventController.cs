using G.A.Z.SIOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace G.A.Z.SIOS.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult EventList()
        {
            var Wydarzenie = new List<EventViewModels>
            {
                new EventViewModels() { Nazwa = "Impra1" },
                new EventViewModels() { Nazwa = "Impra2" }
            };
            var viewModel = new Events()
            {
                Wydarzenie = Wydarzenie
            };
            return View(viewModel);
        }
    }
}