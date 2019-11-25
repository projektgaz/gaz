using G.A.Z.SIOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

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

        [Authorize(Roles = "Organizator")]
        public ActionResult Moje_wydarzenia()
        {
            EventViewModels obj = new EventViewModels();
            Rodzaje rodzaje = new Rodzaje();
            EventDBContext eventDBContext = new EventDBContext();
            ImageDBContext imageDBContext = new ImageDBContext();
            var ImageRecords = imageDBContext.Images.ToList();
            var EventRecords = eventDBContext.Eventy.ToList();
            ImageFiles imageFiles = new ImageFiles();
            ImageViewModels image = new ImageViewModels();
            var objekty = new Objekty()
            {
                EventViewModels = obj,
                Rodzaje = rodzaje,
                Wydarzenie = EventRecords,
                ImageViewModels = image,
                ImageFiles = imageFiles,
                Image = ImageRecords
            };
            return View("Moje_wydarzenia", objekty);
        }

        [Authorize(Roles = "Organizator")]
        public ActionResult EventEdit(int event_id)
        {
            EventDBContext eventDBContext = new EventDBContext();
            ImageDBContext imageDBContext = new ImageDBContext();
            var ImageRecords = imageDBContext.Images.ToList();
            var EventRecords = eventDBContext.Eventy.ToList();
            Rodzaje rodzaje = new Rodzaje();
            var wybrane_wydarzenie = (from item in eventDBContext.Eventy where item.ID == event_id select item).First();
            ImageFiles imageFiles = new ImageFiles();
            ImageViewModels image = new ImageViewModels();
            var objekty = new Objekty()
            {
                EventViewModels = wybrane_wydarzenie,
                Rodzaje = rodzaje,
                Wydarzenie = EventRecords,
                ImageViewModels = image,
                ImageFiles = imageFiles,
                Image = ImageRecords
            };
            return View("EventEdit", objekty);
        }

        [HttpPost]
        [Authorize(Roles = "Organizator")]
        public ActionResult EventEdit(Objekty obj)
        {
            string typ = "";
            if (obj.Rodzaje.Targi_pracy == true) typ += "Targi_pracy,";
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
                return View("EventEdit", obj);
            }
            EventDBContext eventDBContext = new EventDBContext();
            var wybrane_wydarzenie = (from item in eventDBContext.Eventy where item.ID == obj.EventViewModels.ID select item).First();
            wybrane_wydarzenie.Nazwa = obj.EventViewModels.Nazwa;
            wybrane_wydarzenie.Miejsce = obj.EventViewModels.Miejsce;
            wybrane_wydarzenie.Opis = obj.EventViewModels.Opis;
            wybrane_wydarzenie.Data = obj.EventViewModels.Data;
            wybrane_wydarzenie.Rodzaj = obj.EventViewModels.Rodzaj;
            wybrane_wydarzenie.Cena_wejsciowki = obj.EventViewModels.Cena_wejsciowki;
            eventDBContext.SaveChanges();
            ViewBag.SuccessMessage = "Twoje wydarzenie zostało pomyślnie zmodyfikowane!";
            return View("EventEdit", obj);
        }


        [Authorize(Roles = "Organizator")]
        public ActionResult EventDelete(int event_id)
        {
            EventDBContext eventDBContext = new EventDBContext();
            ImageDBContext imageDBContext = new ImageDBContext();
            var wybrane_wydarzenie = (from item in eventDBContext.Eventy where item.ID == event_id select item).First();
            eventDBContext.Eventy.Remove(wybrane_wydarzenie);
            eventDBContext.SaveChanges();
            EventViewModels obj = new EventViewModels();
            ImageViewModels image = new ImageViewModels();
            Rodzaje rodzaje = new Rodzaje();
            var EventRecords = eventDBContext.Eventy.ToList();
            var ImageRecords = imageDBContext.Images.ToList();
            ImageFiles imageFiles = new ImageFiles();
            var objekty = new Objekty()
            {
                EventViewModels = obj,
                Rodzaje = rodzaje,
                Wydarzenie = EventRecords,
                ImageViewModels = image,
                ImageFiles = imageFiles,
                Image = ImageRecords
            };
            return View("Moje_wydarzenia", objekty);
        }

        [Authorize(Roles = "Organizator")]
        public ActionResult EventMarketing(int event_id)
        {
            EventDBContext eventDBContext = new EventDBContext();
            ImageDBContext imageDBContext = new ImageDBContext();
            var wybrane_wydarzenie = (from item in eventDBContext.Eventy where item.ID == event_id select item).First();
            ImageViewModels image = new ImageViewModels();
            image.Image_id = wybrane_wydarzenie.ID;
            Rodzaje rodzaje = new Rodzaje();
            var EventRecords = eventDBContext.Eventy.ToList();
            var ImageRecords = imageDBContext.Images.ToList();
            ImageFiles imageFiles = new ImageFiles();
            var objekty = new Objekty()
            {
                EventViewModels = wybrane_wydarzenie,
                Rodzaje = rodzaje,
                Wydarzenie = EventRecords,
                ImageViewModels = image,
                ImageFiles = imageFiles,
                Image = ImageRecords
            };
            return View("EventMarketing", objekty);
        }

        [HttpPost]
        [Authorize(Roles = "Organizator")]
        public ActionResult EventMarketing(Objekty obj)
        {
            BinaryReader rdr = new BinaryReader(obj.ImageFiles.ImageFile.InputStream);
            obj.ImageViewModels.ImageByte = rdr.ReadBytes((int)obj.ImageFiles.ImageFile.ContentLength);

            ImageDBContext imageDBContext = new ImageDBContext();
            imageDBContext.Images.Add(obj.ImageViewModels);
            imageDBContext.SaveChanges();

            EventDBContext eventDBContext = new EventDBContext();
            var wybrane_wydarzenie = (from item in eventDBContext.Eventy where item.ID == obj.EventViewModels.ID select item).First();
            wybrane_wydarzenie.Image_id = obj.ImageViewModels.Image_id;
            eventDBContext.SaveChanges();
            
            ViewBag.SuccessMessage = "Twój plakat został dodany pomyślnie!";
            return View("EventMarketing", obj);
        }
    }
}