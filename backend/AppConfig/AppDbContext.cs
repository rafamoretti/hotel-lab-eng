using Microsoft.EntityFrameworkCore;
using Model;

namespace AppConfig
{
    public class AppDbContext : DbContext 
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<CheckIn> CheckIns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL("");
    }
}