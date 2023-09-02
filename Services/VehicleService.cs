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

        public async Task<bool> AddVehicleAsync(VehicleModel model)
        {
            if (model is null) return false;

            // generate vehicleId 
            string vehicleId = Guid.NewGuid().ToString();
            var vehicleEntity = ConvertCoordinatesForDatabase(model);

            // set id
            vehicleEntity.VehicleId = vehicleId;

            // add entities to database
            _context.Vehicle.Add(vehicleEntity);

            return await _context.SaveAsync();
        }

        private Vehicle ConvertCoordinatesForDatabase(VehicleModel model)
        {
            return new Vehicle
            {
                Name = model.Name,
                Type = model.Type,
                Latitude = DecimalConverter.ConvertForDatabase(model.Latitude),
                Longitude = DecimalConverter.ConvertForDatabase(model.Longitude)
            };
        }
    }
}
