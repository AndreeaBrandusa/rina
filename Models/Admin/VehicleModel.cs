namespace rina.Models.Admin
{
    public class VehicleModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<RouteModel> Routes { get; set; }
    }
}