using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingManager.DataLayer.DataAccess.Entities
{
    [Table("parking_spots",Schema ="dbo")]
    public class ParkingSpots
    {        
        [Column("parking_lot")]
        public int ParkingLot { get; set; }
        public string Spot { get; set; }
        public bool Empty { get; set; }
        [Column("occupied_datetime")]
        public DateTime? OccupiedDateTime { get; set; }
    }
}
