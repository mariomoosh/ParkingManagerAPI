using Microsoft.AspNetCore.Mvc;
using ParkingManager.DataLayer.Services;

namespace ParkingManagerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParkingLotController : Controller
    {
        private readonly ParkingLotsServices _parkingLotsServices;

        public ParkingLotController(ParkingLotsServices parkingLotsServices)
        {
            _parkingLotsServices = parkingLotsServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var lots = _parkingLotsServices.GetAll();
                return Ok(lots);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return BadRequest("Error while fetching data");
            }
        }
    }
}
