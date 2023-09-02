using rina.Entities;
using rina.Models.Station;

namespace rina.Services
{
    public interface IStationService
    {
        Task<List<Station>> GetStationsAsync(string routeId);
        Task<Station> GetStationByIdAsync(string stationId);
        Task<bool> AddStationAsync(StationModel model);
    }
}
