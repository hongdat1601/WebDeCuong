using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebDeCuong.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7564c202-054f-450c-93bf-3393bc948104", "874325af-233f-422c-817b-70521beb1e7b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3d8a544a-1200-4ab9-b9dd-c0ae810d5cd5", "b38f9215-217b-43fb-b7de-eb58904b87ce" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d8a544a-1200-4ab9-b9dd-c0ae810d5cd5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7564c202-054f-450c-93bf-3393bc948104");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "874325af-233f-422c-817b-70521beb1e7b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b38f9215-217b-43fb-b7de-eb58904b87ce");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "182ca838-6f44-4186-9b42-279b31137dbc", "182ca838-6f44-4186-9b42-279b31137dbc", "User", "USER" },
                    { "42d9b0e9-d61d-40cf-8f47-cacc8c93fff6", "42d9b0e9-d61d-40cf-8f47-cacc8c93fff6", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "Faculty", "FullName", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "61e3533f-2781-401c-8466-bb68f3717722", 0, "fd36e069-f68b-4e83-8c89-60f2e9097fcf", new DateTime(2023, 4, 9, 15, 48, 9, 405, DateTimeKind.Local).AddTicks(3447), "admin@gmail.com", false, "Khoa học máy tính", "Nguyễn Văn A", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEB2myNoeHIW5K/AZbmRl8evq/6IVePxv7WgjJ7GhqwwMoZxneHidPZZd4LrBmWCmsA==", "0900000000", false, "TP.HCM", "cb30ecd2-91fa-4f8c-92b6-cc0b2188d2e3", false, "admin@gmail.com" },
                    { "d7e8166d-a271-4f18-842d-4d2414d38680", 0, "2ab3e23d-f580-45c5-b9cd-c86c5b99b03b", new DateTime(2023, 4, 9, 15, 48, 9, 534, DateTimeKind.Local).AddTicks(3844), "user@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B", false, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAIAAYagAAAAENUYD1uGzQlsJXx4sTixAA8ZSYMSfTARk4YlJStpPWStwXT4NT57JKn/c/rRm8p9hw==", "0900000000", false, "TP.HCM", "10d96167-7f61-43eb-b202-3d633352df2a", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "42d9b0e9-d61d-40cf-8f47-cacc8c93fff6", "61e3533f-2781-401c-8466-bb68f3717722" },
                    { "182ca838-6f44-4186-9b42-279b31137dbc", "d7e8166d-a271-4f18-842d-4d2414d38680" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "42d9b0e9-d61d-40cf-8f47-cacc8c93fff6", "61e3533f-2781-401c-8466-bb68f3717722" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "182ca838-6f44-4186-9b42-279b31137dbc", "d7e8166d-a271-4f18-842d-4d2414d38680" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "182ca838-6f44-4186-9b42-279b31137dbc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42d9b0e9-d61d-40cf-8f47-cacc8c93fff6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61e3533f-2781-401c-8466-bb68f3717722");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d7e8166d-a271-4f18-842d-4d2414d38680");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d8a544a-1200-4ab9-b9dd-c0ae810d5cd5", "3d8a544a-1200-4ab9-b9dd-c0ae810d5cd5", "User", "USER" },
                    { "7564c202-054f-450c-93bf-3393bc948104", "7564c202-054f-450c-93bf-3393bc948104", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "Faculty", "FullName", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "874325af-233f-422c-817b-70521beb1e7b", 0, "8dc53f20-c74f-4d84-89cf-69fc0cc2c9d2", new DateTime(2023, 4, 9, 15, 46, 23, 99, DateTimeKind.Local).AddTicks(4785), "admin@gmail.com", false, "Khoa học máy tính", "Nguyễn Văn A", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEEdNF7JDq94epuqN1gKj9VBhHQd+RHJwGdRcR1Qnd27YB0TnnuKjE/edPK48i/XiLw==", "0900000000", false, "TP.HCM", "48b82cdd-50e6-4712-bc71-db454a973bdf", false, "admin@gmail.com" },
                    { "b38f9215-217b-43fb-b7de-eb58904b87ce", 0, "3300c540-ed2b-4126-86c8-0425cbed2fba", new DateTime(2023, 4, 9, 15, 46, 23, 229, DateTimeKind.Local).AddTicks(8169), "user@gmail.com", false, "Công nghệ thông tin", "Nguyễn Văn A", true, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAIAAYagAAAAEExgG8x0IExxf99WGIiud/6E/A7L35y6HWoXEzOcvZa6mkK2M42zscdDuEwCHYiRrA==", "0900000000", false, "TP.HCM", "d69e3b9f-8801-4a20-968b-955b39b463c3", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7564c202-054f-450c-93bf-3393bc948104", "874325af-233f-422c-817b-70521beb1e7b" },
                    { "3d8a544a-1200-4ab9-b9dd-c0ae810d5cd5", "b38f9215-217b-43fb-b7de-eb58904b87ce" }
                });
        }
    }
}
