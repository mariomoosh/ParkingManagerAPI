namespace ParkingManager.DataLayer.DTO
{
    public class ParkingSpotsDto
    {
        public int ParkingLot { get; set; }
        public string Spot { get; set; }        
        public bool Empty { get; set; }
        public DateTime? OccupiedDateTime { get; set; }
    }
}