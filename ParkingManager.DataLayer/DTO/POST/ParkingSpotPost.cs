using System.ComponentModel.DataAnnotations;

namespace ParkingManager.DataLayer.DTO.POST
{
    public class ParkingSpotPost
    {
        [Required]
        public int ParkingLot { get; set; }
        [Required]
        public string Spot { get; set; }
        [Required]
        public bool Empty { get; set; }
        
        public DateTime? OccupiedDateTime { get; set; }
    }
}
