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
    public class ParticipantViewModels
    {
        public int Id { get; set; }
        [Required]
        public string ID_User { get; set; }
        [Required]
        public int ID_Event { get; set; }
    }
    public class ParticipantDBContext : DbContext
    {
        public DbSet<ParticipantViewModels> Participant { get; set; }
        public ParticipantDBContext() : base("name=DefaultConnection")
        {
            //disable initializer
            Database.SetInitializer<ParticipantDBContext>(null);
        }
    }
}