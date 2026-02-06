using Microsoft.EntityFrameworkCore;
using Assignment1.Entities;

namespace Assignment1.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}