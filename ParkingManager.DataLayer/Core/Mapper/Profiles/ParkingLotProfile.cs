using AutoMapper;
using ParkingManager.DataLayer.DataAccess.Entities;
using ParkingManager.DataLayer.DTO;

namespace ParkingManager.DataLayer.Core.Mapper.Profiles;

public class ParkingLotProfile:Profile
{
    public ParkingLotProfile()
    {
        EntityToDto();
    }

    

    private void EntityToDto()
    {
        CreateMap<ParkingLots, ParkingLotsDto?>()
            .ConstructUsing((s) => GetParkingLotFromEntity(s))
            .ForAllMembers(o => o.Ignore());
    }

    private ParkingLotsDto? GetParkingLotFromEntity(ParkingLots? s)
        => s == null
            ? null
            : new ParkingLotsDto
            {
                LotId = s.LotId,
                LotName = s.LotName
            };
}