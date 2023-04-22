using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebDeCuong.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "151d30be-bbb3-4c3d-87bf-eb2083e0ef66", "151d30be-bbb3-4c3d-87bf-eb2083e0ef66", "Admin", "ADMIN" },
                    { "81644fb7-4df1-4001-a436-b751959f83a8", "81644fb7-4df1-4001-a436-b751959f83a8", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "Faculty", "FullName", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0b57a186-98ad-476a-b7d4-95b4bb61daca", 0, "2d8745ec-d5a2-4bce-be0c-118ab484584d", new DateTime(2023, 4, 11, 21, 15, 4, 503, DateTimeKind.Local).AddTicks(6848), "admin@gmail.com", false, "Khoa học máy tính", "Nguyễn Văn A", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEFqhgVoFeTHFQ37HA06bsTlwHEsyLZDgaC6yQuA3KJcU0k8ZHSRtWAvApstbQmuynA==", "0900000000", false, "TP.HCM", "60c4925e-74e6-4004-a392-d37b1fe90536", false, "admin@gmail.com" },
                    { "0d0a1e15-0b7e-4bed-b189-712023bdfa08", 0, "1f965907-7b42-40b6-bf04-58c0d3a5f43e", new DateTime(2023, 4, 11, 21, 15, 5, 834, DateTimeKind.Local).AddTicks(5993), "user8@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_8", false, false, null, "USER8@GMAIL.COM", "USER8@GMAIL.COM", "AQAAAAIAAYagAAAAEDK9zPpEBigDIOlm2D3honl+hXEQr1BADfYy/0TSC7WKnr1UeOcnAMknpsJwhR14RA==", "0900000000", false, "TP.HCM", "47af54b9-83c0-494a-a374-9e938eaa0ed3", false, "user8@gmail.com" },
                    { "2245e22c-1a3c-460c-b0d0-d08d6cf529b7", 0, "36696e46-c840-4e41-bb29-a39486760dbd", new DateTime(2023, 4, 11, 21, 15, 4, 949, DateTimeKind.Local).AddTicks(7291), "user2@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_2", false, false, null, "USER2@GMAIL.COM", "USER2@GMAIL.COM", "AQAAAAIAAYagAAAAEHt/u/84G2SEp1iVNTP50nr8udjS/HS3t6Tu4lxFXKyBm20uIS8tVKbK3+pmCQLnpg==", "0900000000", false, "TP.HCM", "4972a29b-bdeb-4662-9e28-d4b13a6b36c0", false, "user2@gmail.com" },
                    { "28dc5eda-5ed3-4f64-ac4d-2f1cff2decbf", 0, "bdf9740e-c4aa-4584-baf4-bb2174dbbe38", new DateTime(2023, 4, 11, 21, 15, 5, 392, DateTimeKind.Local).AddTicks(932), "user5@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_5", false, false, null, "USER5@GMAIL.COM", "USER5@GMAIL.COM", "AQAAAAIAAYagAAAAEJcb4+uROHJ6Y1fctVq6W6YVhDHY7kf+0372BXWGKtcx+g8LLR/cC+mAonww7bGIQg==", "0900000000", false, "TP.HCM", "9246dfff-fd44-40b0-88ad-cee05404999b", false, "user5@gmail.com" },
                    { "3ec2cc93-fdb8-4e82-9c4e-9127ee1b8803", 0, "626a838d-68ed-4b96-9da4-d7b311e6b2d0", new DateTime(2023, 4, 11, 21, 15, 5, 980, DateTimeKind.Local).AddTicks(3075), "user9@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_9", false, false, null, "USER9@GMAIL.COM", "USER9@GMAIL.COM", "AQAAAAIAAYagAAAAEH7PU0+LLDx/Gse99zQTdoc6GbtQOgT3aD2BwKL/asEjIlDu9dnheeEudcx8jD1oBg==", "0900000000", false, "TP.HCM", "19452660-a89f-432c-9c4d-72e1382b1fc0", false, "user9@gmail.com" },
                    { "5475409f-83f5-4f81-9e4e-3259908d2f86", 0, "12f9c598-b69e-43fd-93e7-a33c003dcfa1", new DateTime(2023, 4, 11, 21, 15, 4, 801, DateTimeKind.Local).AddTicks(5968), "user1@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_1", false, false, null, "USER1@GMAIL.COM", "USER1@GMAIL.COM", "AQAAAAIAAYagAAAAEBqovxEDe5HbUcHggV2VQ+FZ0eiu2ikewyPk2na2FJOOF2O0RJhOwPSLYR47H54WdA==", "0900000000", false, "TP.HCM", "844ef804-bb79-4a22-889a-ec079909f7b7", false, "user1@gmail.com" },
                    { "9208f844-b28d-4da0-b28b-a7cf2cd24d91", 0, "5cfa1345-8751-4dcf-a2b8-e0b87c46ebfe", new DateTime(2023, 4, 11, 21, 15, 4, 632, DateTimeKind.Local).AddTicks(7265), "user0@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_0", false, false, null, "USER0@GMAIL.COM", "USER0@GMAIL.COM", "AQAAAAIAAYagAAAAEEo3bkE6C2akjUaEooiUCodYDl/y2FJ+5Z8LF4YaktF77s6zv3Rg6sARWtIkqBgV0A==", "0900000000", false, "TP.HCM", "89b3ea13-22e1-4604-9619-0939d2a10e5b", false, "user0@gmail.com" },
                    { "9db7c7db-b13a-400e-ab7f-8b0268ee7b10", 0, "f46c6455-4c76-46c9-b6e9-0f7570bd1fd8", new DateTime(2023, 4, 11, 21, 15, 5, 101, DateTimeKind.Local).AddTicks(9452), "user3@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_3", false, false, null, "USER3@GMAIL.COM", "USER3@GMAIL.COM", "AQAAAAIAAYagAAAAEAOoZ151Dr8JWTNpfTi0fVMpTky6tjUYcL8C+oB9QgvrPDhqjAGkirAC9SXXmcQ1jA==", "0900000000", false, "TP.HCM", "7d4eff88-6324-4a76-b260-f004a9efee1d", false, "user3@gmail.com" },
                    { "ae478d28-f63f-410c-8c85-ff5235378b6f", 0, "3f8933b9-1cdf-4e13-a0d6-7e8f76d422f5", new DateTime(2023, 4, 11, 21, 15, 5, 536, DateTimeKind.Local).AddTicks(1186), "user6@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_6", false, false, null, "USER6@GMAIL.COM", "USER6@GMAIL.COM", "AQAAAAIAAYagAAAAEGqXS1ZdW7A6mxZ+U+QQ0Tk/BU4BrdohU+ovOjSO9bNZcfwSuXVfgXA+Dk+lXx5LEg==", "0900000000", false, "TP.HCM", "1562a88b-9788-4502-b263-847390b31af4", false, "user6@gmail.com" },
                    { "d62f430b-75e7-4db3-8130-bc24f72ac1cd", 0, "f09a6288-8f4d-4db4-afc7-637ea46b72e5", new DateTime(2023, 4, 11, 21, 15, 5, 253, DateTimeKind.Local).AddTicks(183), "user4@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_4", false, false, null, "USER4@GMAIL.COM", "USER4@GMAIL.COM", "AQAAAAIAAYagAAAAEPtYVKOxe9nL7mAEjqfRBhgXiX1uj+NtsVewKnXRnPJ44/OJ1w03EIJpACJqBsybqQ==", "0900000000", false, "TP.HCM", "da88cb6e-9fad-418c-8ca9-5438a1e4aed4", false, "user4@gmail.com" },
                    { "eebbbbd2-d822-45ca-8185-e00a0badf42b", 0, "6f017808-de9f-4b3b-bc78-ca3f1b62a3c9", new DateTime(2023, 4, 11, 21, 15, 5, 677, DateTimeKind.Local).AddTicks(4828), "user7@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_7", false, false, null, "USER7@GMAIL.COM", "USER7@GMAIL.COM", "AQAAAAIAAYagAAAAELedSJ4vmkyWVdEinsGGn1rLVUDoZQFhpEbM4gZV1NzzKMpdUJ2IiQVyV2/ljWZQug==", "0900000000", false, "TP.HCM", "ba7c502c-1855-49e8-ae56-e5fc881b26a6", false, "user7@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "151d30be-bbb3-4c3d-87bf-eb2083e0ef66", "0b57a186-98ad-476a-b7d4-95b4bb61daca" },
                    { "81644fb7-4df1-4001-a436-b751959f83a8", "0d0a1e15-0b7e-4bed-b189-712023bdfa08" },
                    { "81644fb7-4df1-4001-a436-b751959f83a8", "2245e22c-1a3c-460c-b0d0-d08d6cf529b7" },
                    { "81644fb7-4df1-4001-a436-b751959f83a8", "28dc5eda-5ed3-4f64-ac4d-2f1cff2decbf" },
                    { "81644fb7-4df1-4001-a436-b751959f83a8", "3ec2cc93-fdb8-4e82-9c4e-9127ee1b8803" },
                    { "81644fb7-4df1-4001-a436-b751959f83a8", "5475409f-83f5-4f81-9e4e-3259908d2f86" },
                    { "81644fb7-4df1-4001-a436-b751959f83a8", "9208f844-b28d-4da0-b28b-a7cf2cd24d91" },
                    { "81644fb7-4df1-4001-a436-b751959f83a8", "9db7c7db-b13a-400e-ab7f-8b0268ee7b10" },
                    { "81644fb7-4df1-4001-a436-b751959f83a8", "ae478d28-f63f-410c-8c85-ff5235378b6f" },
                    { "81644fb7-4df1-4001-a436-b751959f83a8", "d62f430b-75e7-4db3-8130-bc24f72ac1cd" },
                    { "81644fb7-4df1-4001-a436-b751959f83a8", "eebbbbd2-d822-45ca-8185-e00a0badf42b" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "151d30be-bbb3-4c3d-87bf-eb2083e0ef66", "0b57a186-98ad-476a-b7d4-95b4bb61daca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "81644fb7-4df1-4001-a436-b751959f83a8", "0d0a1e15-0b7e-4bed-b189-712023bdfa08" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "81644fb7-4df1-4001-a436-b751959f83a8", "2245e22c-1a3c-460c-b0d0-d08d6cf529b7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "81644fb7-4df1-4001-a436-b751959f83a8", "28dc5eda-5ed3-4f64-ac4d-2f1cff2decbf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "81644fb7-4df1-4001-a436-b751959f83a8", "3ec2cc93-fdb8-4e82-9c4e-9127ee1b8803" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "81644fb7-4df1-4001-a436-b751959f83a8", "5475409f-83f5-4f81-9e4e-3259908d2f86" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "81644fb7-4df1-4001-a436-b751959f83a8", "9208f844-b28d-4da0-b28b-a7cf2cd24d91" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "81644fb7-4df1-4001-a436-b751959f83a8", "9db7c7db-b13a-400e-ab7f-8b0268ee7b10" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "81644fb7-4df1-4001-a436-b751959f83a8", "ae478d28-f63f-410c-8c85-ff5235378b6f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "81644fb7-4df1-4001-a436-b751959f83a8", "d62f430b-75e7-4db3-8130-bc24f72ac1cd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "81644fb7-4df1-4001-a436-b751959f83a8", "eebbbbd2-d822-45ca-8185-e00a0badf42b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "151d30be-bbb3-4c3d-87bf-eb2083e0ef66");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81644fb7-4df1-4001-a436-b751959f83a8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0b57a186-98ad-476a-b7d4-95b4bb61daca");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0d0a1e15-0b7e-4bed-b189-712023bdfa08");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2245e22c-1a3c-460c-b0d0-d08d6cf529b7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "28dc5eda-5ed3-4f64-ac4d-2f1cff2decbf");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3ec2cc93-fdb8-4e82-9c4e-9127ee1b8803");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5475409f-83f5-4f81-9e4e-3259908d2f86");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9208f844-b28d-4da0-b28b-a7cf2cd24d91");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9db7c7db-b13a-400e-ab7f-8b0268ee7b10");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ae478d28-f63f-410c-8c85-ff5235378b6f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d62f430b-75e7-4db3-8130-bc24f72ac1cd");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "eebbbbd2-d822-45ca-8185-e00a0badf42b");

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
    }
}
