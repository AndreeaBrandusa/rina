namespace rina.Entities
{
    public class Station
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Coordinates { get; set; }
        public ICollection<Route> Routes { get; set; }
    }
}
