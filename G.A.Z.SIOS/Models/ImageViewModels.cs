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
    public class ImageViewModels
    {
        [Key]
        [Display(Name = "Plakat promocyjny")]
        public int Image_id { get; set; }
        [Display(Name = "Byte")]
        public byte[] ImageByte { get; set; }


    }

    public class ImageDBContext : DbContext
    {
        public DbSet<ImageViewModels> Images { get; set; }
        public ImageDBContext() : base("name=DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    public class ImageFiles
    {
        [Display(Name = "Plakat promocyjny")]
        public HttpPostedFileBase ImageFile { get; set; }
    }

    public class Images
    {
        public List<ImageViewModels> Image { get; set; }
    }
}