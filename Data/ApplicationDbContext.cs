using Microsoft.AspNetCore.Identity;
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

            string driverId = Guid.NewGuid().ToString();
            var driverUser = new ApplicationUser
            {
                Id = driverId,
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


            #region Add Default Vehicle
            string vehicleId = "2253d4b4-edba-4041-a314-22968193faf2";

            builder.Entity<Vehicle>().HasData(new Vehicle
            {
                VehicleId = vehicleId,
                Name = "6",
                Type = "Tram",
                Latitude = 0,
                Longitude = 0
            });
            #endregion Add Default Vehicle

            #region Add Default VehicleDriver
            builder.Entity<VehicleDriver>().HasData(new VehicleDriver
            {
                Id = Guid.NewGuid().ToString(),
                DriverId = driverId,
                VehicleId = vehicleId
            });
            #endregion Add Default VehicleDriver

            #region Add default Routes
            string routeId = Guid.NewGuid().ToString();

            builder.Entity<Entities.Route>().HasData(new Entities.Route
            {
                RouteId = routeId,
                VehicleId = vehicleId
            });

            string reversedRouteId = Guid.NewGuid().ToString();
            builder.Entity<Entities.Route>().HasData(new Entities.Route
            {
                RouteId = reversedRouteId,
                VehicleId = vehicleId
            });
            #endregion Add default Routes

            #region Add Default Stations
            var stationsData = new Dictionary<string, (decimal, decimal)>
            {
                { "Piata Maria", (45.74827859010117m, 21.21917452835527m) },
                { "Catedrala Metropolitana", (45.75109221785382m, 21.22361857206686m) },
                { "Spitalul de copii", (45.75490769991527m, 21.221050800524303m) },
                { "Brediceanu", (45.75619701680361m, 21.221307553237732m) },
                { "Piata Timisoara 700", (45.75625163350785m, 21.222908892035374m) },
                { "Piata Libertatii", (45.75587250460832m, 21.2276939799686m) },
                { "Hotel Continental", (45.755749335261136m, 21.231858987508456m) },
                { "Prefectura Judetului Timis", (45.75562234744903m, 21.238427101113256m) },
                { "3 August 1919", (45.756721582695015m, 21.244925698896484m) },
                { "Piata Traian", (45.75749500845264m, 21.24916939645183m) },
                { "Fabrica De Bere Timisoara", (45.753010052800356m, 21.250171969257572m) },
                { "Banatim", (45.74889039428735m, 21.25270156463139m) },
                { "Deliblata", (45.74715727437089m, 21.246582097173373m) },
                { "Sala Olimpia", (45.74533430140636m, 21.241446790566474m) },
                { "Cluj", (45.74388560125414m, 21.237128709215785m) },
                { "Piata Crucii", (45.74200588120218m, 21.232466650088003m) },
                { "Piata Nicolae Balcescu", (45.741762533858214m, 21.22514596492361m) },
                { "Parc Doina", (45.744444574004696m, 21.222379518441844m) }
            };

            stationsData.Keys.ToList().ForEach(stationName =>
            {
                builder.Entity<Station>().HasData(new Entities.Station
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = stationName,
                    Latitude = stationsData[stationName].Item1,
                    Longitude = stationsData[stationName].Item2,
                    RouteId = routeId
                });
            });

            var reversedList = stationsData.Keys.ToList();
            reversedList.Reverse();

            reversedList.ForEach(stationName =>
            {
                builder.Entity<Station>().HasData(new Entities.Station
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = stationName,
                    Latitude = stationsData[stationName].Item1,
                    Longitude = stationsData[stationName].Item2,
                    RouteId = reversedRouteId
                });
            });
            #endregion Add Default Stations


            base.OnModelCreating(builder);
            builder.Entity<Entities.Route>()
                .HasKey(x => x.RouteId);
            builder.Entity<Entities.Route>()
                .HasOne(x => x.Vehicle)
                .WithMany(x => x.Routes)
                .HasForeignKey(x => x.VehicleId);


            builder.Entity<Station>()
                .HasKey(x => x.Id);
            builder.Entity<Station>()
                .HasOne(x => x.Route)
                .WithMany(x => x.Stations)
                .HasForeignKey(x => x.RouteId);


            builder.Entity<Vehicle>()
                .HasKey(x => x.VehicleId);
            builder.Entity<Vehicle>()
                .HasOne(x => x.VehicleDriver)
                .WithOne(x => x.Vehicle)
                .HasForeignKey<VehicleDriver>(x => x.VehicleId);

            builder.Entity<VehicleDriver>()
                .HasKey(x => x.Id);


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