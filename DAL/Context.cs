using FrontToBack.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDesc> SliderDescs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<BlogsSlider> BlogsSliders { get; set; }
        public DbSet<InstagramSlider> InstagramSliders { get; set; }
        public DbSet<Bio> Bios { get; set; }
<<<<<<< HEAD
=======
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }



>>>>>>> 51c4e4b201bc97a6db1e8b24abb0b908ceee4bcd

    }
}
