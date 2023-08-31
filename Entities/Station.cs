namespace rina.Entities
{
    public class Station
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public ICollection<Route> Routes { get; set; }
    }
}
