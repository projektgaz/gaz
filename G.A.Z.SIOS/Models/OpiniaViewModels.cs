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
    public class OpiniaViewModels
    {
        public int ID { get; set; }
        [Required]
        public string Opinia { get; set; }
        [Required]
        public string IdUzytkownika { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public int IdWydarzenia { get; set; }
    }
    public class OpiniaDBContext : DbContext
    {
        public DbSet<OpiniaViewModels> Opinie { get; set; }
        public OpiniaDBContext() : base("name=DefaultConnection")
        {
            //disable initializer
            Database.SetInitializer<OpiniaDBContext>(null);
        }
    }
}


/*
id
treść
użytkownik
data
id wydarzenia
*/