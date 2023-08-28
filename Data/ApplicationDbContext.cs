using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace rina.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            string userRoleId = Guid.NewGuid().ToString();
            string driverRoleId = Guid.NewGuid().ToString();
            string adminRoleId = Guid.NewGuid().ToString();

            #region Roles
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "User",
                NormalizedName = "USER",
                Id = userRoleId,
                ConcurrencyStamp = userRoleId
            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Driver",
                NormalizedName = "DRIVER",
                Id = driverRoleId,
                ConcurrencyStamp = driverRoleId
            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Administrator",
                NormalizedName = "ADMIN",
                Id = adminRoleId,
                ConcurrencyStamp = adminRoleId
            });
            #endregion Roles

            var adminUser = new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                UserName = "admin",
                NormalizedUserName = "ADMIN"
            };

            //set user password
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            adminUser.PasswordHash = ph.HashPassword(adminUser, "!Ab12345");

            //seed user
            builder.Entity<IdentityUser>().HasData(adminUser);

            //set user role to admin
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = adminUser.Id
            });


            var driverUser = new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "driver@gmail.com",
                EmailConfirmed = true,
                UserName = "driver",
                NormalizedUserName = "DRIVER"
            };

            //set user password
            ph = new PasswordHasher<IdentityUser>();
            driverUser.PasswordHash = ph.HashPassword(driverUser, "!Ab12345");

            //seed user
            builder.Entity<IdentityUser>().HasData(driverUser);

            //set user role to driver
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = driverRoleId,
                UserId = driverUser.Id
            });


            var defaultUser = new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "andreea@gmail.com",
                EmailConfirmed = true,
                UserName = "andreea",
                NormalizedUserName = "ANDREEA"
            };

            //set user password
            ph = new PasswordHasher<IdentityUser>();
            defaultUser.PasswordHash = ph.HashPassword(defaultUser, "!Ab12345");

            //seed user
            builder.Entity<IdentityUser>().HasData(defaultUser);

            //set user role to driver
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = userRoleId,
                UserId = defaultUser.Id
            });

            base.OnModelCreating(builder);
        }

        public async Task<bool> SaveAsync()
        {
            var changesNumber = await SaveChangesAsync();

            return changesNumber != 0;
        }
    }
}