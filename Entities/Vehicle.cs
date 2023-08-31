using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace rina.Entities
{
    public class Vehicle
    {
        public string VehicleId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public ICollection<Route> Routes { get; set; }
        public ICollection<VehicleDriver> VehicleDrivers { get; set; }
    }
}
