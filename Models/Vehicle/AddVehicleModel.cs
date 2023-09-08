namespace rina.Models.Vehicle
{
    public class AddVehicleModel
    {
        public List<Entities.Vehicle> Vehicles { get; set; }
        public Dictionary<string, (Entities.Station, Entities.Station)> Routes { get; set; } 
    }
}
