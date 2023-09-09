using Microsoft.EntityFrameworkCore;
using rina.Data;
using rina.Entities;
using rina.Models.Station;
using rina.Utils;

namespace rina.Services
{
    public class StationService : IStationService
    {
        private readonly ApplicationDbContext _context;

        public StationService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Station> GetStationByIdAsync(string stationId)
        {
            return ConvertCoordinatesFromDatabase(await _context.Station.FirstOrDefaultAsync(x => x.Id == stationId));
        }

        public async Task<List<Station>> GetStationsAsync(string routeId)
        {
            var list = await _context.Station.Where(x => x.RouteId == routeId).ToListAsync();
            return list.Select(x => ConvertCoordinatesFromDatabase(x)).ToList();
        }

        public async Task<bool> AddStationAsync(StationModel model)
        {
            if (model is null) 
                return false;

            // generate stationId 
            string stationId = Guid.NewGuid().ToString();
            var stationEntity = ConvertCoordinatesForDatabase(model);

            // set id
            stationEntity.Id = stationId;

            // add entities to database
            _context.Station.Add(stationEntity);

            return await _context.SaveAsync();
        }

        private Station ConvertCoordinatesFromDatabase(Station station)
        {
            if (station is null) 
                return new Station();

            return new Station
            {
                Id = station.Id,
                Name = station.Name,
                RouteId = station.RouteId,
                Latitude = DecimalConverter.ConvertFromDatabase(station.Latitude),
                Longitude = DecimalConverter.ConvertFromDatabase(station.Longitude)
            };
        }

        private Station ConvertCoordinatesForDatabase(StationModel model)
        {
            if (model is null) 
                return new Station();

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
