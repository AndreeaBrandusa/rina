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

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddVehicle()
        {
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
