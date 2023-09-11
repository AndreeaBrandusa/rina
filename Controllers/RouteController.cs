using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using rina.Models.Route;
using rina.Services;

namespace rina.Controllers
{
    
    public class RouteController : Controller
    {
        private readonly IRouteService _routeService;
        private readonly IVehicleService _vehicleService;

        public RouteController(IRouteService stationService , IVehicleService vehicleService)
        {
            _routeService = stationService;
            _vehicleService = vehicleService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetRouteByVehicleName(string vehicleName)
        {
            var route = _routeService.GetRouteByVehicleName(vehicleName);

            if (route != null)
            {
                return Ok(route);
            }
            else
            {
                return NotFound($"Route with vehicle name '{vehicleName}' not found.");
            }
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult AddRoute()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> AddRoute([FromBody] RouteModel model)
        {
            if (!await _routeService.AddRouteWithStationsAsync(model))
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
