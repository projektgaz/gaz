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
        [Authorize(Roles = "Organizator,User")]
        public ActionResult EventList()
        {
            List<EventViewModels> lista = new EventDBContext().Eventy.OrderBy(x => x.Data).ToList<EventViewModels>();
            var viewModel = new Events()
            {
                Wydarzenie = lista
            };
            return View(viewModel);
        }
        [Authorize(Roles = "Organizator,User")]
        public ActionResult EventDetails(int id)
        {
            EventViewModels detailModel = new EventDBContext().Eventy.Find(id);
            return View(detailModel);
        }

    }
}