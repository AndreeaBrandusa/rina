using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace rina.Entities
{
    public class Station
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public string? RouteId { get; set; }

        public Route? Route { get; set; }
    }
}
