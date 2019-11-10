using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure;

namespace G.A.Z.SIOS.Models
{
    public class EventViewModels
    {
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
        [Display(Name = "Cena_wejściówki")]
        public decimal Cena_wejsciowki { get; set; }
        public int ID_organizator { get; set; }
        [Required]
        [Display(Name = "Rodzaj_wydarzenia")]
        public string Rodzaj { get; set; }
        public decimal Opinia_value { get; set; }
    }
    public class Events
    {
        public List<EventViewModels> Wydarzenie { get; set; }
    }
    public class EventDBContext : DbContext
    {
        public EventDBContext() : base("name=DefaultConnection")
        {
        }
        public DbSet<EventViewModels> Wydarzenia { get; set; }
    }
}