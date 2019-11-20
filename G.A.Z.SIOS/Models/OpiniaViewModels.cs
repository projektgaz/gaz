using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace G.A.Z.SIOS.Models
{
    public class OpiniaViewModels
    {
        public int ID { get; set; }
        [Required]
        public string Opinia { get; set; }
        [Required]
        public int IdUzytkownika { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public int IdWydarzenia { get; set; }
    }
    //public class OpiniaDBContext : DbContext
    //{
        //public OpiniaDBContext() : base("name=DefaultConnection")
        //{
        //}
       // public DbSet<OpiniaViewModels> Wydarzenia { get; set; }
    //}
}

/*
id
treść
użytkownik
data
id wydarzenia
*/