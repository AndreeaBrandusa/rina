namespace rina.Models.Vehicle
{
    public class VehicleModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public string RouteId { get; set; }
    }
}