using ParkingManager.DataLayer.DataAccess.Entities;

namespace ParkingManager.DataLayer.DataAccess.Repositories;

public class ParkingLotRepository: BaseRepository<ParkingManagerDbContext,ParkingLots>,IRepository<ParkingLots>
{
    public ParkingLotRepository(ParkingManagerDbContext dbContext) : base(dbContext)
    {
    }
}