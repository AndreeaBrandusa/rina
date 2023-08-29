using Microsoft.AspNetCore.Identity;

namespace rina.Entities
{
    public class Vehicle
    {
        public string VehicleId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public ICollection<Route> Routes { get; set; }
    }
}
