using Microsoft.AspNetCore.Identity;

namespace rina.Entities
{
    public class VehicleDriver
    {
        public string VehicleDriverId { get; set; }
        public string VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        public string DriverId { get; set; }
        public ApplicationUser Driver { get; set; }
    }
}
