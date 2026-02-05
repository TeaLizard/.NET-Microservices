using Microsoft.EntityFrameworkCore;
using Assignment_1.Entities;

namespace Assignment1.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Vehicle>().HasData(
                new Vehicle { }
            );
        }
    }
}