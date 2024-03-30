using Car.Models;
using CarsName.Models;
using Microsoft.EntityFrameworkCore;

namespace Car.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        

        public DbSet<Cars> Cars { get; set; }
        public DbSet<Body> Bodies { get; set; }
        public DbSet<CarBody> CarBodies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarBody>()
                .HasKey(cb => new { cb.CarId, cb.BodyId });

            modelBuilder.Entity<CarBody>()
                .HasOne(cb => cb.Car)
                .WithMany(c => c.CarBodies)
                .HasForeignKey(cb => cb.CarId);

            modelBuilder.Entity<CarBody>()
                .HasOne(cb => cb.Body)
                .WithMany(b => b.CarBodies)
                .HasForeignKey(cb => cb.BodyId);
        }

    }
}
