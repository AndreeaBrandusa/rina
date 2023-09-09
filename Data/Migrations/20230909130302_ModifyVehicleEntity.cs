using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rina.Data.Migrations
{
    public partial class ModifyVehicleEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2b6db879-996c-4bf6-8b5b-d56071f086b5", "a8f23a8e-560b-49b2-9141-f54511489dc5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e1891063-4235-4dfa-a3ac-75fbd36272f7", "f7ecd26c-27b2-40e8-9f36-d1b9091b7a3b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c375e735-0ec0-45ff-a2af-3a2698da9cd9", "fcb33a2b-eb03-4d78-950a-226ba43549c3" });

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "00f212c3-05ed-48bd-9760-5c1b9e6c9bf7");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "01aa1d52-0313-4829-b0d1-ac0fc253c31d");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "10156372-88d3-42aa-b2ff-562e10300baf");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "166379df-d2fd-4b8e-862b-708e22bb7271");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "1fbcf885-450d-4f6a-b32f-c427a9590c9a");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "257fd8f9-3b31-4e4e-b431-52ce7b6f8d55");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "36fd5ec9-2609-4132-8cfc-1ff49be097e8");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "42cb0289-9186-4bb7-8ab7-54890e61fb14");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "4876094f-a4e2-4989-8ce4-4c7e990b9cbd");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "57e58080-75da-445b-9e50-e9c41704fe8e");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "5dc85c72-08a0-45cd-a382-cd529c852412");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "5e281ce4-f394-40e3-8ce5-2a4fffbed4a2");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "5e3a8a07-89b9-41d8-951f-c2242c331d22");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "614faa20-5903-41fc-b578-f4afc5634343");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "67db8011-c38b-4330-8deb-aa64b0f2fa8d");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "69be7f17-6029-4f61-92ee-88086239ec5e");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "867d592d-9d43-486a-8a32-046efa477398");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "8ea0fee5-4860-4f2a-94c3-8ee874b95d09");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "95a7e4aa-c04b-420e-be1d-c07d78367353");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "9886b22a-5ec8-47ad-bee6-63189e5d0b9e");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "9dea5233-98c9-4bb2-9f9e-2036a1c9234a");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "a30744e4-a372-4d47-b299-47796e06801e");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "a48ba6a8-8e88-411c-9a15-ab0160a4a01c");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "a79866d2-9d8e-499b-915a-2fbb86b74a85");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "acf1797f-f3b0-49cb-9eb9-43a94056c82f");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "af74207e-1a14-405d-b4cc-c18c98e2ca11");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "c0dc6797-f867-432d-8895-4258431e7bff");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "ce384475-35dd-46b5-905c-485318c73c9f");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "d327ff09-4e30-4294-9863-acb3b838d7d8");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "d682f8b9-a558-46a8-8a2e-1977678e3348");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "d810afc8-af36-47b4-837b-d6ae5a42903d");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "dad12939-bdca-461a-ac59-e88d42488d90");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "e84c4235-b918-43de-9532-82f5528497bd");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "ea1ab24a-f799-4998-a86e-e2f9e020d5b8");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "eb3ca933-2b63-4c46-97db-7c4280924e0c");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "ed3b0594-f0d9-4eba-8439-3f4fc6585942");

            migrationBuilder.DeleteData(
                table: "VehicleDriver",
                keyColumn: "Id",
                keyValue: "e7ea6fb6-171b-4c18-9cf1-d02f8b26ec5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b6db879-996c-4bf6-8b5b-d56071f086b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c375e735-0ec0-45ff-a2af-3a2698da9cd9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1891063-4235-4dfa-a3ac-75fbd36272f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8f23a8e-560b-49b2-9141-f54511489dc5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7ecd26c-27b2-40e8-9f36-d1b9091b7a3b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fcb33a2b-eb03-4d78-950a-226ba43549c3");

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteId",
                keyValue: "056ff285-3997-43dc-81a8-6a2dd7b0917c");

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteId",
                keyValue: "6c0b91ea-886b-4ab5-9672-2ec8a27d4151");

            migrationBuilder.AddColumn<string>(
                name: "RouteId",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "826edf02-be96-4354-a3b9-76be2dae239b", "826edf02-be96-4354-a3b9-76be2dae239b", "Administrator", "ADMIN" },
                    { "882cacf5-92a6-4567-a517-2173d7089c6a", "882cacf5-92a6-4567-a517-2173d7089c6a", "User", "USER" },
                    { "9beeed4b-d556-4454-bdfc-42fb7ee52514", "9beeed4b-d556-4454-bdfc-42fb7ee52514", "Driver", "DRIVER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4aa81014-cdb0-4ae2-8b12-f28addfd1f62", 0, "92cbc211-3942-4dac-8c4b-0badb6ec8796", "andreea@gmail.com", true, false, null, null, "ANDREEA", "AQAAAAEAACcQAAAAEHPdP/U+xFGKubeyFChPXK+4ZteczJ0Wgd771xMiY/Tv+lJWPPO9t+u0i8MpcL2k9Q==", null, false, "ca02c2af-9aab-43eb-af45-6c85d8200022", false, "andreea" },
                    { "54a34540-f11d-4b99-a1a7-c5b0869c90b0", 0, "0bb99aae-1bb4-4dc9-84b0-337da034c1d0", "admin@gmail.com", true, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEPTnlTWhYhb/rsz3rGtLkcErvyHYu/tX2HcUiHpwYq7RqvziuW4O8GolCIBKtOF/8g==", null, false, "49775fc8-7995-4599-8a98-5f98dfcde76d", false, "admin" },
                    { "f0efd0a3-6dec-4765-bc33-3d25f126f8d9", 0, "f3e38952-7c1f-47e9-9308-70795114cd3f", "driver@gmail.com", true, false, null, null, "DRIVER", "AQAAAAEAACcQAAAAEHKarOAR5ogzGIbXxJiUnb8VomxkVKr1q55JHAK7+ktaI4iT2kSjmYWZCbv059zEUA==", null, false, "9fb0a1c0-58a4-41c5-b57d-a733e395b627", false, "driver" }
                });

            migrationBuilder.InsertData(
                table: "Route",
                columns: new[] { "RouteId", "VehicleId" },
                values: new object[,]
                {
                    { "33e223ce-0f23-4197-9bce-4c357edde27f", "2253d4b4-edba-4041-a314-22968193faf2" },
                    { "81fe3273-f393-451f-b81c-1dd7a9395c66", "2253d4b4-edba-4041-a314-22968193faf2" }
                });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: "2253d4b4-edba-4041-a314-22968193faf2",
                column: "RouteId",
                value: "33e223ce-0f23-4197-9bce-4c357edde27f");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "882cacf5-92a6-4567-a517-2173d7089c6a", "4aa81014-cdb0-4ae2-8b12-f28addfd1f62" },
                    { "826edf02-be96-4354-a3b9-76be2dae239b", "54a34540-f11d-4b99-a1a7-c5b0869c90b0" },
                    { "9beeed4b-d556-4454-bdfc-42fb7ee52514", "f0efd0a3-6dec-4765-bc33-3d25f126f8d9" }
                });

            migrationBuilder.InsertData(
                table: "Station",
                columns: new[] { "Id", "Latitude", "Longitude", "Name", "RouteId" },
                values: new object[,]
                {
                    { "00d2884c-8ee8-4e46-81d9-77c866a654c8", 457488903942873.50000000000000m, 212527015646313.90000000000000m, "Banatim", "81fe3273-f393-451f-b81c-1dd7a9395c66" },
                    { "0e6ef67e-63fc-45d2-99d0-2bc0cc715b8e", 457482785901011.70000000000000m, 212191745283552.70000000000000m, "Piata Maria", "81fe3273-f393-451f-b81c-1dd7a9395c66" },
                    { "133a6f80-0660-4f6f-a8ed-50d5f6db9e15", 457417625338582.14000000000000m, 212251459649236.10000000000000m, "Piata Nicolae Balcescu", "33e223ce-0f23-4197-9bce-4c357edde27f" },
                    { "238608bc-e193-408f-b0b3-0544bbe58b86", 457420058812021.80000000000000m, 212324666500880.03000000000000m, "Piata Crucii", "81fe3273-f393-451f-b81c-1dd7a9395c66" },
                    { "34eb3f68-da72-4bd0-a577-2c452c538d3e", 457567215826950.15000000000000m, 212449256988964.84000000000000m, "3 August 1919", "81fe3273-f393-451f-b81c-1dd7a9395c66" },
                    { "37ec3e4b-2a79-40cf-a575-582a32f8f4bc", 457471572743708.90000000000000m, 212465820971733.73000000000000m, "Deliblata", "33e223ce-0f23-4197-9bce-4c357edde27f" },
                    { "3b3c135d-604b-4ad3-adb4-6cf79a1468a6", 457438856012541.40000000000000m, 212371287092157.85000000000000m, "Cluj", "33e223ce-0f23-4197-9bce-4c357edde27f" },
                    { "4883d0c3-6c2f-4975-8c15-869da4dd41d0", 457482785901011.70000000000000m, 212191745283552.70000000000000m, "Piata Maria", "33e223ce-0f23-4197-9bce-4c357edde27f" },
                    { "4b198deb-ddd6-427b-bb81-e17e8499e03b", 457510922178538.20000000000000m, 212236185720668.60000000000000m, "Catedrala Metropolitana", "33e223ce-0f23-4197-9bce-4c357edde27f" },
                    { "6107253e-7306-4a43-8101-1811fc1c97d7", 457488903942873.50000000000000m, 212527015646313.90000000000000m, "Banatim", "33e223ce-0f23-4197-9bce-4c357edde27f" },
                    { "6e02e0e9-c81a-417c-8d4d-706ff630342f", 457438856012541.40000000000000m, 212371287092157.85000000000000m, "Cluj", "81fe3273-f393-451f-b81c-1dd7a9395c66" },
                    { "79c1cacc-4330-43bc-b4c4-68d3f461bb5b", 457567215826950.15000000000000m, 212449256988964.84000000000000m, "3 August 1919", "33e223ce-0f23-4197-9bce-4c357edde27f" },
                    { "8b4a5b55-fbee-4dd8-b207-fb13a2391ad3", 457453343014063.60000000000000m, 212414467905664.74000000000000m, "Sala Olimpia", "33e223ce-0f23-4197-9bce-4c357edde27f" },
                    { "8cdccd81-1a76-4eee-853d-fbd5555c0070", 457549076999152.70000000000000m, 212210508005243.03000000000000m, "Spitalul de copii", "81fe3273-f393-451f-b81c-1dd7a9395c66" },
                    { "8ff7a375-6543-404a-9026-1d07c79265c8", 457562516335078.50000000000000m, 212229088920353.74000000000000m, "Piata Timisoara 700", "81fe3273-f393-451f-b81c-1dd7a9395c66" },
                    { "9197c5b3-cdd3-42b6-bdc9-7d98d6102803", 457574950084526.40000000000000m, 212491693964518.30000000000000m, "Piata Traian", "81fe3273-f393-451f-b81c-1dd7a9395c66" },
                    { "97dfc4c7-1ebc-4f20-8319-32211796d9be", 457471572743708.90000000000000m, 212465820971733.73000000000000m, "Deliblata", "81fe3273-f393-451f-b81c-1dd7a9395c66" },
                    { "9a78197b-456f-47c7-8d6b-4af6e75825f6", 457562516335078.50000000000000m, 212229088920353.74000000000000m, "Piata Timisoara 700", "33e223ce-0f23-4197-9bce-4c357edde27f" },
                    { "9bb15c24-8049-4eb5-92f9-00494c92a00f", 457558725046083.20000000000000m, 212276939799686.0000000000000m, "Piata Libertatii", "81fe3273-f393-451f-b81c-1dd7a9395c66" },
                    { "9eef5191-5e60-405a-9e3f-f7e5e933b91e", 457420058812021.80000000000000m, 212324666500880.03000000000000m, "Piata Crucii", "33e223ce-0f23-4197-9bce-4c357edde27f" },
                    { "a2c2863a-68d3-4a86-9340-5ed594e2158b", 457558725046083.20000000000000m, 212276939799686.0000000000000m, "Piata Libertatii", "33e223ce-0f23-4197-9bce-4c357edde27f" },
                    { "b4204abd-8829-4f15-875a-7ca14a58a066", 457561970168036.10000000000000m, 212213075532377.32000000000000m, "Brediceanu", "81fe3273-f393-451f-b81c-1dd7a9395c66" },
                    { "bd4b842e-aa26-4b6b-8355-fc7649c93632", 457561970168036.10000000000000m, 212213075532377.32000000000000m, "Brediceanu", "33e223ce-0f23-4197-9bce-4c357edde27f" },
                    { "c16ff471-9c9e-4a67-a55d-28bb82011f7d", 457530100528003.56000000000000m, 212501719692575.72000000000000m, "Fabrica De Bere Timisoara", "81fe3273-f393-451f-b81c-1dd7a9395c66" },
                    { "c584f7b5-e730-424b-b76d-2f8f07071532", 457574950084526.40000000000000m, 212491693964518.30000000000000m, "Piata Traian", "33e223ce-0f23-4197-9bce-4c357edde27f" },
                    { "c5caf246-2922-4f35-a463-992bdf34074b", 457557493352611.36000000000000m, 212318589875084.56000000000000m, "Hotel Continental", "81fe3273-f393-451f-b81c-1dd7a9395c66" },
                    { "d2ad6010-ed86-402f-888a-a07c31374f7b", 457510922178538.20000000000000m, 212236185720668.60000000000000m, "Catedrala Metropolitana", "81fe3273-f393-451f-b81c-1dd7a9395c66" },
                    { "d5a02bda-350b-47d2-b911-608d8995e00f", 457549076999152.70000000000000m, 212210508005243.03000000000000m, "Spitalul de copii", "33e223ce-0f23-4197-9bce-4c357edde27f" },
                    { "deb0ff31-bd0a-47d5-8d1a-67f3601c54c2", 457417625338582.14000000000000m, 212251459649236.10000000000000m, "Piata Nicolae Balcescu", "81fe3273-f393-451f-b81c-1dd7a9395c66" },
                    { "e4684cc4-4211-43be-9776-0903799b4339", 457530100528003.56000000000000m, 212501719692575.72000000000000m, "Fabrica De Bere Timisoara", "33e223ce-0f23-4197-9bce-4c357edde27f" },
                    { "e71a87ad-470e-4f68-8a5c-e0737c0aa1fe", 457444445740046.96000000000000m, 212223795184418.44000000000000m, "Parc Doina", "33e223ce-0f23-4197-9bce-4c357edde27f" },
                    { "eb402b4d-cf60-417f-b3cc-2d4bd3580075", 457556223474490.30000000000000m, 212384271011132.56000000000000m, "Prefectura Judetului Timis", "33e223ce-0f23-4197-9bce-4c357edde27f" },
                    { "ebc3df25-1080-43c0-9b35-a91212ff1196", 457556223474490.30000000000000m, 212384271011132.56000000000000m, "Prefectura Judetului Timis", "81fe3273-f393-451f-b81c-1dd7a9395c66" },
                    { "ebc43d54-12ed-4c2c-b7b3-211764011c12", 457453343014063.60000000000000m, 212414467905664.74000000000000m, "Sala Olimpia", "81fe3273-f393-451f-b81c-1dd7a9395c66" },
                    { "fd4d744a-dd5e-44f3-bee9-4b3e384f389e", 457557493352611.36000000000000m, 212318589875084.56000000000000m, "Hotel Continental", "33e223ce-0f23-4197-9bce-4c357edde27f" },
                    { "fe20e999-a9b2-47b3-9008-f741fd04ade5", 457444445740046.96000000000000m, 212223795184418.44000000000000m, "Parc Doina", "81fe3273-f393-451f-b81c-1dd7a9395c66" }
                });

            migrationBuilder.InsertData(
                table: "VehicleDriver",
                columns: new[] { "Id", "DriverId", "VehicleId" },
                values: new object[] { "c4c1c951-b95c-4db5-94f8-eb9375be05c4", "f0efd0a3-6dec-4765-bc33-3d25f126f8d9", "2253d4b4-edba-4041-a314-22968193faf2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "882cacf5-92a6-4567-a517-2173d7089c6a", "4aa81014-cdb0-4ae2-8b12-f28addfd1f62" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "826edf02-be96-4354-a3b9-76be2dae239b", "54a34540-f11d-4b99-a1a7-c5b0869c90b0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9beeed4b-d556-4454-bdfc-42fb7ee52514", "f0efd0a3-6dec-4765-bc33-3d25f126f8d9" });

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "00d2884c-8ee8-4e46-81d9-77c866a654c8");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "0e6ef67e-63fc-45d2-99d0-2bc0cc715b8e");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "133a6f80-0660-4f6f-a8ed-50d5f6db9e15");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "238608bc-e193-408f-b0b3-0544bbe58b86");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "34eb3f68-da72-4bd0-a577-2c452c538d3e");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "37ec3e4b-2a79-40cf-a575-582a32f8f4bc");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "3b3c135d-604b-4ad3-adb4-6cf79a1468a6");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "4883d0c3-6c2f-4975-8c15-869da4dd41d0");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "4b198deb-ddd6-427b-bb81-e17e8499e03b");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "6107253e-7306-4a43-8101-1811fc1c97d7");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "6e02e0e9-c81a-417c-8d4d-706ff630342f");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "79c1cacc-4330-43bc-b4c4-68d3f461bb5b");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "8b4a5b55-fbee-4dd8-b207-fb13a2391ad3");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "8cdccd81-1a76-4eee-853d-fbd5555c0070");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "8ff7a375-6543-404a-9026-1d07c79265c8");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "9197c5b3-cdd3-42b6-bdc9-7d98d6102803");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "97dfc4c7-1ebc-4f20-8319-32211796d9be");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "9a78197b-456f-47c7-8d6b-4af6e75825f6");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "9bb15c24-8049-4eb5-92f9-00494c92a00f");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "9eef5191-5e60-405a-9e3f-f7e5e933b91e");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "a2c2863a-68d3-4a86-9340-5ed594e2158b");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "b4204abd-8829-4f15-875a-7ca14a58a066");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "bd4b842e-aa26-4b6b-8355-fc7649c93632");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "c16ff471-9c9e-4a67-a55d-28bb82011f7d");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "c584f7b5-e730-424b-b76d-2f8f07071532");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "c5caf246-2922-4f35-a463-992bdf34074b");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "d2ad6010-ed86-402f-888a-a07c31374f7b");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "d5a02bda-350b-47d2-b911-608d8995e00f");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "deb0ff31-bd0a-47d5-8d1a-67f3601c54c2");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "e4684cc4-4211-43be-9776-0903799b4339");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "e71a87ad-470e-4f68-8a5c-e0737c0aa1fe");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "eb402b4d-cf60-417f-b3cc-2d4bd3580075");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "ebc3df25-1080-43c0-9b35-a91212ff1196");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "ebc43d54-12ed-4c2c-b7b3-211764011c12");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "fd4d744a-dd5e-44f3-bee9-4b3e384f389e");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "fe20e999-a9b2-47b3-9008-f741fd04ade5");

            migrationBuilder.DeleteData(
                table: "VehicleDriver",
                keyColumn: "Id",
                keyValue: "c4c1c951-b95c-4db5-94f8-eb9375be05c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "826edf02-be96-4354-a3b9-76be2dae239b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "882cacf5-92a6-4567-a517-2173d7089c6a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9beeed4b-d556-4454-bdfc-42fb7ee52514");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4aa81014-cdb0-4ae2-8b12-f28addfd1f62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54a34540-f11d-4b99-a1a7-c5b0869c90b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0efd0a3-6dec-4765-bc33-3d25f126f8d9");

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteId",
                keyValue: "33e223ce-0f23-4197-9bce-4c357edde27f");

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteId",
                keyValue: "81fe3273-f393-451f-b81c-1dd7a9395c66");

            migrationBuilder.DropColumn(
                name: "RouteId",
                table: "Vehicle");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b6db879-996c-4bf6-8b5b-d56071f086b5", "2b6db879-996c-4bf6-8b5b-d56071f086b5", "User", "USER" },
                    { "c375e735-0ec0-45ff-a2af-3a2698da9cd9", "c375e735-0ec0-45ff-a2af-3a2698da9cd9", "Administrator", "ADMIN" },
                    { "e1891063-4235-4dfa-a3ac-75fbd36272f7", "e1891063-4235-4dfa-a3ac-75fbd36272f7", "Driver", "DRIVER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a8f23a8e-560b-49b2-9141-f54511489dc5", 0, "5a609956-061b-45fc-b023-4441c3a19727", "andreea@gmail.com", true, false, null, null, "ANDREEA", "AQAAAAEAACcQAAAAEJC/cwWMRcpUyz3TTcDxlRBiekbyUf2HxQD1JQ3kFEQKioFu+Y1ViRu3IVWXz/t5lA==", null, false, "ab4e889e-e200-4630-afda-d17d4b9d1ebc", false, "andreea" },
                    { "f7ecd26c-27b2-40e8-9f36-d1b9091b7a3b", 0, "322052ac-0f5d-4645-b733-775e2e8491a2", "driver@gmail.com", true, false, null, null, "DRIVER", "AQAAAAEAACcQAAAAEKEXs4/HebA10vktnOgNTZRaZ42ujXce+3uY4/RxlBYo0MrnJc7EYVkn+TPYzWjjQg==", null, false, "eb841d50-0f27-4b0a-a8f7-85e0c287b52f", false, "driver" },
                    { "fcb33a2b-eb03-4d78-950a-226ba43549c3", 0, "d5e32ccc-305a-4386-b8f4-1ed49fc573fb", "admin@gmail.com", true, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEJHfRj63YXPHjmyFIilZiR3os5N4+TuqFma4/aGl7crXBWg7KRJdSQEnBfBMmFeUog==", null, false, "997946bd-c2c7-429c-b170-a673109f21dc", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Route",
                columns: new[] { "RouteId", "VehicleId" },
                values: new object[,]
                {
                    { "056ff285-3997-43dc-81a8-6a2dd7b0917c", "2253d4b4-edba-4041-a314-22968193faf2" },
                    { "6c0b91ea-886b-4ab5-9672-2ec8a27d4151", "2253d4b4-edba-4041-a314-22968193faf2" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2b6db879-996c-4bf6-8b5b-d56071f086b5", "a8f23a8e-560b-49b2-9141-f54511489dc5" },
                    { "e1891063-4235-4dfa-a3ac-75fbd36272f7", "f7ecd26c-27b2-40e8-9f36-d1b9091b7a3b" },
                    { "c375e735-0ec0-45ff-a2af-3a2698da9cd9", "fcb33a2b-eb03-4d78-950a-226ba43549c3" }
                });

            migrationBuilder.InsertData(
                table: "Station",
                columns: new[] { "Id", "Latitude", "Longitude", "Name", "RouteId" },
                values: new object[,]
                {
                    { "00f212c3-05ed-48bd-9760-5c1b9e6c9bf7", 457438856012541.40000000000000m, 212371287092157.85000000000000m, "Cluj", "6c0b91ea-886b-4ab5-9672-2ec8a27d4151" },
                    { "01aa1d52-0313-4829-b0d1-ac0fc253c31d", 457549076999152.70000000000000m, 212210508005243.03000000000000m, "Spitalul de copii", "6c0b91ea-886b-4ab5-9672-2ec8a27d4151" },
                    { "10156372-88d3-42aa-b2ff-562e10300baf", 457530100528003.56000000000000m, 212501719692575.72000000000000m, "Fabrica De Bere Timisoara", "6c0b91ea-886b-4ab5-9672-2ec8a27d4151" },
                    { "166379df-d2fd-4b8e-862b-708e22bb7271", 457562516335078.50000000000000m, 212229088920353.74000000000000m, "Piata Timisoara 700", "6c0b91ea-886b-4ab5-9672-2ec8a27d4151" },
                    { "1fbcf885-450d-4f6a-b32f-c427a9590c9a", 457558725046083.20000000000000m, 212276939799686.0000000000000m, "Piata Libertatii", "6c0b91ea-886b-4ab5-9672-2ec8a27d4151" },
                    { "257fd8f9-3b31-4e4e-b431-52ce7b6f8d55", 457444445740046.96000000000000m, 212223795184418.44000000000000m, "Parc Doina", "6c0b91ea-886b-4ab5-9672-2ec8a27d4151" },
                    { "36fd5ec9-2609-4132-8cfc-1ff49be097e8", 457530100528003.56000000000000m, 212501719692575.72000000000000m, "Fabrica De Bere Timisoara", "056ff285-3997-43dc-81a8-6a2dd7b0917c" },
                    { "42cb0289-9186-4bb7-8ab7-54890e61fb14", 457444445740046.96000000000000m, 212223795184418.44000000000000m, "Parc Doina", "056ff285-3997-43dc-81a8-6a2dd7b0917c" },
                    { "4876094f-a4e2-4989-8ce4-4c7e990b9cbd", 457556223474490.30000000000000m, 212384271011132.56000000000000m, "Prefectura Judetului Timis", "6c0b91ea-886b-4ab5-9672-2ec8a27d4151" },
                    { "57e58080-75da-445b-9e50-e9c41704fe8e", 457549076999152.70000000000000m, 212210508005243.03000000000000m, "Spitalul de copii", "056ff285-3997-43dc-81a8-6a2dd7b0917c" },
                    { "5dc85c72-08a0-45cd-a382-cd529c852412", 457558725046083.20000000000000m, 212276939799686.0000000000000m, "Piata Libertatii", "056ff285-3997-43dc-81a8-6a2dd7b0917c" },
                    { "5e281ce4-f394-40e3-8ce5-2a4fffbed4a2", 457488903942873.50000000000000m, 212527015646313.90000000000000m, "Banatim", "056ff285-3997-43dc-81a8-6a2dd7b0917c" },
                    { "5e3a8a07-89b9-41d8-951f-c2242c331d22", 457510922178538.20000000000000m, 212236185720668.60000000000000m, "Catedrala Metropolitana", "056ff285-3997-43dc-81a8-6a2dd7b0917c" },
                    { "614faa20-5903-41fc-b578-f4afc5634343", 457556223474490.30000000000000m, 212384271011132.56000000000000m, "Prefectura Judetului Timis", "056ff285-3997-43dc-81a8-6a2dd7b0917c" },
                    { "67db8011-c38b-4330-8deb-aa64b0f2fa8d", 457420058812021.80000000000000m, 212324666500880.03000000000000m, "Piata Crucii", "056ff285-3997-43dc-81a8-6a2dd7b0917c" },
                    { "69be7f17-6029-4f61-92ee-88086239ec5e", 457561970168036.10000000000000m, 212213075532377.32000000000000m, "Brediceanu", "056ff285-3997-43dc-81a8-6a2dd7b0917c" },
                    { "867d592d-9d43-486a-8a32-046efa477398", 457510922178538.20000000000000m, 212236185720668.60000000000000m, "Catedrala Metropolitana", "6c0b91ea-886b-4ab5-9672-2ec8a27d4151" },
                    { "8ea0fee5-4860-4f2a-94c3-8ee874b95d09", 457567215826950.15000000000000m, 212449256988964.84000000000000m, "3 August 1919", "6c0b91ea-886b-4ab5-9672-2ec8a27d4151" },
                    { "95a7e4aa-c04b-420e-be1d-c07d78367353", 457488903942873.50000000000000m, 212527015646313.90000000000000m, "Banatim", "6c0b91ea-886b-4ab5-9672-2ec8a27d4151" },
                    { "9886b22a-5ec8-47ad-bee6-63189e5d0b9e", 457453343014063.60000000000000m, 212414467905664.74000000000000m, "Sala Olimpia", "056ff285-3997-43dc-81a8-6a2dd7b0917c" },
                    { "9dea5233-98c9-4bb2-9f9e-2036a1c9234a", 457574950084526.40000000000000m, 212491693964518.30000000000000m, "Piata Traian", "056ff285-3997-43dc-81a8-6a2dd7b0917c" },
                    { "a30744e4-a372-4d47-b299-47796e06801e", 457562516335078.50000000000000m, 212229088920353.74000000000000m, "Piata Timisoara 700", "056ff285-3997-43dc-81a8-6a2dd7b0917c" },
                    { "a48ba6a8-8e88-411c-9a15-ab0160a4a01c", 457420058812021.80000000000000m, 212324666500880.03000000000000m, "Piata Crucii", "6c0b91ea-886b-4ab5-9672-2ec8a27d4151" },
                    { "a79866d2-9d8e-499b-915a-2fbb86b74a85", 457482785901011.70000000000000m, 212191745283552.70000000000000m, "Piata Maria", "056ff285-3997-43dc-81a8-6a2dd7b0917c" },
                    { "acf1797f-f3b0-49cb-9eb9-43a94056c82f", 457482785901011.70000000000000m, 212191745283552.70000000000000m, "Piata Maria", "6c0b91ea-886b-4ab5-9672-2ec8a27d4151" },
                    { "af74207e-1a14-405d-b4cc-c18c98e2ca11", 457438856012541.40000000000000m, 212371287092157.85000000000000m, "Cluj", "056ff285-3997-43dc-81a8-6a2dd7b0917c" },
                    { "c0dc6797-f867-432d-8895-4258431e7bff", 457574950084526.40000000000000m, 212491693964518.30000000000000m, "Piata Traian", "6c0b91ea-886b-4ab5-9672-2ec8a27d4151" },
                    { "ce384475-35dd-46b5-905c-485318c73c9f", 457557493352611.36000000000000m, 212318589875084.56000000000000m, "Hotel Continental", "056ff285-3997-43dc-81a8-6a2dd7b0917c" },
                    { "d327ff09-4e30-4294-9863-acb3b838d7d8", 457561970168036.10000000000000m, 212213075532377.32000000000000m, "Brediceanu", "6c0b91ea-886b-4ab5-9672-2ec8a27d4151" },
                    { "d682f8b9-a558-46a8-8a2e-1977678e3348", 457471572743708.90000000000000m, 212465820971733.73000000000000m, "Deliblata", "6c0b91ea-886b-4ab5-9672-2ec8a27d4151" },
                    { "d810afc8-af36-47b4-837b-d6ae5a42903d", 457471572743708.90000000000000m, 212465820971733.73000000000000m, "Deliblata", "056ff285-3997-43dc-81a8-6a2dd7b0917c" },
                    { "dad12939-bdca-461a-ac59-e88d42488d90", 457567215826950.15000000000000m, 212449256988964.84000000000000m, "3 August 1919", "056ff285-3997-43dc-81a8-6a2dd7b0917c" },
                    { "e84c4235-b918-43de-9532-82f5528497bd", 457557493352611.36000000000000m, 212318589875084.56000000000000m, "Hotel Continental", "6c0b91ea-886b-4ab5-9672-2ec8a27d4151" },
                    { "ea1ab24a-f799-4998-a86e-e2f9e020d5b8", 457417625338582.14000000000000m, 212251459649236.10000000000000m, "Piata Nicolae Balcescu", "056ff285-3997-43dc-81a8-6a2dd7b0917c" },
                    { "eb3ca933-2b63-4c46-97db-7c4280924e0c", 457453343014063.60000000000000m, 212414467905664.74000000000000m, "Sala Olimpia", "6c0b91ea-886b-4ab5-9672-2ec8a27d4151" },
                    { "ed3b0594-f0d9-4eba-8439-3f4fc6585942", 457417625338582.14000000000000m, 212251459649236.10000000000000m, "Piata Nicolae Balcescu", "6c0b91ea-886b-4ab5-9672-2ec8a27d4151" }
                });

            migrationBuilder.InsertData(
                table: "VehicleDriver",
                columns: new[] { "Id", "DriverId", "VehicleId" },
                values: new object[] { "e7ea6fb6-171b-4c18-9cf1-d02f8b26ec5e", "f7ecd26c-27b2-40e8-9f36-d1b9091b7a3b", "2253d4b4-edba-4041-a314-22968193faf2" });
        }
    }
}
