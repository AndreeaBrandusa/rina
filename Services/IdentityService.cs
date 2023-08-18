using rina.Data;
using rina.Models;
using rina.Models.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace rina.Services
{
    public class IdentityService
    {
        private ApplicationDbContext _context;
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;
        private IConfiguration _configuration;

        public IdentityService(ApplicationDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IConfiguration configuration)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        public async Task<AuthenticationResult> LoginAsync(LoginModel model)
        {
            if (!ValidateLoginModel(model))
            {
                // invalid model
                return new AuthenticationResult();
            }

            // log in
            return await AuthenticateAsync(model);
        }

        public async Task<AuthenticationResult> RegisterAsync(RegisterModel model)
        {
            if (!ValidateRegisterModel(model))
            {
                // invalid model
                return new AuthenticationResult();
            }

            if (!await CanRegister(model.Username, model.Email))
            {
                return new AuthenticationResult();
            }

            if (!await RegisterAccountAsync(model))
            {
                // unable to register account
                return new AuthenticationResult();
            }

            // log in
            return await AuthenticateAsync(RegisterModelToLoginModel(model));
        }

        private bool ValidateLoginModel(LoginModel model)
        {
            if (model == null)
            {
                // invalid data
                return false;
            }

            if (string.IsNullOrEmpty(model.Username) || string.IsNullOrEmpty(model.Password))
            {
                // invalid data
                return false;
            }

            // valid data
            return true;
        }

        private bool ValidateRegisterModel(RegisterModel model)
        {
            if (model == null)
            {
                // invalid data
                return false;
            }

            if (string.IsNullOrEmpty(model.Username) || string.IsNullOrEmpty(model.Password) || string.IsNullOrEmpty(model.Email))
            {
                // invalid data
                return false;
            }

            // valid data
            return true;
        }

        private async Task<AuthenticationResult> AuthenticateAsync(LoginModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);

            /*
            if (user == null)
            {
                return new AuthenticationResult();
            }

            if (await _userManager.CheckPasswordAsync(user, model.Password) == true)
            {
                return new AuthenticationResult();
            }

            if (await _userManager.CheckPasswordAsync(user, model.Password) == false)
            {
                // wrong password
                return new AuthenticationResult();
            }
            */

            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var authClaims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, model.Username),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim("id", user.Id)
                };

                var identity = new ClaimsIdentity(authClaims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true
                };

                await _signInManager.SignInAsync(user, true);

                return new AuthenticationResult()
                {
                    Success = true,
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    Principal = principal,
                    AuthProperties = authProperties
                };
            }

            return new AuthenticationResult();
        }

        private async Task<bool> RegisterAccountAsync(RegisterModel model)
        {
            var result = await _userManager.CreateAsync(RegisterModelToIdentityUser(model), model.Password);

            Console.WriteLine(result.Errors);

            return result.Succeeded;
        }

        private async Task<bool> CanRegister(string username, string email)
        {
            if ((await _userManager.FindByNameAsync(username)) != null)
            {
                // there is an user with this username
                return false;
            }

            if ((await _userManager.FindByEmailAsync(email)) != null)
            {
                // there is an user with this email
                return false;
            }

            // there is no user with those credentials
            return true;
        }

        private IdentityUser RegisterModelToIdentityUser(RegisterModel model)
        {
            return new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = model.Username,
                Email = model.Email
            };
        }

        private LoginModel RegisterModelToLoginModel(RegisterModel model)
        {
            return new LoginModel
            {
                Username = model.Username,
                Password = model.Password
            };
        }
    }
}
