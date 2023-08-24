using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace rina.Controllers
{
    public class AdminController : Controller
    {
        // GET: AdminController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddVehicle()
        {
            return View();
        }

        public ActionResult AddStation()
        {
            return View();
        }

        public ActionResult AddAccount()
        {
            return View();
        }
    }
}
