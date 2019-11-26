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
    public class InterestedViewModels
    {
        public int Id { get; set; }
        [Required]
        public string ID_User { get; set; }
        [Required]
        public int ID_Event { get; set; }
    }
    public class InterestedDBContext : DbContext
    {
        public DbSet<InterestedViewModels> Interested { get; set; }
        public InterestedDBContext() : base("name=DefaultConnection")
        {
            //disable initializer
            Database.SetInitializer<InterestedDBContext>(null);
        }
    }
}