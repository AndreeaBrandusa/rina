using rina.Models.Route;

namespace rina.Services
{
    public interface IRouteService
    {
        Task<bool> AddRouteAsync(RouteModel model);
    }
}
