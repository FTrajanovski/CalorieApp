using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ProjektHB.Models
{
    //Skapar en Databas
    public class BurgerModel : DbContext
    {
        public BurgerModel()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CalorieAppDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public DbSet<Burger> Burgers {get; set;}
    }
}
