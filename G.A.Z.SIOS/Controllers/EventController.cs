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
                ViewBag.Message = "#Targi pracy";
                viewModel = new Events();
                viewModel.Wydarzenie = new List<EventViewModels>();
                foreach (var item in lista)
                {
                    string str = item.Rodzaj;
                    if (str.Contains("Targi_pracy,"))
                    {
                        viewModel.Wydarzenie.Add(item);
                    }
                }
            }
            if (t == 2)
            {
                ViewBag.Message = "#Świąteczne";
                viewModel = new Events();
                viewModel.Wydarzenie = new List<EventViewModels>();
                foreach (var item in lista)
                {
                    string str = item.Rodzaj;
                    if (str.Contains("Swiateczne"))
                    {
                        viewModel.Wydarzenie.Add(item);
                    }
                }
            }
            if (t == 3)
            {
                ViewBag.Message = "#Sport";
                viewModel = new Events();
                viewModel.Wydarzenie = new List<EventViewModels>();
                foreach (var item in lista)
                {
                    string str = item.Rodzaj;
                    if (str.Contains("Sport"))
                    {
                        viewModel.Wydarzenie.Add(item);
                    }
                }
            }
            if (t == 4)
            {
                ViewBag.Message = "#Przysięga";
                viewModel = new Events();
                viewModel.Wydarzenie = new List<EventViewModels>();
                foreach (var item in lista)
                {
                    string str = item.Rodzaj;
                    if (str.Contains("Przysiega"))
                    {
                        viewModel.Wydarzenie.Add(item);
                    }
                }
            }
            if (t == 5)
            {
                ViewBag.Message = "#Pożegnalne";
                viewModel = new Events();
                viewModel.Wydarzenie = new List<EventViewModels>();
                foreach (var item in lista)
                {
                    string str = item.Rodzaj;
                    if (str.Contains("Pozegnalne"))
                    {
                        viewModel.Wydarzenie.Add(item);
                    }
                }
            }
            if (t == 6)
            {
                ViewBag.Message = "#Piknik";
                viewModel = new Events();
                viewModel.Wydarzenie = new List<EventViewModels>();
                foreach (var item in lista)
                {
                    string str = item.Rodzaj;
                    if (str.Contains("Piknik"))
                    {
                        viewModel.Wydarzenie.Add(item);
                    }
                }
            }
            if (t == 7)
            {
                ViewBag.Message = "#Naukowe";
                viewModel = new Events();
                viewModel.Wydarzenie = new List<EventViewModels>();
                foreach (var item in lista)
                {
                    string str = item.Rodzaj;
                    if (str.Contains("Naukowe"))
                    {
                        viewModel.Wydarzenie.Add(item);
                    }
                }
            }
            if (t == 8)
            {
                ViewBag.Message = "#Promocja Wojskowa";
                viewModel = new Events();
                viewModel.Wydarzenie = new List<EventViewModels>();
                foreach (var item in lista)
                {
                    string str = item.Rodzaj;
                    if (str.Contains("Promocja_wojskowa"))
                    {
                        viewModel.Wydarzenie.Add(item);
                    }
                }
            }
            if (t == 9)
            {
                ViewBag.Message = "#Konkurs";
                viewModel = new Events();
                viewModel.Wydarzenie = new List<EventViewModels>();
                foreach (var item in lista)
                {
                    string str = item.Rodzaj;
                    if (str.Contains("Konkurs"))
                    {
                        viewModel.Wydarzenie.Add(item);
                    }
                }
            }
            if (t == 10)
            {
                ViewBag.Message = "#Juwenalia";
                viewModel = new Events();
                viewModel.Wydarzenie = new List<EventViewModels>();
                foreach (var item in lista)
                {
                    string str = item.Rodzaj;
                    if (str.Contains("Juwenalia"))
                    {
                        viewModel.Wydarzenie.Add(item);
                    }
                }
            }
            if (t == 11)
            {
                ViewBag.Message = "#Inne";
                viewModel = new Events();
                viewModel.Wydarzenie = new List<EventViewModels>();
                foreach (var item in lista)
                {
                    string str = item.Rodzaj;
                    if (str.Contains("Inne"))
                    {
                        viewModel.Wydarzenie.Add(item);
                    }
                }
            }
            return View("EventList", viewModel);
        }

        [Authorize(Roles = "Organizator,User")]
        public ActionResult EventDetails(int? id, int? t)
        {
            EventViewModels evm = new EventDBContext().Eventy.Find(id);
            var detailModel = evm;
            if(t == 1)
            {
                ViewBag.SuccessMessage = "Dziękujemy za wzięcie udziału";
            }
            if(t == 2)
            {
                ViewBag.SuccessMessage = "Dziękujemy za zainteresowanie wydarzeniem";
            }
            return View("EventDetails", detailModel);
        }

    }
}