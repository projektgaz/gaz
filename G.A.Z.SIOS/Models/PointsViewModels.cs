using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace G.A.Z.SIOS.Models
{
    public class PointsViewModels
    {
        public int Id { get; set; }
        [Required]
        public string ID_User { get; set; }
        [Required]
        public int Points { get; set; }
    }
    public class PointsDBContext : DbContext
    {
        public DbSet<PointsViewModels> Interested { get; set; }
        public PointsDBContext() : base("name=DefaultConnection")
        {
            //disable initializer
            Database.SetInitializer<PointsDBContext>(null);
        }
    }
}
