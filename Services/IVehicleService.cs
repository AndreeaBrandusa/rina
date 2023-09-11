using rina.Entities;
using rina.Models.Vehicle;

namespace rina.Services
{
    public interface IVehicleService
    {
        Task<List<Entities.Route>> GetVehicles();
        Task<bool> AddVehicleAsync(VehicleModel model);
        //Task<Vehicle> GetVehicleById(string vehicleId);
    }
}
