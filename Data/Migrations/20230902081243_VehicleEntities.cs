using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rina.Data.Migrations
{
    public partial class VehicleEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3739c010-dd90-4e82-a996-790327db124e", "447d1146-c58c-4d86-a1e7-6150cefe081a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b988814d-9525-44c6-8c7a-3120f4c87a2c", "8bcf4da1-e7af-44f7-9c5c-759879c434eb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7dd8ebc4-f11c-4475-bcb4-fa54474c3099", "f4cf2901-eba8-47bb-86c1-f4cfafff82f4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3739c010-dd90-4e82-a996-790327db124e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dd8ebc4-f11c-4475-bcb4-fa54474c3099");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b988814d-9525-44c6-8c7a-3120f4c87a2c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "447d1146-c58c-4d86-a1e7-6150cefe081a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8bcf4da1-e7af-44f7-9c5c-759879c434eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4cf2901-eba8-47bb-86c1-f4cfafff82f4");

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    VehicleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.VehicleId);
                });

            migrationBuilder.CreateTable(
                name: "Route",
                columns: table => new
                {
                    RouteId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VehicleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route", x => x.RouteId);
                    table.ForeignKey(
                        name: "FK_Route_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleDriver",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DriverId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VehicleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleDriver", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleDriver_AspNetUsers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleDriver_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Station",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RouteId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Station", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Station_Route_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Route",
                        principalColumn: "RouteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ca8ff32-bf41-412a-8e29-dfe3418f7e44", "0ca8ff32-bf41-412a-8e29-dfe3418f7e44", "Administrator", "ADMIN" },
                    { "59769cbf-408b-44dd-b7d0-cca2ed6b23e6", "59769cbf-408b-44dd-b7d0-cca2ed6b23e6", "User", "USER" },
                    { "75849602-3bb2-478b-abdf-a3a049477e9b", "75849602-3bb2-478b-abdf-a3a049477e9b", "Driver", "DRIVER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3caa1258-5785-4303-a61b-1ba9eb0aaeff", 0, "f6cec787-3185-4096-9d18-6ede38ffdacb", "admin@gmail.com", true, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEBa6wLhLdyaJZU+rfgiXU5d1URgZqIl8nUmpVhInOkwrzUcAf5+ULJQn4OeDxy+OHA==", null, false, "2dc07668-7160-40e5-80a5-dec37342ea98", false, "admin" },
                    { "49d8fc0c-e911-49d0-a867-39a168c0b905", 0, "3118efe8-bee7-41ad-9e8d-260054369121", "andreea@gmail.com", true, false, null, null, "ANDREEA", "AQAAAAEAACcQAAAAEJrvhpYsMpCJ95Sjowt+l8b0r8AcmqwYmw8LYn6iWzNCIyjXL5A5L4T7IypstU1sSg==", null, false, "3d47635a-fd1d-4b67-8a52-f146863d8029", false, "andreea" },
                    { "dbb3db27-c571-4195-8357-5a46bb035705", 0, "0da54a49-c828-491e-abad-e8ebee40ef58", "driver@gmail.com", true, false, null, null, "DRIVER", "AQAAAAEAACcQAAAAEMfEh4TkiBgt0nLl9d3tF2P5crc6eA1BSqfgqUEi1wWaSsdNYsvZrIQaXkAoNtzL1A==", null, false, "33dde459-f773-4d08-8731-dcfdd10cac85", false, "driver" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0ca8ff32-bf41-412a-8e29-dfe3418f7e44", "3caa1258-5785-4303-a61b-1ba9eb0aaeff" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "59769cbf-408b-44dd-b7d0-cca2ed6b23e6", "49d8fc0c-e911-49d0-a867-39a168c0b905" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "75849602-3bb2-478b-abdf-a3a049477e9b", "dbb3db27-c571-4195-8357-5a46bb035705" });

            migrationBuilder.CreateIndex(
                name: "IX_Route_VehicleId",
                table: "Route",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Station_RouteId",
                table: "Station",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDriver_DriverId",
                table: "VehicleDriver",
                column: "DriverId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDriver_VehicleId",
                table: "VehicleDriver",
                column: "VehicleId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Station");

            migrationBuilder.DropTable(
                name: "VehicleDriver");

            migrationBuilder.DropTable(
                name: "Route");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0ca8ff32-bf41-412a-8e29-dfe3418f7e44", "3caa1258-5785-4303-a61b-1ba9eb0aaeff" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "59769cbf-408b-44dd-b7d0-cca2ed6b23e6", "49d8fc0c-e911-49d0-a867-39a168c0b905" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "75849602-3bb2-478b-abdf-a3a049477e9b", "dbb3db27-c571-4195-8357-5a46bb035705" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ca8ff32-bf41-412a-8e29-dfe3418f7e44");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59769cbf-408b-44dd-b7d0-cca2ed6b23e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75849602-3bb2-478b-abdf-a3a049477e9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3caa1258-5785-4303-a61b-1ba9eb0aaeff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49d8fc0c-e911-49d0-a867-39a168c0b905");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbb3db27-c571-4195-8357-5a46bb035705");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3739c010-dd90-4e82-a996-790327db124e", "3739c010-dd90-4e82-a996-790327db124e", "Driver", "DRIVER" },
                    { "7dd8ebc4-f11c-4475-bcb4-fa54474c3099", "7dd8ebc4-f11c-4475-bcb4-fa54474c3099", "Administrator", "ADMIN" },
                    { "b988814d-9525-44c6-8c7a-3120f4c87a2c", "b988814d-9525-44c6-8c7a-3120f4c87a2c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "447d1146-c58c-4d86-a1e7-6150cefe081a", 0, "afc8977c-4e1a-4ff0-88f4-e253b41e1431", "driver@gmail.com", true, false, null, null, "DRIVER", "AQAAAAEAACcQAAAAEG0xh9XiApdNmyso1dJbMss5fpoZlSJ1mSCZimSS90bbQ5q92vMvbcFfAd6OyO15cw==", null, false, "d01467eb-452b-4807-9106-4b25303f0c07", false, "driver" },
                    { "8bcf4da1-e7af-44f7-9c5c-759879c434eb", 0, "d1d80d67-ebbe-4d75-bb88-f27540e324d1", "andreea@gmail.com", true, false, null, null, "ANDREEA", "AQAAAAEAACcQAAAAENaiJ8OdJ9rpJtnmSGZ679rl1Ab3PDMl2ULyMH56HlCE1D966UkrB8xJhKeEdK4rnw==", null, false, "38f1a853-1520-4361-8aea-a1b953438618", false, "andreea" },
                    { "f4cf2901-eba8-47bb-86c1-f4cfafff82f4", 0, "edaa0254-c775-467b-90e8-986648900257", "admin@gmail.com", true, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEAZya40U1ikg8pbiKsZvbiv0+Fa3Y/8K/G/dX/hLqCQt+4oyNbC9m6R3U2MN6jjW5A==", null, false, "bf1b6647-bd10-4406-9b45-6e84d1146193", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3739c010-dd90-4e82-a996-790327db124e", "447d1146-c58c-4d86-a1e7-6150cefe081a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b988814d-9525-44c6-8c7a-3120f4c87a2c", "8bcf4da1-e7af-44f7-9c5c-759879c434eb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7dd8ebc4-f11c-4475-bcb4-fa54474c3099", "f4cf2901-eba8-47bb-86c1-f4cfafff82f4" });
        }
    }
}
