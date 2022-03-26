using AutoMapper;
using ParkingManager.DataLayer.Core.Mapper.Profiles;

namespace ParkingManager.DataLayer.Core.Mapper;

public static class ParkingManagerMapper
{
    public static IMapper Mapper;

    public static void Configure()
    {
        var config = new MapperConfiguration((cfg) =>
        {
            cfg.AddProfile<ParkingLotProfile>();
            cfg.AddProfile<ParkingSpotProfile>();
        });

        Mapper = config.CreateMapper();
    }
}