using Microsoft.EntityFrameworkCore;
using rina.Data;
using rina.Entities;
using rina.Models.Route;
using rina.Models.Station;
using rina.Utils;

namespace rina.Services
{
    public class RouteService : IRouteService
    {
        private readonly ApplicationDbContext _context;

        public RouteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Entities.Route> GetRouteById(string routeId)
        {
            return _context.Route.FirstOrDefaultAsync(x => x.RouteId == routeId);
        }

        public Entities.Route GetRouteByVehicleName(string vehicleName)
        {
            var vehicle = _context.Vehicle.FirstOrDefault(x => x.Name == vehicleName);

            Console.WriteLine(vehicleName);

            if (vehicle != null && vehicle.RouteId != null)
            {
                return _context.Route.FirstOrDefault(x => x.RouteId == vehicle.RouteId);
            }
            return null;
        }

        public async Task<List<Entities.Route>> GetRoutes()
        {
            return await _context.Route.ToListAsync();
        }

        public async Task<bool> AddRouteWithStationsAsync(RouteModel routeModel)
        {
            if (routeModel == null || routeModel.Stations == null || routeModel.Stations.Count == 0) return false;

            // generate routeId 
            string routeId = Guid.NewGuid().ToString();
            // set id
            var routeEntity = new Entities.Route
            {
                RouteId = routeId,
                VehicleId = routeModel.VehicleId,
                Stations = new List<Station>()
            };
            _context.Route.Add(routeEntity);


            // Iterate through the list of station models
            foreach (var stationModel in routeModel.Stations)
            {
                var stationEntity = ConvertCoordinatesForDatabase(stationModel);

                string stationId = Guid.NewGuid().ToString();
                stationEntity.Id = stationId;

                // Add the station entity to the database
                _context.Station.Add(stationEntity);
                // Add the station to the route's list of stations
                routeEntity.Stations.Add(stationEntity);
            }

            return await _context.SaveAsync();
        }

        private Station ConvertCoordinatesForDatabase(StationModel model)
        {
            if (model is null) return new Station();

            return new Station
            {
                Name = model.Name,
                RouteId = model.RouteId,
                Latitude = DecimalConverter.ConvertForDatabase(model.Latitude),
                Longitude = DecimalConverter.ConvertForDatabase(model.Longitude)
            };
        }
    }
}
