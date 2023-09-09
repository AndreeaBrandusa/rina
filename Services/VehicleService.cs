using Microsoft.EntityFrameworkCore;
using rina.Data;
using rina.Entities;
using rina.Models.Vehicle;
using rina.Utils;

namespace rina.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly ApplicationDbContext _context;

        public VehicleService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddVehicleAsync(VehicleModel vehicleModel)
        {
            if (vehicleModel is null) 
                return false;

            // generate vehicleId 
            string vehicleId = Guid.NewGuid().ToString();
            var vehicleEntity = ConvertCoordinatesForDatabase(vehicleModel);

            // set id
            vehicleEntity.VehicleId = vehicleId;
            // add entities to database
            _context.Vehicle.Add(vehicleEntity);

            // add route for vehicle to db
            var route = _context.Route.FirstOrDefault(x => x.RouteId == vehicleModel.RouteId);
            if (route != null)
            {
                route.VehicleId = vehicleId;
                _context.Route.Update(route);
            }

            return await _context.SaveAsync();
        }

        private Vehicle ConvertCoordinatesForDatabase(VehicleModel model)
        {
            if (model is null)
                return new Vehicle();

            return new Vehicle
            {
                Name = model.Name,
                Type = model.Type,
                Latitude = DecimalConverter.ConvertForDatabase(model.Latitude),
                Longitude = DecimalConverter.ConvertForDatabase(model.Longitude),
                RouteId = model.RouteId
            };
        }
    }
}
