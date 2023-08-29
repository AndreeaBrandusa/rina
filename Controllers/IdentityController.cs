using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using rina.Models;
using rina.Models.Identity;
using rina.Services;

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
            if (HttpContext.Request.Cookies.Count > 0)
            {
                var siteCookies = HttpContext.Request.Cookies.Where(c => 
                    c.Key.Contains(".AspNetCore.") || 
                    c.Key.Contains("Microsoft.Authentication"));

                foreach (var cookie in siteCookies)
                {
                    Response.Cookies.Delete(cookie.Key);
                }
            }
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult AddAccount()
        {
            return View();
        }

        public async Task<IActionResult> AddNewAccount(RegisterModel model)
        {
            var result = await _identityService.CreateAccountAsync(model);
            if (result.Success)
            {
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction(nameof(AddAccount), "Identity");
        }
    }
}
