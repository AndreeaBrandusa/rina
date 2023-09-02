using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using rina.Models.Station;
using rina.Services;

namespace rina.Controllers
{
    [Authorize(Roles = "Administrator")]
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

        public async Task<IActionResult> Stations(string routeId)
        {
            return new OkObjectResult(await _stationService.GetStationsAsync(routeId));
        }

        public IActionResult AddStation()
        {
            return View();
        }


        [HttpPost]
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
