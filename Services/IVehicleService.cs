using rina.Models.Vehicle;

namespace rina.Services
{
    public interface IVehicleService
    {
        Task<bool> AddVehicleAsync(VehicleModel model);
    }
}
