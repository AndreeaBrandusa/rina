using rina.Data;
using rina.Models;
using rina.Entities;
using rina.Models.Identity;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace rina.Services
{
    public class IdentityService
    {
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private IConfiguration _configuration;

        public IdentityService(
            ApplicationDbContext context, 
            UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager,
            IConfiguration configuration)
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

            if (!await RegisterUserAccountAsync(model))
            {
                // unable to register account
                return new AuthenticationResult();
            }

            // log in
            return await AuthenticateAsync(RegisterModelToLoginModel(model));
        }

        public async Task<AuthenticationResult> CreateAccountAsync(RegisterModel model)
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

            // account created
            return new AuthenticationResult
            {
                Success = true
            };
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
            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var authClaims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, model.Username),
                    //new Claim(ClaimTypes.Role, "User"),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim("id", user.Id)
                };

                var roles = await _userManager.GetRolesAsync(user);
                foreach (var role in roles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, role));
                }

                var hasRole = await _userManager.GetRolesAsync(user);
                if (hasRole.Count == 0)
                {
                    await _userManager.AddToRoleAsync(user, "User");
                }

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

            var user = await _userManager.FindByNameAsync(model.Username);
            await _userManager.AddToRoleAsync(user, model.Role);

            Console.WriteLine(result.Errors);

            return result.Succeeded;
        }


        private async Task<bool> RegisterUserAccountAsync(RegisterModel model)
        {
            var result = await _userManager.CreateAsync(RegisterModelToIdentityUser(model), model.Password);
            var user = await _userManager.FindByNameAsync(model.Username);
            var hasRole = await _userManager.GetRolesAsync(user);

            if (hasRole.Count == 0)
            {
                await _userManager.AddToRoleAsync(user, "User");
            }

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

        private ApplicationUser RegisterModelToIdentityUser(RegisterModel model)
        {
            return new ApplicationUser
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
