﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using rina.Entities;

namespace rina.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Entities.Route> Route { get; set; }
        public DbSet<Station> Station { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<VehicleDriver> VehicleDriver { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        


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

            #region Add Admin Account
            var adminUser = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                UserName = "admin",
                NormalizedUserName = "ADMIN"
            };

            //set user password
            PasswordHasher<ApplicationUser> ph = new PasswordHasher<ApplicationUser>();
            adminUser.PasswordHash = ph.HashPassword(adminUser, "!Ab12345");

            //seed user
            builder.Entity<ApplicationUser>().HasData(adminUser);

            //set user role to admin
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = adminUser.Id
            });
            #endregion Add Admin Account

            #region Add Driver Account
            var driverUser = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "driver@gmail.com",
                EmailConfirmed = true,
                UserName = "driver",
                NormalizedUserName = "DRIVER"
            };

            //set user password
            ph = new PasswordHasher<ApplicationUser>();
            driverUser.PasswordHash = ph.HashPassword(driverUser, "!Ab12345");

            //seed user
            builder.Entity<ApplicationUser>().HasData(driverUser);

            //set user role to driver
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = driverRoleId,
                UserId = driverUser.Id
            });
            #endregion Add Driver Account

            #region Add User Account
            var defaultUser = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "andreea@gmail.com",
                EmailConfirmed = true,
                UserName = "andreea",
                NormalizedUserName = "ANDREEA"
            };

            //set user password
            ph = new PasswordHasher<ApplicationUser>();
            defaultUser.PasswordHash = ph.HashPassword(defaultUser, "!Ab12345");

            //seed user
            builder.Entity<ApplicationUser>().HasData(defaultUser);

            //set user role to default user
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = userRoleId,
                UserId = defaultUser.Id
            });
            #endregion Add User Account


            base.OnModelCreating(builder);
            builder.Entity<Entities.Route>()
                .HasKey(x => x.RouteId);
            builder.Entity<Entities.Route>()
                .HasOne(x => x.Vehicle)
                .WithMany(x => x.Routes)
                .HasForeignKey(x => x.VehicleId);
            builder.Entity<Entities.Route>()
                .HasMany(x => x.Stations)
                .WithMany(x => x.Routes);


            builder.Entity<Station>()
                .HasKey(x => x.Id);
            builder.Entity<Station>()
                .HasMany(x => x.Routes)
                .WithMany(x => x.Stations);


            builder.Entity<Vehicle>()
                .HasKey(x => x.VehicleId);
            builder.Entity<Vehicle>()
                .HasMany(x => x.Routes)
                .WithOne(x => x.Vehicle)
                .HasForeignKey(x => x.VehicleId);


            builder.Entity<VehicleDriver>()
                .HasKey(x => new { x.Id, x.VehicleId, x.DriverId });
            builder.Entity<VehicleDriver>()
                .HasOne(x => x.Vehicle)
                .WithMany(x => x.VehicleDrivers)
                .HasForeignKey(x => x.VehicleId);
            builder.Entity<VehicleDriver>()
                .HasOne(x => x.Driver)
                .WithMany()
                .HasForeignKey(x => x.DriverId);


            builder.Entity<ApplicationUser>()
                .HasOne(x => x.VehicleDriver)
                .WithOne(x => x.Driver)
                .HasForeignKey<VehicleDriver>(x => x.DriverId);
        }

        public async Task<bool> SaveAsync()
        {
            var changesNumber = await SaveChangesAsync();

            return changesNumber != 0;
        }
    }
}