using rina.Data;
using rina.Models.Route;

namespace rina.Services
{
    public class RouteService : IRouteService
    {
        private readonly ApplicationDbContext _context;

        public RouteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddRouteAsync(RouteModel model)
        {
            if (model == null) return false;

            // generate routeId 
            string routeId = Guid.NewGuid().ToString();
            // set id
            var routeEntity = new Entities.Route
            {
                RouteId = routeId,
                VehicleId = model.VehicleId
            };

            // add entities to database
            _context.Route.Add(routeEntity);

            return await _context.SaveAsync();
        }
    }
}
