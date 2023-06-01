using CalorieApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CalorieApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<Food> Food { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CalorieAppDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
