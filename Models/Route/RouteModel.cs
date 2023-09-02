using rina.Models.Station;

namespace rina.Models.Route
{
    public class RouteModel
    {
        public string RouteId { get; set; }
        public string VehicleId { get; set; }
        public List<StationModel> Stations { get; set; }
    }
}
