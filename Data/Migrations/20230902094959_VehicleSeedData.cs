using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rina.Data.Migrations
{
    public partial class VehicleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Vehicle",
                columns: new[] { "VehicleId", "Latitude", "Longitude", "Name", "Type" },
                values: new object[] { "2253d4b4-edba-4041-a314-22968193faf2", 0m, 0m, "6", "Tram" });

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
                table: "Route",
                columns: new[] { "RouteId", "VehicleId" },
                values: new object[,]
                {
                    { "5a13500d-c8d2-44e1-a6e4-50f1264384a7", "2253d4b4-edba-4041-a314-22968193faf2" },
                    { "b2fee434-d8c6-400f-a932-ab9a394449a5", "2253d4b4-edba-4041-a314-22968193faf2" }
                });

            migrationBuilder.InsertData(
                table: "VehicleDriver",
                columns: new[] { "Id", "DriverId", "VehicleId" },
                values: new object[] { "cbf156ef-ee35-4ce2-857a-71d25d0c9243", "ee7c7819-c7b4-4536-93a9-c12fdd0341cd", "2253d4b4-edba-4041-a314-22968193faf2" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: "2253d4b4-edba-4041-a314-22968193faf2");

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
        }
    }
}
