using AutoMapper;
using ParkingManager.DataLayer.DataAccess;
using ParkingManager.DataLayer.DataAccess.Entities;
using ParkingManager.DataLayer.DataAccess.Repositories;
using ParkingManager.DataLayer.DTO;

namespace ParkingManager.DataLayer.Services;

public class ParkingSpotsServices
{
    private readonly IRepository<ParkingSpots> _parkingSpotsRepository;
    private readonly IMapper _mapper;

    public ParkingSpotsServices(ParkingManagerDbContext dbContext,IMapper mapper)
    {
        _mapper = mapper;
        _parkingSpotsRepository = new ParkingSpotRepository(dbContext);
    }

    public List<ParkingSpotsDto> GetAll(int lotId)
    {
        var list = _parkingSpotsRepository.Get(w=>w.ParkingLot == lotId);
        return _mapper.Map<List<ParkingSpotsDto>>(list);
    }

    public List<ParkingSpotsDto> GetByStatus(int lotId,bool empty)
    {
        var list = _parkingSpotsRepository.Get(w => w.Empty == empty && w.ParkingLot == lotId);
        return _mapper.Map<List<ParkingSpotsDto>>(list);
    }
}