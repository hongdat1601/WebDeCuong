using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebDeCuong.Data.Migrations
{
    /// <inheritdoc />
    public partial class RequestSubject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0f0bb29-0da5-41d0-8462-221076d62711", "24acb884-bafe-4b6f-b0cc-1170ce9a3c3a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0f0bb29-0da5-41d0-8462-221076d62711", "2a87e244-904a-49d8-abba-9928dcaa822a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0f0bb29-0da5-41d0-8462-221076d62711", "30cac737-b36f-4ff9-85f5-724a7f5c21f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0f0bb29-0da5-41d0-8462-221076d62711", "3b3a0523-1091-4e78-8a4f-1ed1a48690ca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bfb7a4a0-f00f-4588-970d-7228eb0905e1", "4c5980fb-bc00-45d3-a214-9e7119c35035" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0f0bb29-0da5-41d0-8462-221076d62711", "5bd39b10-54e2-46e1-8743-75baa4c1a0b6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0f0bb29-0da5-41d0-8462-221076d62711", "5de277f0-1433-4f7a-b134-43c6267af9fd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0f0bb29-0da5-41d0-8462-221076d62711", "d7271325-70a8-40a4-82e6-a727aaf94a00" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0f0bb29-0da5-41d0-8462-221076d62711", "e9d67325-24ac-43e2-a40c-e2e1bd396ad7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0f0bb29-0da5-41d0-8462-221076d62711", "fa2b8e71-65fc-403b-9152-7a2ea73095c5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0f0bb29-0da5-41d0-8462-221076d62711", "ff058804-d565-4d98-b968-151fd27538c1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0f0bb29-0da5-41d0-8462-221076d62711");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfb7a4a0-f00f-4588-970d-7228eb0905e1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24acb884-bafe-4b6f-b0cc-1170ce9a3c3a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2a87e244-904a-49d8-abba-9928dcaa822a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30cac737-b36f-4ff9-85f5-724a7f5c21f0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3b3a0523-1091-4e78-8a4f-1ed1a48690ca");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4c5980fb-bc00-45d3-a214-9e7119c35035");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5bd39b10-54e2-46e1-8743-75baa4c1a0b6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5de277f0-1433-4f7a-b134-43c6267af9fd");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d7271325-70a8-40a4-82e6-a727aaf94a00");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e9d67325-24ac-43e2-a40c-e2e1bd396ad7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fa2b8e71-65fc-403b-9152-7a2ea73095c5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ff058804-d565-4d98-b968-151fd27538c1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Subjects",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "RequestUserMail",
                table: "Subjects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dd1ef747-7efb-4afc-ae32-dcb20e5480a4", "dd1ef747-7efb-4afc-ae32-dcb20e5480a4", "Admin", "ADMIN" },
                    { "dda0b807-a9ea-44af-b353-167038c65d2c", "dda0b807-a9ea-44af-b353-167038c65d2c", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "0000001",
                column: "RequestUserMail",
                value: null);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "0000002",
                column: "RequestUserMail",
                value: null);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "0000003",
                column: "RequestUserMail",
                value: null);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "0000004",
                column: "RequestUserMail",
                value: null);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "0000005",
                column: "RequestUserMail",
                value: null);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "Faculty", "FullName", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "02e989ea-81aa-4019-987e-b703bde09d19", 0, "4182fb23-aecf-4ba9-9dcb-5507b9db69de", new DateTime(2023, 4, 30, 18, 50, 27, 473, DateTimeKind.Local).AddTicks(9859), "user0@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_0", false, false, null, "USER0@GMAIL.COM", "USER0@GMAIL.COM", "AQAAAAIAAYagAAAAEHoX8tLyfuhZfQavPpBkvRboDHMqK7pnn36hDmAp0F/WRvoQSR0ZM4y6fRAX47NTJg==", "0900000000", false, "TP.HCM", "849310d8-5354-4893-81f4-7fb069e585cd", false, "user0@gmail.com" },
                    { "05c9aa35-200a-4879-a954-f1f44da52637", 0, "6040aa99-edea-4063-849d-fbaa2fa29fa7", new DateTime(2023, 4, 30, 18, 50, 28, 407, DateTimeKind.Local).AddTicks(7096), "user8@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_8", false, false, null, "USER8@GMAIL.COM", "USER8@GMAIL.COM", "AQAAAAIAAYagAAAAEKZcEXY0HWhHdXtmYB6GwoPalDGSsWGOuI2saIJnnA2FNIovHI+vgAuGCgC1IPsg9Q==", "0900000000", false, "TP.HCM", "96bc85ee-fa42-4b4a-b3ca-1b861fd89a2a", false, "user8@gmail.com" },
                    { "47b21a7a-7183-4502-a26d-c7cb9f71f537", 0, "405c5595-1cf8-40ea-9baf-4d518cb07a36", new DateTime(2023, 4, 30, 18, 50, 27, 373, DateTimeKind.Local).AddTicks(8698), "admin@gmail.com", false, "Khoa học máy tính", "Nguyễn Văn A", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAED/72bz5YPT9ugW4dPXvYfZbKlKUPJSTVmKx+BsnFFe7DrV9yJrdjzT2Xtf93HtgDQ==", "0900000000", false, "TP.HCM", "91b354d5-4928-4c55-a470-be0e88533a8f", false, "admin@gmail.com" },
                    { "7b56b6b7-9920-456f-8fb7-fc1fa7840638", 0, "89de9de8-e9fb-40cc-825d-dccf20e746e4", new DateTime(2023, 4, 30, 18, 50, 27, 966, DateTimeKind.Local).AddTicks(8311), "user4@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_4", false, false, null, "USER4@GMAIL.COM", "USER4@GMAIL.COM", "AQAAAAIAAYagAAAAEG4TDBJhC8dHpIdhyL1V6S+sqAUUZ8qAph2lWt6v2ezmRrr3zalH0c3pK2JsK4lckQ==", "0900000000", false, "TP.HCM", "c4c03b30-1102-451a-907c-4cc7ae9ad7bd", false, "user4@gmail.com" },
                    { "8509d33d-f7a6-4371-91f0-6e183ff58cd6", 0, "283ccb34-893e-409c-8b56-897adbfcb469", new DateTime(2023, 4, 30, 18, 50, 28, 179, DateTimeKind.Local).AddTicks(9745), "user6@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_6", false, false, null, "USER6@GMAIL.COM", "USER6@GMAIL.COM", "AQAAAAIAAYagAAAAEKiiMzWcAUPRyJUl7FioP1PYVfRdfDkJR2wZ9Imv9k7zjrH0tabA8nOCQ5NG2y9lMQ==", "0900000000", false, "TP.HCM", "50c98096-4d4f-47dd-9b86-99c67a4d974a", false, "user6@gmail.com" },
                    { "8f10c35c-85b8-490c-a781-b18e1153209d", 0, "77881183-643c-4650-9b40-5e148280f9d1", new DateTime(2023, 4, 30, 18, 50, 28, 80, DateTimeKind.Local).AddTicks(1863), "user5@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_5", false, false, null, "USER5@GMAIL.COM", "USER5@GMAIL.COM", "AQAAAAIAAYagAAAAENa49ihYPPGa1vxwBdWGQqs/nvsyTEtE54cTxksij8MucTBl8zv/luQeVhjIRnptlA==", "0900000000", false, "TP.HCM", "65fad648-ac2a-4585-90c4-cafe527aacde", false, "user5@gmail.com" },
                    { "92eceb0f-5478-419b-93a2-91c7b35469a5", 0, "246f403c-27f7-4cf4-8ba1-f917534c5241", new DateTime(2023, 4, 30, 18, 50, 28, 532, DateTimeKind.Local).AddTicks(4862), "user9@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_9", false, false, null, "USER9@GMAIL.COM", "USER9@GMAIL.COM", "AQAAAAIAAYagAAAAEIK9z8Jut7uJuXMQlNwBpYGOuP1wKHmyOK4RTB6n7bLfKtlh8oa53+J2vlh7h+ceJw==", "0900000000", false, "TP.HCM", "fe447a26-d80f-4ee7-8cc1-25f05b40c83f", false, "user9@gmail.com" },
                    { "9b6a9810-16e1-4c19-bb7c-a39d5ad12ab3", 0, "8d8fa2b1-80d3-445f-93e2-ac0d43fcd2cc", new DateTime(2023, 4, 30, 18, 50, 27, 578, DateTimeKind.Local).AddTicks(8320), "user1@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_1", false, false, null, "USER1@GMAIL.COM", "USER1@GMAIL.COM", "AQAAAAIAAYagAAAAEFTSh8puRWvWPQ5Zw504kFZIjFhuDbTbG3rOMgawuA7nht5dihV8xZ3lg6HzeS8esQ==", "0900000000", false, "TP.HCM", "d0ac3639-bc57-48a1-9f67-11c67f3b9256", false, "user1@gmail.com" },
                    { "e1ccf146-c8d4-4e38-baef-42ccf3850439", 0, "f0e58500-6c95-4751-8dcf-891dab9d06d4", new DateTime(2023, 4, 30, 18, 50, 27, 724, DateTimeKind.Local).AddTicks(7758), "user2@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_2", false, false, null, "USER2@GMAIL.COM", "USER2@GMAIL.COM", "AQAAAAIAAYagAAAAEMpLuycnR7IVMTKSk03HSM2/ZpKkXu1G9yEmWbAGOtOpTgc7bAM86durgdl0u4J5cg==", "0900000000", false, "TP.HCM", "a54c91be-fda6-43dc-89f1-18179c864655", false, "user2@gmail.com" },
                    { "eb363398-dbc6-46fb-b264-cdc07e8524be", 0, "513423f9-c8e4-4268-8aa3-e834698367f7", new DateTime(2023, 4, 30, 18, 50, 27, 844, DateTimeKind.Local).AddTicks(3202), "user3@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_3", false, false, null, "USER3@GMAIL.COM", "USER3@GMAIL.COM", "AQAAAAIAAYagAAAAEMF1cMhMeIkO/V4tKn7vraaEQcm6l0yK3Y/uUK4mzbUoV2WfK7aUa0wcwyqByKNUIA==", "0900000000", false, "TP.HCM", "b0905ca8-e006-4f91-b861-1025935676a5", false, "user3@gmail.com" },
                    { "f6113f68-18f3-465a-a929-21e433760178", 0, "4ac3dfd9-e8c9-4def-b6f0-d4bfe0cfb3f0", new DateTime(2023, 4, 30, 18, 50, 28, 295, DateTimeKind.Local).AddTicks(7297), "user7@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_7", false, false, null, "USER7@GMAIL.COM", "USER7@GMAIL.COM", "AQAAAAIAAYagAAAAEAazOxkxVed0AhcQMaMkQBYZVpjDyi1y5SjiM5nQEdipP5vqfkRT03pR3mljXy+8CA==", "0900000000", false, "TP.HCM", "df334723-574b-4264-abff-eaece51bd12b", false, "user7@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "dda0b807-a9ea-44af-b353-167038c65d2c", "02e989ea-81aa-4019-987e-b703bde09d19" },
                    { "dda0b807-a9ea-44af-b353-167038c65d2c", "05c9aa35-200a-4879-a954-f1f44da52637" },
                    { "dd1ef747-7efb-4afc-ae32-dcb20e5480a4", "47b21a7a-7183-4502-a26d-c7cb9f71f537" },
                    { "dda0b807-a9ea-44af-b353-167038c65d2c", "7b56b6b7-9920-456f-8fb7-fc1fa7840638" },
                    { "dda0b807-a9ea-44af-b353-167038c65d2c", "8509d33d-f7a6-4371-91f0-6e183ff58cd6" },
                    { "dda0b807-a9ea-44af-b353-167038c65d2c", "8f10c35c-85b8-490c-a781-b18e1153209d" },
                    { "dda0b807-a9ea-44af-b353-167038c65d2c", "92eceb0f-5478-419b-93a2-91c7b35469a5" },
                    { "dda0b807-a9ea-44af-b353-167038c65d2c", "9b6a9810-16e1-4c19-bb7c-a39d5ad12ab3" },
                    { "dda0b807-a9ea-44af-b353-167038c65d2c", "e1ccf146-c8d4-4e38-baef-42ccf3850439" },
                    { "dda0b807-a9ea-44af-b353-167038c65d2c", "eb363398-dbc6-46fb-b264-cdc07e8524be" },
                    { "dda0b807-a9ea-44af-b353-167038c65d2c", "f6113f68-18f3-465a-a929-21e433760178" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_Name",
                table: "Subjects",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Subjects_Name",
                table: "Subjects");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dda0b807-a9ea-44af-b353-167038c65d2c", "02e989ea-81aa-4019-987e-b703bde09d19" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dda0b807-a9ea-44af-b353-167038c65d2c", "05c9aa35-200a-4879-a954-f1f44da52637" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dd1ef747-7efb-4afc-ae32-dcb20e5480a4", "47b21a7a-7183-4502-a26d-c7cb9f71f537" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dda0b807-a9ea-44af-b353-167038c65d2c", "7b56b6b7-9920-456f-8fb7-fc1fa7840638" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dda0b807-a9ea-44af-b353-167038c65d2c", "8509d33d-f7a6-4371-91f0-6e183ff58cd6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dda0b807-a9ea-44af-b353-167038c65d2c", "8f10c35c-85b8-490c-a781-b18e1153209d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dda0b807-a9ea-44af-b353-167038c65d2c", "92eceb0f-5478-419b-93a2-91c7b35469a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dda0b807-a9ea-44af-b353-167038c65d2c", "9b6a9810-16e1-4c19-bb7c-a39d5ad12ab3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dda0b807-a9ea-44af-b353-167038c65d2c", "e1ccf146-c8d4-4e38-baef-42ccf3850439" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dda0b807-a9ea-44af-b353-167038c65d2c", "eb363398-dbc6-46fb-b264-cdc07e8524be" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dda0b807-a9ea-44af-b353-167038c65d2c", "f6113f68-18f3-465a-a929-21e433760178" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd1ef747-7efb-4afc-ae32-dcb20e5480a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dda0b807-a9ea-44af-b353-167038c65d2c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "02e989ea-81aa-4019-987e-b703bde09d19");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "05c9aa35-200a-4879-a954-f1f44da52637");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47b21a7a-7183-4502-a26d-c7cb9f71f537");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7b56b6b7-9920-456f-8fb7-fc1fa7840638");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8509d33d-f7a6-4371-91f0-6e183ff58cd6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8f10c35c-85b8-490c-a781-b18e1153209d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "92eceb0f-5478-419b-93a2-91c7b35469a5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9b6a9810-16e1-4c19-bb7c-a39d5ad12ab3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e1ccf146-c8d4-4e38-baef-42ccf3850439");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "eb363398-dbc6-46fb-b264-cdc07e8524be");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f6113f68-18f3-465a-a929-21e433760178");

            migrationBuilder.DropColumn(
                name: "RequestUserMail",
                table: "Subjects");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Subjects",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b0f0bb29-0da5-41d0-8462-221076d62711", "b0f0bb29-0da5-41d0-8462-221076d62711", "User", "USER" },
                    { "bfb7a4a0-f00f-4588-970d-7228eb0905e1", "bfb7a4a0-f00f-4588-970d-7228eb0905e1", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "Faculty", "FullName", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "24acb884-bafe-4b6f-b0cc-1170ce9a3c3a", 0, "f7f8ae66-323b-417d-aeb4-04a18f3483a8", new DateTime(2023, 4, 24, 9, 8, 29, 146, DateTimeKind.Local).AddTicks(1090), "user2@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_2", false, false, null, "USER2@GMAIL.COM", "USER2@GMAIL.COM", "AQAAAAIAAYagAAAAEFlP+vIAubpoHGRgjOYqiFEr2A5r1L09jSxJKuchfVRMtTDo75muvFWcRvsbqQnLtA==", "0900000000", false, "TP.HCM", "7f060683-53ae-4dab-808e-7fa1aea2be93", false, "user2@gmail.com" },
                    { "2a87e244-904a-49d8-abba-9928dcaa822a", 0, "5ff296e1-e5ec-4692-923e-055873a1fc30", new DateTime(2023, 4, 24, 9, 8, 29, 380, DateTimeKind.Local).AddTicks(7900), "user9@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_9", false, false, null, "USER9@GMAIL.COM", "USER9@GMAIL.COM", "AQAAAAIAAYagAAAAEB0efFLPyf10gUAl/Ax67yppqeaOHnYRyXm9WKRO7RGa6K4ZMLOreZL9Il1lKF515g==", "0900000000", false, "TP.HCM", "d47ce50c-f4a1-4a4e-afa6-0e507d927e84", false, "user9@gmail.com" },
                    { "30cac737-b36f-4ff9-85f5-724a7f5c21f0", 0, "10245187-844d-4f21-9a78-86db9db1df01", new DateTime(2023, 4, 24, 9, 8, 29, 78, DateTimeKind.Local).AddTicks(2910), "user0@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_0", false, false, null, "USER0@GMAIL.COM", "USER0@GMAIL.COM", "AQAAAAIAAYagAAAAEIyKmXNBXABu/dy0ZENFY3luX3BM3CIQG2u5s3gV1YZGO7btjAOepF0LdKKq3ba/oQ==", "0900000000", false, "TP.HCM", "b3535039-431f-4077-947d-8135a61030a0", false, "user0@gmail.com" },
                    { "3b3a0523-1091-4e78-8a4f-1ed1a48690ca", 0, "898b1ac4-58ea-4770-8503-94a1a0810045", new DateTime(2023, 4, 24, 9, 8, 29, 112, DateTimeKind.Local).AddTicks(3520), "user1@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_1", false, false, null, "USER1@GMAIL.COM", "USER1@GMAIL.COM", "AQAAAAIAAYagAAAAEL6FgyJbAJqLlE5RRl72AFnba8XpwEL2RYVkk+OmGl3Lzc+//8lDYgJc5U4om8Gu8g==", "0900000000", false, "TP.HCM", "9d201ef5-b0fe-4e30-af4a-d25dc9659ba9", false, "user1@gmail.com" },
                    { "4c5980fb-bc00-45d3-a214-9e7119c35035", 0, "dc4061db-0db2-461a-990b-b7d3cafe7a7f", new DateTime(2023, 4, 24, 9, 8, 29, 46, DateTimeKind.Local).AddTicks(2350), "admin@gmail.com", false, "Khoa học máy tính", "Nguyễn Văn A", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEDsa1qyJcOAoUD3gZPRFeuiKvdfJ8EAfx9trOrmXKNkZtJwn96bIpz84XXdkOFkcAQ==", "0900000000", false, "TP.HCM", "f1603023-0515-4daa-b6ff-35d82eed2450", false, "admin@gmail.com" },
                    { "5bd39b10-54e2-46e1-8743-75baa4c1a0b6", 0, "d210938c-9aa2-4f54-8532-7104d48a1ff7", new DateTime(2023, 4, 24, 9, 8, 29, 213, DateTimeKind.Local).AddTicks(920), "user4@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_4", false, false, null, "USER4@GMAIL.COM", "USER4@GMAIL.COM", "AQAAAAIAAYagAAAAEGwvEK8CVEQMjqfAzWqwmgQElsjCR7alKCeGvf3rlqc8b4qhfzIh//rY3X72gTvAqg==", "0900000000", false, "TP.HCM", "6aaa1e89-bb57-4d53-9d09-27b5bf127d00", false, "user4@gmail.com" },
                    { "5de277f0-1433-4f7a-b134-43c6267af9fd", 0, "22f59cc1-cad3-497c-902e-f69573cbc110", new DateTime(2023, 4, 24, 9, 8, 29, 179, DateTimeKind.Local).AddTicks(7960), "user3@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_3", false, false, null, "USER3@GMAIL.COM", "USER3@GMAIL.COM", "AQAAAAIAAYagAAAAEA8osIDwyl+N4XJJWHanHI7UG6tZrR1h+gg1fd0/Xy+2saVDU/1CGXj2FMCG0J2Q3Q==", "0900000000", false, "TP.HCM", "cd58bbba-17c1-4bdb-bfff-13100736044f", false, "user3@gmail.com" },
                    { "d7271325-70a8-40a4-82e6-a727aaf94a00", 0, "7e8b0e30-2248-43e1-adab-87b518757401", new DateTime(2023, 4, 24, 9, 8, 29, 278, DateTimeKind.Local).AddTicks(2240), "user6@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_6", false, false, null, "USER6@GMAIL.COM", "USER6@GMAIL.COM", "AQAAAAIAAYagAAAAEEAJwyZjrCcB2Aw1lGToirLWd6NOTWnLhyly/ihDGYbSSFzVVugQ38AuoZ4B71hPVg==", "0900000000", false, "TP.HCM", "b0f204c1-2cd6-4e50-a768-43e4e966b1b8", false, "user6@gmail.com" },
                    { "e9d67325-24ac-43e2-a40c-e2e1bd396ad7", 0, "87f31bcf-dd71-4b8d-b3bb-58cc68b4b123", new DateTime(2023, 4, 24, 9, 8, 29, 312, DateTimeKind.Local).AddTicks(4000), "user7@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_7", false, false, null, "USER7@GMAIL.COM", "USER7@GMAIL.COM", "AQAAAAIAAYagAAAAEIw64TXDITzAEF0fVeh+wQdic1sdkjQZvsCSsinlMz+cagXntBwdRu3fHJ3nzZLorg==", "0900000000", false, "TP.HCM", "e62ea805-8483-4451-a1bc-f2727fe06f6d", false, "user7@gmail.com" },
                    { "fa2b8e71-65fc-403b-9152-7a2ea73095c5", 0, "a14b4705-533a-470b-a380-709cc15c4001", new DateTime(2023, 4, 24, 9, 8, 29, 347, DateTimeKind.Local).AddTicks(3810), "user8@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_8", false, false, null, "USER8@GMAIL.COM", "USER8@GMAIL.COM", "AQAAAAIAAYagAAAAENLIV5Li9DMeUM2M71YUXCo+86Ry8fsN9UFEVlNZfZgfExqP0fMmiW2FdqmOsohndQ==", "0900000000", false, "TP.HCM", "7c6b3729-6495-44e0-9f4e-30ba2caada9e", false, "user8@gmail.com" },
                    { "ff058804-d565-4d98-b968-151fd27538c1", 0, "cd62d077-737c-4e7e-a960-5bd644ce6367", new DateTime(2023, 4, 24, 9, 8, 29, 245, DateTimeKind.Local).AddTicks(6080), "user5@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_5", false, false, null, "USER5@GMAIL.COM", "USER5@GMAIL.COM", "AQAAAAIAAYagAAAAEL07ZBWif2YmUEheGLEvRQFO/Csq1h2D2kd3nQcEtE/y//SRtAnXEzaCYNuwiluSOQ==", "0900000000", false, "TP.HCM", "f5cefe18-9728-44a3-80f8-cfb5b4b8d57e", false, "user5@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b0f0bb29-0da5-41d0-8462-221076d62711", "24acb884-bafe-4b6f-b0cc-1170ce9a3c3a" },
                    { "b0f0bb29-0da5-41d0-8462-221076d62711", "2a87e244-904a-49d8-abba-9928dcaa822a" },
                    { "b0f0bb29-0da5-41d0-8462-221076d62711", "30cac737-b36f-4ff9-85f5-724a7f5c21f0" },
                    { "b0f0bb29-0da5-41d0-8462-221076d62711", "3b3a0523-1091-4e78-8a4f-1ed1a48690ca" },
                    { "bfb7a4a0-f00f-4588-970d-7228eb0905e1", "4c5980fb-bc00-45d3-a214-9e7119c35035" },
                    { "b0f0bb29-0da5-41d0-8462-221076d62711", "5bd39b10-54e2-46e1-8743-75baa4c1a0b6" },
                    { "b0f0bb29-0da5-41d0-8462-221076d62711", "5de277f0-1433-4f7a-b134-43c6267af9fd" },
                    { "b0f0bb29-0da5-41d0-8462-221076d62711", "d7271325-70a8-40a4-82e6-a727aaf94a00" },
                    { "b0f0bb29-0da5-41d0-8462-221076d62711", "e9d67325-24ac-43e2-a40c-e2e1bd396ad7" },
                    { "b0f0bb29-0da5-41d0-8462-221076d62711", "fa2b8e71-65fc-403b-9152-7a2ea73095c5" },
                    { "b0f0bb29-0da5-41d0-8462-221076d62711", "ff058804-d565-4d98-b968-151fd27538c1" }
                });
        }
    }
}
