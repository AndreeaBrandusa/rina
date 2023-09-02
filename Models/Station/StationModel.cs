namespace rina.Models.Station
{
    public class StationModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public string RouteId { get; set; }
    }
}
