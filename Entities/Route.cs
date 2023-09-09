namespace rina.Entities
{
    public class Route
    {
        public string RouteId { get; set; }

        public string? VehicleId { get; set; }
        public Vehicle? Vehicle { get; set; }

        public ICollection<Station> Stations { get; set; }
    }
}
