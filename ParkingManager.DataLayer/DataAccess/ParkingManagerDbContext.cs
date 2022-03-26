using Microsoft.EntityFrameworkCore;
using ParkingManager.DataLayer.DataAccess.Entities;

namespace ParkingManager.DataLayer.DataAccess
{
    public class ParkingManagerDbContext: DbContext
    {
        public virtual DbSet<ParkingLots> ParkingLots { get; set; }
        public virtual DbSet<ParkingSpots> ParkingSpots { get; set; }

        public ParkingManagerDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParkingLots>()
                .HasKey(s => s.LotId);

            modelBuilder.Entity<ParkingSpots>()
                .HasKey(s => new { s.ParkingLot,s.Spot});
        }
    }
}
