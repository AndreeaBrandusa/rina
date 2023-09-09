using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rina.Data.Migrations
{
    public partial class Nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Route_Vehicle_VehicleId",
                table: "Route");

            migrationBuilder.DropForeignKey(
                name: "FK_Station_Route_RouteId",
                table: "Station");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e95c8a0e-8a76-4513-8c1c-c03f044970ce", "5adb1532-5c22-4874-8d16-edb976cb9db0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b91737af-72ec-4d5d-b92d-860373ac9ae6", "95277226-4972-44df-ace6-c7e9d513bb1a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4ca3074b-4eca-4860-9e07-7653d8b2c943", "ee7c7819-c7b4-4536-93a9-c12fdd0341cd" });

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "06a23620-e98d-47bf-87d9-bdbc843ffd6c");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "1245d71c-77d4-4ddf-8e27-e0150bf62ffb");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "127e82dc-08af-4d3d-a9b4-c7e9b892a798");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "12df9d88-e8a6-45e0-ade4-626548499fcc");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "1c464244-2c9f-4b07-ac7c-88749b366f26");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "1f673bc4-2153-470f-a41e-70c5bfc4ea9c");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "214ee824-ef4a-42ec-93cd-885ba30d2218");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "2178904b-845a-4782-8506-35bfcb3efdd9");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "21e1f9f4-0f9f-465f-981a-a2ddf8d8d4f4");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "30b4ccf8-72e9-4468-b15d-b22265c61523");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "4635b9f8-7b5c-4dfa-a313-6a97e7cd590d");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "4810761d-df3c-4571-8b38-a809b9d2a8cc");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "4c59a3ac-50a6-4804-ae7d-5411b98ce1c7");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "607ab9fb-22e5-49b2-9f7b-d8231c4033a3");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "756e687e-4e1c-4010-af03-b5a46f3ea07c");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "85ce0a45-d63a-42db-bcb6-bfd80ddf09cb");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "88a43c06-2ffb-499e-a8b5-19fb6d3e1198");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "8c000224-66d1-4447-a7be-1b0e9885b0db");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "8e0bf118-107e-4573-b1a6-f4a069a6fda5");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "95847550-6ebb-4391-adf5-d1e03931c5b6");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "a342fd32-2f27-465f-94ae-a1acfa6d32ec");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "ae02a3b0-f2bd-4ad7-bd79-56246ac58bf3");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "af7d122b-e763-4c6f-aee3-5419f2d3c7a1");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "afb5c4c2-586e-40f9-a7cd-200e49f3a8cb");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "b2a62431-a259-4f15-9857-79fd886df737");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "b3723f00-dcb0-4264-a050-e83486b4454b");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "b5d57f83-5aae-4120-aeea-66c72ca9499a");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "b64be284-7862-462a-83ce-971e6f91e69c");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "be7c3a69-9418-4693-a6eb-4302f9612bcf");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "d59fb59e-a969-4000-a471-2a90069949f5");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "d930934e-675f-486f-ab67-29f548c12261");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "eb42d258-c3e9-4f54-8253-ad979beb67b0");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "edf53b8b-ed23-45a1-821f-a8d7891254d2");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "f05caf53-a02e-4b28-9b30-ea1991655002");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "f2fe1403-1a74-47d7-9e72-d4e949c4b502");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "fa96cc29-2639-44bc-884a-99e4f94748bb");

            migrationBuilder.DeleteData(
                table: "VehicleDriver",
                keyColumn: "Id",
                keyValue: "cbf156ef-ee35-4ce2-857a-71d25d0c9243");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca3074b-4eca-4860-9e07-7653d8b2c943");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b91737af-72ec-4d5d-b92d-860373ac9ae6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e95c8a0e-8a76-4513-8c1c-c03f044970ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5adb1532-5c22-4874-8d16-edb976cb9db0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95277226-4972-44df-ace6-c7e9d513bb1a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee7c7819-c7b4-4536-93a9-c12fdd0341cd");

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteId",
                keyValue: "5a13500d-c8d2-44e1-a6e4-50f1264384a7");

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteId",
                keyValue: "b2fee434-d8c6-400f-a932-ab9a394449a5");

            migrationBuilder.AlterColumn<string>(
                name: "RouteId",
                table: "Station",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "VehicleId",
                table: "Route",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Route_Vehicle_VehicleId",
                table: "Route",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Station_Route_RouteId",
                table: "Station",
                column: "RouteId",
                principalTable: "Route",
                principalColumn: "RouteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Route_Vehicle_VehicleId",
                table: "Route");

            migrationBuilder.DropForeignKey(
                name: "FK_Station_Route_RouteId",
                table: "Station");

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

            migrationBuilder.AlterColumn<string>(
                name: "RouteId",
                table: "Station",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VehicleId",
                table: "Route",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4ca3074b-4eca-4860-9e07-7653d8b2c943", "4ca3074b-4eca-4860-9e07-7653d8b2c943", "Driver", "DRIVER" },
                    { "b91737af-72ec-4d5d-b92d-860373ac9ae6", "b91737af-72ec-4d5d-b92d-860373ac9ae6", "Administrator", "ADMIN" },
                    { "e95c8a0e-8a76-4513-8c1c-c03f044970ce", "e95c8a0e-8a76-4513-8c1c-c03f044970ce", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5adb1532-5c22-4874-8d16-edb976cb9db0", 0, "ac7e3426-7c3f-451b-8241-7fee2f109f69", "andreea@gmail.com", true, false, null, null, "ANDREEA", "AQAAAAEAACcQAAAAEKf3/sLPDSjPbqomNpMVfHOoa54vbhrx3LW3GVlb2QGCKkW8+qbMSN0xZ5jWy9BfoQ==", null, false, "feaa3c6f-0465-4172-8e3c-00ab324e4bc6", false, "andreea" },
                    { "95277226-4972-44df-ace6-c7e9d513bb1a", 0, "affbc151-0ca0-40f3-b8dc-4b166be087c4", "admin@gmail.com", true, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEAZ9XPNqzfqvkrFCgI3vO3gfzgm/0YZQYJTTu5rHHot/49D1WLpDLTk2yECKV7mZsQ==", null, false, "81a75e0f-2afc-4508-b74b-f2e1907ae1da", false, "admin" },
                    { "ee7c7819-c7b4-4536-93a9-c12fdd0341cd", 0, "cb16e60d-a5c5-4ba8-9f15-f512297145f7", "driver@gmail.com", true, false, null, null, "DRIVER", "AQAAAAEAACcQAAAAEA9e7UM1YbJMBjaFityxJTNYclfEtfTi6dg4rM6dbn2YyLaLrTtrDuxp8XufOntjuA==", null, false, "fc3e68ef-a56b-466e-befc-7322c667972e", false, "driver" }
                });

            migrationBuilder.InsertData(
                table: "Route",
                columns: new[] { "RouteId", "VehicleId" },
                values: new object[,]
                {
                    { "5a13500d-c8d2-44e1-a6e4-50f1264384a7", "2253d4b4-edba-4041-a314-22968193faf2" },
                    { "b2fee434-d8c6-400f-a932-ab9a394449a5", "2253d4b4-edba-4041-a314-22968193faf2" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e95c8a0e-8a76-4513-8c1c-c03f044970ce", "5adb1532-5c22-4874-8d16-edb976cb9db0" },
                    { "b91737af-72ec-4d5d-b92d-860373ac9ae6", "95277226-4972-44df-ace6-c7e9d513bb1a" },
                    { "4ca3074b-4eca-4860-9e07-7653d8b2c943", "ee7c7819-c7b4-4536-93a9-c12fdd0341cd" }
                });

            migrationBuilder.InsertData(
                table: "Station",
                columns: new[] { "Id", "Latitude", "Longitude", "Name", "RouteId" },
                values: new object[,]
                {
                    { "06a23620-e98d-47bf-87d9-bdbc843ffd6c", 457530100528003.56000000000000m, 212501719692575.72000000000000m, "Fabrica De Bere Timisoara", "5a13500d-c8d2-44e1-a6e4-50f1264384a7" },
                    { "1245d71c-77d4-4ddf-8e27-e0150bf62ffb", 457567215826950.15000000000000m, 212449256988964.84000000000000m, "3 August 1919", "5a13500d-c8d2-44e1-a6e4-50f1264384a7" },
                    { "127e82dc-08af-4d3d-a9b4-c7e9b892a798", 457557493352611.36000000000000m, 212318589875084.56000000000000m, "Hotel Continental", "b2fee434-d8c6-400f-a932-ab9a394449a5" },
                    { "12df9d88-e8a6-45e0-ade4-626548499fcc", 457557493352611.36000000000000m, 212318589875084.56000000000000m, "Hotel Continental", "5a13500d-c8d2-44e1-a6e4-50f1264384a7" },
                    { "1c464244-2c9f-4b07-ac7c-88749b366f26", 457561970168036.10000000000000m, 212213075532377.32000000000000m, "Brediceanu", "b2fee434-d8c6-400f-a932-ab9a394449a5" },
                    { "1f673bc4-2153-470f-a41e-70c5bfc4ea9c", 457556223474490.30000000000000m, 212384271011132.56000000000000m, "Prefectura Judetului Timis", "b2fee434-d8c6-400f-a932-ab9a394449a5" },
                    { "214ee824-ef4a-42ec-93cd-885ba30d2218", 457453343014063.60000000000000m, 212414467905664.74000000000000m, "Sala Olimpia", "b2fee434-d8c6-400f-a932-ab9a394449a5" },
                    { "2178904b-845a-4782-8506-35bfcb3efdd9", 457420058812021.80000000000000m, 212324666500880.03000000000000m, "Piata Crucii", "5a13500d-c8d2-44e1-a6e4-50f1264384a7" },
                    { "21e1f9f4-0f9f-465f-981a-a2ddf8d8d4f4", 457561970168036.10000000000000m, 212213075532377.32000000000000m, "Brediceanu", "5a13500d-c8d2-44e1-a6e4-50f1264384a7" },
                    { "30b4ccf8-72e9-4468-b15d-b22265c61523", 457558725046083.20000000000000m, 212276939799686.0000000000000m, "Piata Libertatii", "5a13500d-c8d2-44e1-a6e4-50f1264384a7" },
                    { "4635b9f8-7b5c-4dfa-a313-6a97e7cd590d", 457558725046083.20000000000000m, 212276939799686.0000000000000m, "Piata Libertatii", "b2fee434-d8c6-400f-a932-ab9a394449a5" },
                    { "4810761d-df3c-4571-8b38-a809b9d2a8cc", 457510922178538.20000000000000m, 212236185720668.60000000000000m, "Catedrala Metropolitana", "5a13500d-c8d2-44e1-a6e4-50f1264384a7" },
                    { "4c59a3ac-50a6-4804-ae7d-5411b98ce1c7", 457562516335078.50000000000000m, 212229088920353.74000000000000m, "Piata Timisoara 700", "5a13500d-c8d2-44e1-a6e4-50f1264384a7" },
                    { "607ab9fb-22e5-49b2-9f7b-d8231c4033a3", 457444445740046.96000000000000m, 212223795184418.44000000000000m, "Parc Doina", "b2fee434-d8c6-400f-a932-ab9a394449a5" },
                    { "756e687e-4e1c-4010-af03-b5a46f3ea07c", 457471572743708.90000000000000m, 212465820971733.73000000000000m, "Deliblata", "b2fee434-d8c6-400f-a932-ab9a394449a5" },
                    { "85ce0a45-d63a-42db-bcb6-bfd80ddf09cb", 457549076999152.70000000000000m, 212210508005243.03000000000000m, "Spitalul de copii", "5a13500d-c8d2-44e1-a6e4-50f1264384a7" },
                    { "88a43c06-2ffb-499e-a8b5-19fb6d3e1198", 457549076999152.70000000000000m, 212210508005243.03000000000000m, "Spitalul de copii", "b2fee434-d8c6-400f-a932-ab9a394449a5" },
                    { "8c000224-66d1-4447-a7be-1b0e9885b0db", 457562516335078.50000000000000m, 212229088920353.74000000000000m, "Piata Timisoara 700", "b2fee434-d8c6-400f-a932-ab9a394449a5" },
                    { "8e0bf118-107e-4573-b1a6-f4a069a6fda5", 457482785901011.70000000000000m, 212191745283552.70000000000000m, "Piata Maria", "5a13500d-c8d2-44e1-a6e4-50f1264384a7" },
                    { "95847550-6ebb-4391-adf5-d1e03931c5b6", 457530100528003.56000000000000m, 212501719692575.72000000000000m, "Fabrica De Bere Timisoara", "b2fee434-d8c6-400f-a932-ab9a394449a5" },
                    { "a342fd32-2f27-465f-94ae-a1acfa6d32ec", 457567215826950.15000000000000m, 212449256988964.84000000000000m, "3 August 1919", "b2fee434-d8c6-400f-a932-ab9a394449a5" },
                    { "ae02a3b0-f2bd-4ad7-bd79-56246ac58bf3", 457453343014063.60000000000000m, 212414467905664.74000000000000m, "Sala Olimpia", "5a13500d-c8d2-44e1-a6e4-50f1264384a7" },
                    { "af7d122b-e763-4c6f-aee3-5419f2d3c7a1", 457556223474490.30000000000000m, 212384271011132.56000000000000m, "Prefectura Judetului Timis", "5a13500d-c8d2-44e1-a6e4-50f1264384a7" },
                    { "afb5c4c2-586e-40f9-a7cd-200e49f3a8cb", 457574950084526.40000000000000m, 212491693964518.30000000000000m, "Piata Traian", "b2fee434-d8c6-400f-a932-ab9a394449a5" },
                    { "b2a62431-a259-4f15-9857-79fd886df737", 457574950084526.40000000000000m, 212491693964518.30000000000000m, "Piata Traian", "5a13500d-c8d2-44e1-a6e4-50f1264384a7" },
                    { "b3723f00-dcb0-4264-a050-e83486b4454b", 457471572743708.90000000000000m, 212465820971733.73000000000000m, "Deliblata", "5a13500d-c8d2-44e1-a6e4-50f1264384a7" },
                    { "b5d57f83-5aae-4120-aeea-66c72ca9499a", 457438856012541.40000000000000m, 212371287092157.85000000000000m, "Cluj", "b2fee434-d8c6-400f-a932-ab9a394449a5" },
                    { "b64be284-7862-462a-83ce-971e6f91e69c", 457420058812021.80000000000000m, 212324666500880.03000000000000m, "Piata Crucii", "b2fee434-d8c6-400f-a932-ab9a394449a5" },
                    { "be7c3a69-9418-4693-a6eb-4302f9612bcf", 457488903942873.50000000000000m, 212527015646313.90000000000000m, "Banatim", "b2fee434-d8c6-400f-a932-ab9a394449a5" },
                    { "d59fb59e-a969-4000-a471-2a90069949f5", 457417625338582.14000000000000m, 212251459649236.10000000000000m, "Piata Nicolae Balcescu", "5a13500d-c8d2-44e1-a6e4-50f1264384a7" },
                    { "d930934e-675f-486f-ab67-29f548c12261", 457438856012541.40000000000000m, 212371287092157.85000000000000m, "Cluj", "5a13500d-c8d2-44e1-a6e4-50f1264384a7" },
                    { "eb42d258-c3e9-4f54-8253-ad979beb67b0", 457510922178538.20000000000000m, 212236185720668.60000000000000m, "Catedrala Metropolitana", "b2fee434-d8c6-400f-a932-ab9a394449a5" },
                    { "edf53b8b-ed23-45a1-821f-a8d7891254d2", 457417625338582.14000000000000m, 212251459649236.10000000000000m, "Piata Nicolae Balcescu", "b2fee434-d8c6-400f-a932-ab9a394449a5" },
                    { "f05caf53-a02e-4b28-9b30-ea1991655002", 457444445740046.96000000000000m, 212223795184418.44000000000000m, "Parc Doina", "5a13500d-c8d2-44e1-a6e4-50f1264384a7" },
                    { "f2fe1403-1a74-47d7-9e72-d4e949c4b502", 457488903942873.50000000000000m, 212527015646313.90000000000000m, "Banatim", "5a13500d-c8d2-44e1-a6e4-50f1264384a7" },
                    { "fa96cc29-2639-44bc-884a-99e4f94748bb", 457482785901011.70000000000000m, 212191745283552.70000000000000m, "Piata Maria", "b2fee434-d8c6-400f-a932-ab9a394449a5" }
                });

            migrationBuilder.InsertData(
                table: "VehicleDriver",
                columns: new[] { "Id", "DriverId", "VehicleId" },
                values: new object[] { "cbf156ef-ee35-4ce2-857a-71d25d0c9243", "ee7c7819-c7b4-4536-93a9-c12fdd0341cd", "2253d4b4-edba-4041-a314-22968193faf2" });

            migrationBuilder.AddForeignKey(
                name: "FK_Route_Vehicle_VehicleId",
                table: "Route",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "VehicleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Station_Route_RouteId",
                table: "Station",
                column: "RouteId",
                principalTable: "Route",
                principalColumn: "RouteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
