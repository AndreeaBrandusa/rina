using Microsoft.AspNetCore.Identity;

namespace rina.Entities
{
    public class VehicleDriver
    {
        public string Id { get; set; }
        public string VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        public string DriverId;
        public ApplicationUser Driver { get; set; }
    }
}
