using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace rina.Models.Identity
{
    public class AuthenticationResult
    {
        public string? Token { get; set; }
        public bool Success { get; set; }
        public ClaimsPrincipal? Principal { get; set; }
        public AuthenticationProperties? AuthProperties { get; set; }
    }
}
