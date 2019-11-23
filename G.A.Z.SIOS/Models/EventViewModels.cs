using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure;
using System.Web.Mvc;

namespace G.A.Z.SIOS.Models
{
    public class EventViewModels
    {
        [Display(Name = "Id")]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Nazwa")]
        public string Nazwa { get; set; }
        [Required]
        [Display(Name = "Data")]
        public DateTime Data { get; set; }
        [Required]
        [Display(Name = "Miejsce")]
        public string Miejsce { get; set; }
        [Required]
        [Display(Name = "Cena biletu")]
        public decimal Cena_wejsciowki { get; set; }
        [Display(Name = "Id_organizatora")]
        public string ID_organizator { get; set; }
        [Display(Name = "Rodzaj_wydarzenia")]
        public string Rodzaj { get; set; }
        [Display(Name = "Ocena")]
        public decimal Opinia_value { get; set; }
        [Display(Name = "Liczba \"weź udział\"")]
        public int Udzial_count { get; set; }
        [Display(Name = "Liczba zainteresowanych")]
        public int Zainteresowani_count { get; set; }
        [Display(Name = "Plakat promocyjny")]
        public int Image_id { get; set; }
        [Required]
        [Display(Name = "Opis_wydarzenia")]
        public string Opis { get; set; }
        public EventViewModels()
        {
            Data = DateTime.Now;
        }
    }
    public class Events
    {
        public List<EventViewModels> Wydarzenie { get; set; }
    }
    public class EventDBContext : DbContext
    {
        public DbSet<EventViewModels> Eventy { get; set; }
        public EventDBContext() : base("name=DefaultConnection")
        {
            //disable initializer
            Database.SetInitializer<EventDBContext>(null);
        }
    }
    public class Rodzaje
    {
        [Display(Name = "Targi pracy")]
        public Boolean Targi_pracy { get; set; }
        [Display(Name = "Juwenalia")]
        public Boolean Juwenalia { get; set; }
        [Display(Name = "Piknik")]
        public Boolean Piknik { get; set; }
        [Display(Name = "Sport")]
        public Boolean Sport { get; set; }
        [Display(Name = "Konkurs")]
        public Boolean Konkurs { get; set; }
        [Display(Name = "Naukowe")]
        public Boolean Naukowe { get; set; }
        [Display(Name = "Przysiega")]
        public Boolean Przysiega { get; set; }
        [Display(Name = "Promocja wojskowa")]
        public Boolean Promocja_wojskowa { get; set; }
        [Display(Name = "Pożegnalne")]
        public Boolean Pozegnalne { get; set; }
        [Display(Name = "Świąteczne")]
        public Boolean Swiateczne { get; set; }
        [Display(Name = "Inne")]
        public Boolean Inne { get; set; }
    }
    public class Objekty
    {
        public EventViewModels EventViewModels { get; set; }
        public Rodzaje Rodzaje { get; set; }
        public List<EventViewModels> Wydarzenie { get; set; }
    }
    
}