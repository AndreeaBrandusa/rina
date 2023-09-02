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
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
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
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
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
                    { "a4cef116-92a3-488d-a90d-fc137dbb2f02", "a4cef116-92a3-488d-a90d-fc137dbb2f02", "Driver", "DRIVER" },
                    { "bbb08b87-9cd1-42f0-a741-dc7c2b9ce700", "bbb08b87-9cd1-42f0-a741-dc7c2b9ce700", "Administrator", "ADMIN" },
                    { "e5637c04-ac5f-48db-9cae-aa0307d5f06a", "e5637c04-ac5f-48db-9cae-aa0307d5f06a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "31c23363-a2d1-4978-97ce-580ee41b0333", 0, "8b2f35f8-11c8-4472-850f-9e6e2be79beb", "admin@gmail.com", true, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEHUMm4OCQ5R7y+4aASxD6AgTg0JYfDM/ol84Y2BJKpR5fcTLekNcgDwOaJjDrU3H7Q==", null, false, "4914c695-a70d-4a36-be39-319fa3b8fe1e", false, "admin" },
                    { "5fb6e145-9ae9-49b7-8f05-bb3a77d4fdcb", 0, "8a5b4014-3cb8-4d68-a5ad-c29d4248be66", "andreea@gmail.com", true, false, null, null, "ANDREEA", "AQAAAAEAACcQAAAAECQbpVxX2PoBgYY5cMTLNJnevvfy5OttEKlzODLb9w85H877//KcVxh4gfjfZpBfTQ==", null, false, "b92b0ba9-6385-47b5-a041-be7c47007dc4", false, "andreea" },
                    { "a4677616-f8e2-4794-a6a1-c8996bbeee49", 0, "1d2647b1-1505-444e-8fcc-aba538493dbc", "driver@gmail.com", true, false, null, null, "DRIVER", "AQAAAAEAACcQAAAAEL16xQop26QANPMKHcMC/EdB/U+9UP61MN7NRFMGOjHX3aX+UWy/wtX4EVKymfI3lg==", null, false, "3b020962-62dc-451b-b590-a0ff2c8167d6", false, "driver" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bbb08b87-9cd1-42f0-a741-dc7c2b9ce700", "31c23363-a2d1-4978-97ce-580ee41b0333" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e5637c04-ac5f-48db-9cae-aa0307d5f06a", "5fb6e145-9ae9-49b7-8f05-bb3a77d4fdcb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a4cef116-92a3-488d-a90d-fc137dbb2f02", "a4677616-f8e2-4794-a6a1-c8996bbeee49" });

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
                keyValues: new object[] { "bbb08b87-9cd1-42f0-a741-dc7c2b9ce700", "31c23363-a2d1-4978-97ce-580ee41b0333" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e5637c04-ac5f-48db-9cae-aa0307d5f06a", "5fb6e145-9ae9-49b7-8f05-bb3a77d4fdcb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a4cef116-92a3-488d-a90d-fc137dbb2f02", "a4677616-f8e2-4794-a6a1-c8996bbeee49" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4cef116-92a3-488d-a90d-fc137dbb2f02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbb08b87-9cd1-42f0-a741-dc7c2b9ce700");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5637c04-ac5f-48db-9cae-aa0307d5f06a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31c23363-a2d1-4978-97ce-580ee41b0333");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fb6e145-9ae9-49b7-8f05-bb3a77d4fdcb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4677616-f8e2-4794-a6a1-c8996bbeee49");

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
