using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rina.Data.Migrations
{
    public partial class Vehicle : Migration
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
                name: "Station",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Station", x => x.Id);
                });

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
                    VehicleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DriverId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleDriver", x => new { x.Id, x.VehicleId, x.DriverId });
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
                name: "RouteStation",
                columns: table => new
                {
                    RoutesRouteId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StationsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteStation", x => new { x.RoutesRouteId, x.StationsId });
                    table.ForeignKey(
                        name: "FK_RouteStation_Route_RoutesRouteId",
                        column: x => x.RoutesRouteId,
                        principalTable: "Route",
                        principalColumn: "RouteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RouteStation_Station_StationsId",
                        column: x => x.StationsId,
                        principalTable: "Station",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ab2a52d-862b-44e5-8d9e-b0a0f386c1b0", "1ab2a52d-862b-44e5-8d9e-b0a0f386c1b0", "Driver", "DRIVER" },
                    { "7670aa0b-db3f-464f-a45b-92a7ddbb1414", "7670aa0b-db3f-464f-a45b-92a7ddbb1414", "User", "USER" },
                    { "c6bb5d70-d8c7-44d2-9421-d8a724551784", "c6bb5d70-d8c7-44d2-9421-d8a724551784", "Administrator", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "720d842e-c2ac-4caa-b04c-5ae7a2152c2d", 0, "71e355cd-1fb9-4bf3-b336-35de088d77b2", "andreea@gmail.com", true, false, null, null, "ANDREEA", "AQAAAAEAACcQAAAAEDDLX14Ne5+mpMiLeSk4poKB0WtosUTtJREh1WxcyREUOE40ZuY/4G6TLyw+3ihamQ==", null, false, "91db6715-77a0-40f6-a1c9-3205178a1f8a", false, "andreea" },
                    { "9edbe3b7-570a-41db-bbf5-aaa0de5ba102", 0, "83cd8f41-9b92-442d-b57c-7283ebe833ca", "admin@gmail.com", true, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEFXrUT/tBnoMUdUEXMlyoIhTDTiWEZeWeXtSVViSbNqYKQcbyttKP2s24Xdm69NpLg==", null, false, "17e57c62-c87d-4527-8a8c-ade0b9fef13e", false, "admin" },
                    { "d49b532f-18d2-4584-a5c5-bc776b002cb1", 0, "8da550dd-aaa2-46a3-9e1b-9a33118869c6", "driver@gmail.com", true, false, null, null, "DRIVER", "AQAAAAEAACcQAAAAEHC4enquade4O6IhWULFJgv5djjxPED6waeuNTVkyThDcQxbnMcYOJBlb2L/3PUhsQ==", null, false, "f26b0c92-05cf-4083-b4e5-a438014bebec", false, "driver" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7670aa0b-db3f-464f-a45b-92a7ddbb1414", "720d842e-c2ac-4caa-b04c-5ae7a2152c2d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c6bb5d70-d8c7-44d2-9421-d8a724551784", "9edbe3b7-570a-41db-bbf5-aaa0de5ba102" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1ab2a52d-862b-44e5-8d9e-b0a0f386c1b0", "d49b532f-18d2-4584-a5c5-bc776b002cb1" });

            migrationBuilder.CreateIndex(
                name: "IX_Route_VehicleId",
                table: "Route",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteStation_StationsId",
                table: "RouteStation",
                column: "StationsId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDriver_DriverId",
                table: "VehicleDriver",
                column: "DriverId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDriver_VehicleId",
                table: "VehicleDriver",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RouteStation");

            migrationBuilder.DropTable(
                name: "VehicleDriver");

            migrationBuilder.DropTable(
                name: "Route");

            migrationBuilder.DropTable(
                name: "Station");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7670aa0b-db3f-464f-a45b-92a7ddbb1414", "720d842e-c2ac-4caa-b04c-5ae7a2152c2d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c6bb5d70-d8c7-44d2-9421-d8a724551784", "9edbe3b7-570a-41db-bbf5-aaa0de5ba102" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1ab2a52d-862b-44e5-8d9e-b0a0f386c1b0", "d49b532f-18d2-4584-a5c5-bc776b002cb1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ab2a52d-862b-44e5-8d9e-b0a0f386c1b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7670aa0b-db3f-464f-a45b-92a7ddbb1414");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6bb5d70-d8c7-44d2-9421-d8a724551784");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "720d842e-c2ac-4caa-b04c-5ae7a2152c2d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9edbe3b7-570a-41db-bbf5-aaa0de5ba102");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d49b532f-18d2-4584-a5c5-bc776b002cb1");

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
