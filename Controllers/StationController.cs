using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using rina.Models.Station;
using rina.Services;

namespace rina.Controllers
{
    public class StationController : Controller
    {
        private readonly IStationService _stationService;

        public StationController(IStationService stationService)
        {
            _stationService = stationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Driver")]
        public async Task<IActionResult> GetStations(string routeId)
        {
            return new OkObjectResult(await _stationService.GetStationsAsync(routeId));
        }


        [Authorize(Roles = "User")]
        public async Task<IActionResult> GetStationsForUser(string routeId)
        {
            return new OkObjectResult(await _stationService.GetStationsAsync(routeId));
        }


        [Authorize(Roles = "Administrator")]
        public IActionResult AddStation()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> AddStation(StationModel model)
        {
            if (!await _stationService.AddStationAsync(model))
            {
                return RedirectToAction("Index", "Home"); 
            }
            return View();
        }
    }
}
