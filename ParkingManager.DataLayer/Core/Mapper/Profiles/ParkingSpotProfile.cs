using AutoMapper;
using ParkingManager.DataLayer.DataAccess.Entities;
using ParkingManager.DataLayer.DTO;
using ParkingManager.DataLayer.DTO.POST;

namespace ParkingManager.DataLayer.Core.Mapper.Profiles;

public class ParkingSpotProfile:Profile
{
    public ParkingSpotProfile()
    {
        EntityToDto();
        PostToEntity();
    }
    private void PostToEntity()
    {
        CreateMap<ParkingSpotPost, ParkingSpots?>()
            .ConstructUsing((s) => GetParkingSpotFromPost(s))
            .ForAllMembers(o => o.Ignore());
    }

    private void EntityToDto()
    {
        CreateMap<ParkingSpots, ParkingSpotsDto?>()
            .ConstructUsing((s) => GetParkingSpotFromEntity(s))
            .ForAllMembers(o => o.Ignore());
    }

    private ParkingSpotsDto? GetParkingSpotFromEntity(ParkingSpots? s)
        => s == null
            ? null
            : new ParkingSpotsDto
            {
                ParkingLot = s.ParkingLot,
                Spot = s.Spot,
                Empty = s.Empty,
                OccupiedDateTime = s.OccupiedDateTime
            };

    private ParkingSpots? GetParkingSpotFromPost(ParkingSpotPost? s)
        => s == null
            ? null
            : new ParkingSpots
            {
                ParkingLot = s.ParkingLot,
                Spot = s.Spot,
                Empty = s.Empty,
                OccupiedDateTime = DateTime.Now
            };
}