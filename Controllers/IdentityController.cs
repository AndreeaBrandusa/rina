using rina.Services;
using rina.Models;
using rina.Models.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using System.Threading.Tasks;

namespace rina.Controllers
{
    public class IdentityController : Controller
    {
        private IdentityService _identityService;

        public IdentityController(IdentityService service)
        {
            _identityService = service;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var result = await _identityService.LoginAsync(model);
            if (result.Success)
            {
                await HttpContext.SignInAsync(result.Principal, result.AuthProperties);
                HttpContext.Response.Cookies.Append("jwt", result.Token);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            var result = await _identityService.RegisterAsync(model);
            if (result.Success)
            {
                await HttpContext.SignInAsync(result.Principal, result.AuthProperties);
                HttpContext.Response.Cookies.Append("jwt", result.Token);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Response.Cookies.Delete("jwt");

            return RedirectToAction("Index", "Home");
        }
    }
}
