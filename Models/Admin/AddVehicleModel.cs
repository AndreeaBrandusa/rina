namespace rina.Models.Admin
{
    public class AddVehicleModel
    {
        public string? Name { get; set; }
        public List<AddStationModel>? Stations { get; set; }
    }
}
