using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingManager.DataLayer.DataAccess.Entities
{
    [Table("parking_lots",Schema ="dbo")]
    public class ParkingLots
    {
        [Column("lot_id")]
        public int LotId { get; set; }
        [Column("lot_name")]
        public string LotName { get; set; }
    }
}
