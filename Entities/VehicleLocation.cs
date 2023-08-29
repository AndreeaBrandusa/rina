namespace rina.Entities
{
    public class VehicleLocation
    {
        public int LocationId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Coordinates { get; set; }
        public Route Route { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
