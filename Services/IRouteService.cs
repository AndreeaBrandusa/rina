using rina.Models.Route;

namespace rina.Services
{
    public interface IRouteService
    {
        Task<List<Entities.Route>> GetRoutes();
        Task<bool> AddRouteWithStationsAsync(RouteModel model);
        Entities.Route GetRouteByVehicleName(string vehicleName);
    }
}
