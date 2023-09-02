using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using rina.Models.Route;
using rina.Services;

namespace rina.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class RouteController : Controller
    {
        private readonly IRouteService _routeService;

        public RouteController(IRouteService stationService)
        {
            _routeService = stationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddRoute()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRoute(RouteModel model)
        {
            if (!await _routeService.AddRouteAsync(model))
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
