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
        public ActionResult EventList(int? t)
        {
            ViewBag.Message = "Wszystkie wydarzenia";
            var viewModel = new Events();
            List<EventViewModels> lista = new EventDBContext().Eventy.OrderBy(x => x.Data).ToList<EventViewModels>();
            viewModel.Wydarzenie = lista;
            if(t == 1)
            {
                ViewBag.Message = "Targi pracy";
                viewModel = new Events();
                foreach (var item in lista)
                {
                    string str = item.Rodzaj;
                    if (str.Contains("Targi_pracy,"))
                    {
                        viewModel.Wydarzenie.Add(item);
                    }
                }
            }
            return View(viewModel);
        }

        [Authorize(Roles = "Organizator,User")]
        public ActionResult EventDetails(int? id, int? t)
        {
            EventViewModels evm = new EventDBContext().Eventy.Find(id);
            var detailModel = evm;
            if(t == 1)
            {
                ViewBag.SuccessMessage = "Dziękujemy za zainteresowanie wydarzeniem";
            }
            if(t == 2)
            {
                ViewBag.SuccessMessage = "Dziękujemy za wzięcie udziału";
            }
            return View("EventDetails", detailModel);
        }

    }
}