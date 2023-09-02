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
                    { "2df3f11a-208c-4adc-b57c-72be8de24bbb", "2df3f11a-208c-4adc-b57c-72be8de24bbb", "User", "USER" },
                    { "3e6389ce-8bef-401c-857c-ea774ed51375", "3e6389ce-8bef-401c-857c-ea774ed51375", "Driver", "DRIVER" },
                    { "fedeb051-fd94-4bd7-8b18-b4cca045083e", "fedeb051-fd94-4bd7-8b18-b4cca045083e", "Administrator", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "56380312-f4d8-41da-a03a-4e22f88d62d2", 0, "fc208c1f-eecd-48ae-b295-02683f04f216", "andreea@gmail.com", true, false, null, null, "ANDREEA", "AQAAAAEAACcQAAAAELyXh1bOperO/3PCQ/U5NdRNC4z4xZU+d7qh/oRllId5XWt4ahweZLlpPsW8kucKPA==", null, false, "480a133c-4a1c-4c21-913c-92d41f9d3fe7", false, "andreea" },
                    { "8215d526-aa55-4c3e-a8bc-4b37cd77c11b", 0, "d1a9130a-b98d-423e-8988-d5d9f4081d8e", "admin@gmail.com", true, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEN66hhSfTI0SpcL+OAXSDtEDfzIrxnZ6hJPkD8UjF0fu3CxmW0tJ7wQrUX5TnmjE5w==", null, false, "78e816c1-c345-4d4b-9c47-5b8a4eb89a74", false, "admin" },
                    { "863b3a5c-0cdb-4054-bd4e-4b4063d24ca1", 0, "80cae638-7e09-475b-a406-3c3c701b29e6", "driver@gmail.com", true, false, null, null, "DRIVER", "AQAAAAEAACcQAAAAECHBs9BqtioiuIKYy0OLDc0ykfmV4Ctl0eSj8a0W3gM7JA2MPz79+kBFFVDukXJRZA==", null, false, "decc4d4e-8aef-4dba-8fc7-bf0a70379f8f", false, "driver" }
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
                    { "2df3f11a-208c-4adc-b57c-72be8de24bbb", "56380312-f4d8-41da-a03a-4e22f88d62d2" },
                    { "fedeb051-fd94-4bd7-8b18-b4cca045083e", "8215d526-aa55-4c3e-a8bc-4b37cd77c11b" },
                    { "3e6389ce-8bef-401c-857c-ea774ed51375", "863b3a5c-0cdb-4054-bd4e-4b4063d24ca1" }
                });

            migrationBuilder.InsertData(
                table: "Route",
                columns: new[] { "RouteId", "VehicleId" },
                values: new object[,]
                {
                    { "867eab75-1f1c-4742-bf4f-d0d01fae1b2e", "2253d4b4-edba-4041-a314-22968193faf2" },
                    { "f7e2966e-1b45-4696-8c48-9f73f902c793", "2253d4b4-edba-4041-a314-22968193faf2" }
                });

            migrationBuilder.InsertData(
                table: "VehicleDriver",
                columns: new[] { "Id", "DriverId", "VehicleId" },
                values: new object[] { "3ab9d25f-abc0-4a4c-9e01-6d0c0b01bf8c", "863b3a5c-0cdb-4054-bd4e-4b4063d24ca1", "2253d4b4-edba-4041-a314-22968193faf2" });

            migrationBuilder.InsertData(
                table: "Station",
                columns: new[] { "Id", "Latitude", "Longitude", "Name", "RouteId" },
                values: new object[,]
                {
                    { "05e26dc5-a033-4245-8b1f-5a5bb3ca2ad3", 45.744444574004696m, 21.222379518441844m, "Parc Doina", "867eab75-1f1c-4742-bf4f-d0d01fae1b2e" },
                    { "07713569-7388-4cd5-8103-00db588c26bf", 45.75625163350785m, 21.222908892035374m, "Piata Timisoara 700", "f7e2966e-1b45-4696-8c48-9f73f902c793" },
                    { "0fc17ad1-06ed-493c-913f-b017fee39cd2", 45.75625163350785m, 21.222908892035374m, "Piata Timisoara 700", "867eab75-1f1c-4742-bf4f-d0d01fae1b2e" },
                    { "11095ebb-9e3b-4eb6-90a6-6f4edc0dbd6f", 45.75490769991527m, 21.221050800524303m, "Spitalul de copii", "867eab75-1f1c-4742-bf4f-d0d01fae1b2e" },
                    { "12334e36-8c90-4e4b-bb0b-ec62692d0d87", 45.74533430140636m, 21.241446790566474m, "Sala Olimpia", "f7e2966e-1b45-4696-8c48-9f73f902c793" },
                    { "1b07cd09-7cbd-4126-b5f8-e1b14421620e", 45.753010052800356m, 21.250171969257572m, "Fabrica De Bere Timisoara", "867eab75-1f1c-4742-bf4f-d0d01fae1b2e" },
                    { "2048477e-e581-48b2-a1f3-287004d9ea9b", 45.744444574004696m, 21.222379518441844m, "Parc Doina", "f7e2966e-1b45-4696-8c48-9f73f902c793" },
                    { "237a4151-8b0b-4ad1-b519-0f4994887fa6", 45.756721582695015m, 21.244925698896484m, "3 August 1919", "f7e2966e-1b45-4696-8c48-9f73f902c793" },
                    { "2ea95114-b9ef-48f1-8572-50e0d644592f", 45.74715727437089m, 21.246582097173373m, "Deliblata", "f7e2966e-1b45-4696-8c48-9f73f902c793" },
                    { "373c411b-928a-437d-8820-ac97aee23a8e", 45.756721582695015m, 21.244925698896484m, "3 August 1919", "867eab75-1f1c-4742-bf4f-d0d01fae1b2e" },
                    { "3adfe604-37f1-4612-8725-d71bb490c06c", 45.74889039428735m, 21.25270156463139m, "Banatim", "f7e2966e-1b45-4696-8c48-9f73f902c793" },
                    { "475397c7-3e36-4e85-8d31-9da5ae544813", 45.74827859010117m, 21.21917452835527m, "Piata Maria", "f7e2966e-1b45-4696-8c48-9f73f902c793" },
                    { "507e8d1e-f188-4e0c-888b-15a431849d1c", 45.74533430140636m, 21.241446790566474m, "Sala Olimpia", "867eab75-1f1c-4742-bf4f-d0d01fae1b2e" },
                    { "664ad5b5-6eb3-4068-a3a7-d304ee9f1467", 45.74200588120218m, 21.232466650088003m, "Piata Crucii", "f7e2966e-1b45-4696-8c48-9f73f902c793" },
                    { "75265763-4bf3-493a-bd7e-7d30d59433ab", 45.741762533858214m, 21.22514596492361m, "Piata Nicolae Balcescu", "867eab75-1f1c-4742-bf4f-d0d01fae1b2e" },
                    { "7a8b9f5d-fa19-4ba4-aea4-779c0ec6f4ee", 45.755749335261136m, 21.231858987508456m, "Hotel Continental", "f7e2966e-1b45-4696-8c48-9f73f902c793" },
                    { "8039e1cc-2ac1-400e-a26e-915c168c1798", 45.75619701680361m, 21.221307553237732m, "Brediceanu", "f7e2966e-1b45-4696-8c48-9f73f902c793" },
                    { "8a0d5e91-9351-43d4-ac2f-92d19a2c8c19", 45.741762533858214m, 21.22514596492361m, "Piata Nicolae Balcescu", "f7e2966e-1b45-4696-8c48-9f73f902c793" },
                    { "904ecf7b-f515-468b-9747-563fda755c21", 45.74715727437089m, 21.246582097173373m, "Deliblata", "867eab75-1f1c-4742-bf4f-d0d01fae1b2e" },
                    { "96f9e582-e473-4cd3-9ce9-fab5ebd2a921", 45.74388560125414m, 21.237128709215785m, "Cluj", "f7e2966e-1b45-4696-8c48-9f73f902c793" },
                    { "a0c4e6a7-6c8b-4712-b453-49b4cc55b21f", 45.74388560125414m, 21.237128709215785m, "Cluj", "867eab75-1f1c-4742-bf4f-d0d01fae1b2e" },
                    { "a6536c21-6d48-4e2e-b00e-dada1e66daa3", 45.75749500845264m, 21.24916939645183m, "Piata Traian", "867eab75-1f1c-4742-bf4f-d0d01fae1b2e" },
                    { "a8689b1c-280e-4b8c-a1a2-f1ea7e1a618e", 45.755749335261136m, 21.231858987508456m, "Hotel Continental", "867eab75-1f1c-4742-bf4f-d0d01fae1b2e" },
                    { "ad1cd307-2e26-4393-a8a9-7285699be395", 45.75587250460832m, 21.2276939799686m, "Piata Libertatii", "867eab75-1f1c-4742-bf4f-d0d01fae1b2e" },
                    { "b9f435f1-76bd-45b3-a8bb-fe3f2ff0f825", 45.74200588120218m, 21.232466650088003m, "Piata Crucii", "867eab75-1f1c-4742-bf4f-d0d01fae1b2e" },
                    { "bbf2e1bf-107c-4ac6-a452-70f8d25dbb06", 45.75749500845264m, 21.24916939645183m, "Piata Traian", "f7e2966e-1b45-4696-8c48-9f73f902c793" },
                    { "bfea3de7-7c01-478b-b827-cb50616c8502", 45.753010052800356m, 21.250171969257572m, "Fabrica De Bere Timisoara", "f7e2966e-1b45-4696-8c48-9f73f902c793" },
                    { "c3a4a7b0-d4bd-4eb4-85c5-b8a39c42f8d5", 45.75562234744903m, 21.238427101113256m, "Prefectura Judetului Timis", "f7e2966e-1b45-4696-8c48-9f73f902c793" },
                    { "ca32c507-7990-40ea-b9fd-15381428aedd", 45.75587250460832m, 21.2276939799686m, "Piata Libertatii", "f7e2966e-1b45-4696-8c48-9f73f902c793" },
                    { "dd4bda6a-af2a-4969-a3c0-2d61a85c5804", 45.75109221785382m, 21.22361857206686m, "Catedrala Metropolitana", "867eab75-1f1c-4742-bf4f-d0d01fae1b2e" },
                    { "e032bfc6-960d-401f-96c0-0a1f8e773e9e", 45.74889039428735m, 21.25270156463139m, "Banatim", "867eab75-1f1c-4742-bf4f-d0d01fae1b2e" },
                    { "e6ae001f-dfbf-4c68-824d-049e9ae06245", 45.75619701680361m, 21.221307553237732m, "Brediceanu", "867eab75-1f1c-4742-bf4f-d0d01fae1b2e" },
                    { "e934adfc-4c99-4631-b162-1090d2ce38f5", 45.74827859010117m, 21.21917452835527m, "Piata Maria", "867eab75-1f1c-4742-bf4f-d0d01fae1b2e" },
                    { "f918362a-9d23-4bd2-ba15-adc306b40c2c", 45.75490769991527m, 21.221050800524303m, "Spitalul de copii", "f7e2966e-1b45-4696-8c48-9f73f902c793" },
                    { "fc641f5a-ca24-4b8d-83ce-d1791b9cc308", 45.75562234744903m, 21.238427101113256m, "Prefectura Judetului Timis", "867eab75-1f1c-4742-bf4f-d0d01fae1b2e" },
                    { "fee6cc49-ab17-4027-9a28-f85c4e173a90", 45.75109221785382m, 21.22361857206686m, "Catedrala Metropolitana", "f7e2966e-1b45-4696-8c48-9f73f902c793" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2df3f11a-208c-4adc-b57c-72be8de24bbb", "56380312-f4d8-41da-a03a-4e22f88d62d2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fedeb051-fd94-4bd7-8b18-b4cca045083e", "8215d526-aa55-4c3e-a8bc-4b37cd77c11b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3e6389ce-8bef-401c-857c-ea774ed51375", "863b3a5c-0cdb-4054-bd4e-4b4063d24ca1" });

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "05e26dc5-a033-4245-8b1f-5a5bb3ca2ad3");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "07713569-7388-4cd5-8103-00db588c26bf");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "0fc17ad1-06ed-493c-913f-b017fee39cd2");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "11095ebb-9e3b-4eb6-90a6-6f4edc0dbd6f");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "12334e36-8c90-4e4b-bb0b-ec62692d0d87");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "1b07cd09-7cbd-4126-b5f8-e1b14421620e");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "2048477e-e581-48b2-a1f3-287004d9ea9b");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "237a4151-8b0b-4ad1-b519-0f4994887fa6");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "2ea95114-b9ef-48f1-8572-50e0d644592f");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "373c411b-928a-437d-8820-ac97aee23a8e");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "3adfe604-37f1-4612-8725-d71bb490c06c");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "475397c7-3e36-4e85-8d31-9da5ae544813");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "507e8d1e-f188-4e0c-888b-15a431849d1c");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "664ad5b5-6eb3-4068-a3a7-d304ee9f1467");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "75265763-4bf3-493a-bd7e-7d30d59433ab");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "7a8b9f5d-fa19-4ba4-aea4-779c0ec6f4ee");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "8039e1cc-2ac1-400e-a26e-915c168c1798");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "8a0d5e91-9351-43d4-ac2f-92d19a2c8c19");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "904ecf7b-f515-468b-9747-563fda755c21");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "96f9e582-e473-4cd3-9ce9-fab5ebd2a921");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "a0c4e6a7-6c8b-4712-b453-49b4cc55b21f");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "a6536c21-6d48-4e2e-b00e-dada1e66daa3");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "a8689b1c-280e-4b8c-a1a2-f1ea7e1a618e");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "ad1cd307-2e26-4393-a8a9-7285699be395");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "b9f435f1-76bd-45b3-a8bb-fe3f2ff0f825");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "bbf2e1bf-107c-4ac6-a452-70f8d25dbb06");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "bfea3de7-7c01-478b-b827-cb50616c8502");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "c3a4a7b0-d4bd-4eb4-85c5-b8a39c42f8d5");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "ca32c507-7990-40ea-b9fd-15381428aedd");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "dd4bda6a-af2a-4969-a3c0-2d61a85c5804");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "e032bfc6-960d-401f-96c0-0a1f8e773e9e");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "e6ae001f-dfbf-4c68-824d-049e9ae06245");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "e934adfc-4c99-4631-b162-1090d2ce38f5");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "f918362a-9d23-4bd2-ba15-adc306b40c2c");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "fc641f5a-ca24-4b8d-83ce-d1791b9cc308");

            migrationBuilder.DeleteData(
                table: "Station",
                keyColumn: "Id",
                keyValue: "fee6cc49-ab17-4027-9a28-f85c4e173a90");

            migrationBuilder.DeleteData(
                table: "VehicleDriver",
                keyColumn: "Id",
                keyValue: "3ab9d25f-abc0-4a4c-9e01-6d0c0b01bf8c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2df3f11a-208c-4adc-b57c-72be8de24bbb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e6389ce-8bef-401c-857c-ea774ed51375");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fedeb051-fd94-4bd7-8b18-b4cca045083e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56380312-f4d8-41da-a03a-4e22f88d62d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8215d526-aa55-4c3e-a8bc-4b37cd77c11b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "863b3a5c-0cdb-4054-bd4e-4b4063d24ca1");

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteId",
                keyValue: "867eab75-1f1c-4742-bf4f-d0d01fae1b2e");

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteId",
                keyValue: "f7e2966e-1b45-4696-8c48-9f73f902c793");

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: "2253d4b4-edba-4041-a314-22968193faf2");

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
        }
    }
}
