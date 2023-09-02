using System.ComponentModel.DataAnnotations.Schema;

namespace rina.Entities
{
    public class Station
    {
        public string Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Latitude { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Longitude { get; set; }

        public string RouteId { get; set; }

        public Route Route { get; set; }
    }
}
