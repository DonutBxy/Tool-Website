using Tool_Website.Models;
using Microsoft.EntityFrameworkCore;

namespace Tool_Website.data
{
    public class toolcontext: DbContext
    {
        public DbSet<product> Products { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=Tool_Website.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
        }
    }
}