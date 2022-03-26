using AutoMapper;
using ParkingManager.DataLayer.DataAccess;
using ParkingManager.DataLayer.DataAccess.Entities;
using ParkingManager.DataLayer.DataAccess.Repositories;
using ParkingManager.DataLayer.DTO;

namespace ParkingManager.DataLayer.Services;

public class ParkingLotsServices
{
    private readonly IRepository<ParkingLots> _parkingLotRepository;
    private readonly IMapper _mapper;

    public ParkingLotsServices(ParkingManagerDbContext dbContext,IMapper mapper)
    {
        _parkingLotRepository = new ParkingLotRepository(dbContext);
        _mapper = mapper;
    }

    public List<ParkingLotsDto> GetAll()
    {
        var list = _parkingLotRepository.GetAll();
        return _mapper.Map<List<ParkingLotsDto>>(list);
    }
}