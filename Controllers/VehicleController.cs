using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using rina.Models.Vehicle;
using rina.Services;

namespace rina.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class VehicleController : Controller
    {
        private readonly IVehicleService _vehicleService;
        private readonly IRouteService _routeService;
        private readonly IStationService _stationService;

        public VehicleController(IVehicleService vehicleService, IRouteService routeService, IStationService stationService)
        {
            _vehicleService = vehicleService;
            _routeService = routeService;
            _stationService = stationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddVehicle()
        {
            var routes = await _routeService.GetRoutes();
            var stations = new Dictionary<string, (Entities.Station, Entities.Station)>();

            foreach(var route in routes)
            {
                var tmp = await _stationService.GetStationsAsync(route.RouteId);

                // check if list is empty
                if (tmp.Count == 0) continue;

                var firstStation = tmp[0];
                var lastStation = tmp[tmp.Count - 1];

                stations.Add(route.RouteId, (firstStation, lastStation));
            }

            var model = new AddVehicleModel
            {
                Routes = stations
            };
            ViewData["model"] = model;

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddVehicle(VehicleModel model)
        {
            if (!await _vehicleService.AddVehicleAsync(model))
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
