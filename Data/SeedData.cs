using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace rina.Data
{
    public class SeedData
    {
        public static async Task EnsureSeedData(WebApplication app)
        {
            using (var scope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var roleManager = scope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
                await EnsureSeedData(roleManager);
            }
        }

        private static async Task EnsureSeedData(RoleManager<IdentityRole> roleManager)
        {
            if(!await roleManager.Roles.AnyAsync())
            {
                var rolesToSeed = new List<string> { "Administrator", "Driver", "User" };
                rolesToSeed.ForEach(async roleName => 
                    await roleManager.CreateAsync(new IdentityRole { Name = roleName }));
            }
        }
    }
}
