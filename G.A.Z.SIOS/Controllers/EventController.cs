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
            List<EventViewModels> lista = new EventDBContext().Wydarzenia.ToList<EventViewModels>();

            var viewModel = new Events()
            {
                Wydarzenie = lista
            };
            return View(viewModel);
        }
    }
}