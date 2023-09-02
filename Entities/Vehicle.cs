using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rina.Entities
{
    public class Vehicle
    {
        public string VehicleId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Latitude { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Longitude { get; set; }

        public VehicleDriver VehicleDriver { get; set; }
        public ICollection<Route> Routes { get; set; }
    }
}
