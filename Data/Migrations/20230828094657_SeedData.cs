using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rina.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
