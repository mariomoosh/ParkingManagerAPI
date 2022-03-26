using Microsoft.AspNetCore.Mvc;
using ParkingManager.DataLayer.Services;

namespace ParkingManagerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParkingSpotController : Controller
    {
        private readonly ParkingSpotsServices _spotsServices;

        public ParkingSpotController(ParkingSpotsServices spotsServices)
        {
            _spotsServices = spotsServices;
        }

        [HttpGet]
        public IActionResult Get(int lotId)
        {
            try
            {
                var spots = _spotsServices.GetAll(lotId);
                return Ok(spots);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return BadRequest("Error while fetching data");
            }
        }

        
    }
}
