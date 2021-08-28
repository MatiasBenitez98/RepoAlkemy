using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using ProyectoAlkemy.Entities;

namespace ProyectoAlkemy.Contexts
{
    public class ContextGeo : DbContext
    {
        public ContextGeo(DbContextOptions options) : base(options) //Constructor base, agregamos un valor de tipo optiones y lo llamamos
        {

        }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Continent> Continents { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<GeographicIcons> GeocIcons { get; set; }

    }
}
