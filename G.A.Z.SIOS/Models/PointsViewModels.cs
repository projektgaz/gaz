using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace G.A.Z.SIOS.Models
{
    public class PointsViewModels
    {
        public int Id { get; set; }
        public string ID_User { get; set; }
        public int Points { get; set; }
    }
    public class PointsDBContext : DbContext
    {
        public DbSet<PointsViewModels> Points { get; set; }
        public PointsDBContext() : base("name=DefaultConnection")
        {
            //disable initializer
            Database.SetInitializer<EventDBContext>(null);
        }
    }
}