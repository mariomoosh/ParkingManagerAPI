using ParkingManager.DataLayer.DataAccess.Entities;

namespace ParkingManager.DataLayer.DataAccess.Repositories;

public class ParkingSpotRepository:BaseRepository<ParkingManagerDbContext,ParkingSpots>, IRepository<ParkingSpots>
{
    public ParkingSpotRepository(ParkingManagerDbContext dbContext) : base(dbContext)
    {
    }
}