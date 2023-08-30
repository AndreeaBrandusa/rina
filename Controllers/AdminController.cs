using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace rina.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        // GET: AdminController
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddVehicle()
        {
            return View();
        }

        public IActionResult AddStation()
        {
            return View();
        }

        public IActionResult AddRoute()
        {
            return View();
        }


        public IActionResult AddAccount()
        {
            return View();
        }
    }
}
