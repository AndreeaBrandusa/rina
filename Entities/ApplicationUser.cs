using Microsoft.AspNetCore.Identity;

namespace rina.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public VehicleDriver VehicleDriver { get; set; }
    }
}
