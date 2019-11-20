﻿using G.A.Z.SIOS.Models;
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
        [Authorize(Roles = "Organizator,User")]
        public ActionResult EventInterested(int? id)
        {
            EventViewModels evm = new EventDBContext().Eventy.Find(id);
            var detailModel = evm;
            ViewBag.SuccessMessage = "Dziękujemy za zainteresowanie wydarzeniem";
            return View("EventDetails", detailModel);
        }
        [Authorize(Roles = "Organizator,User")]
        public ActionResult EventJoin(int? id)
        {
            EventViewModels evm = new EventDBContext().Eventy.Find(id);
            var detailModel = evm;
            ViewBag.SuccessMessage = "Dziękujemy za wzięcie udziału";
            return View("EventDetails", detailModel);
        }
    }
}