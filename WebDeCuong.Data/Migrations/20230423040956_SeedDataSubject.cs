using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebDeCuong.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataSubject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "4a029e96-bcd3-44b4-9066-61aaeaeab6fa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "4b173b8e-e8d1-411a-8c3d-5584add6a71a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "657cc661-90c2-4b6c-a952-e7925b256da0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "7c1279b8-5821-43dd-90ca-9af527dc5135" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "9ee4498d-c1af-4898-9ccc-59a5e0ca95dd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "a72e903f-016b-41f1-af45-77150ee89235" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3ed16290-12b1-4ca7-8fb6-13e879a945b3", "c9754d31-d282-470f-b99d-084453b9f1ac" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "d8f3c3e9-9cff-449e-a00b-2fc0033308a3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "e14cebd5-2d14-4e8f-9b90-141853435fee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "f5f17191-fa50-4660-aa39-7c18e27d1543" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "fd719ca2-6ef9-47ad-b91a-b71dc3d7829c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ed16290-12b1-4ca7-8fb6-13e879a945b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c96d55c-e00b-4a14-8766-9bec794b2d9b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4a029e96-bcd3-44b4-9066-61aaeaeab6fa");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4b173b8e-e8d1-411a-8c3d-5584add6a71a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "657cc661-90c2-4b6c-a952-e7925b256da0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7c1279b8-5821-43dd-90ca-9af527dc5135");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9ee4498d-c1af-4898-9ccc-59a5e0ca95dd");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a72e903f-016b-41f1-af45-77150ee89235");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c9754d31-d282-470f-b99d-084453b9f1ac");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d8f3c3e9-9cff-449e-a00b-2fc0033308a3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e14cebd5-2d14-4e8f-9b90-141853435fee");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f5f17191-fa50-4660-aa39-7c18e27d1543");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fd719ca2-6ef9-47ad-b91a-b71dc3d7829c");

            migrationBuilder.AlterColumn<int>(
                name: "Target",
                table: "Evaluates",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Proportion",
                table: "Evaluates",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Proportion",
                table: "EvalElements",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "677e3afa-1d6c-469a-9dd3-47888370dc92", "677e3afa-1d6c-469a-9dd3-47888370dc92", "User", "USER" },
                    { "fe9d8ca0-ca06-4ea4-b651-c07d1da7e7d3", "fe9d8ca0-ca06-4ea4-b651-c07d1da7e7d3", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "A", "Abstract", "B", "C", "Documents", "Goals", "Name", "Other", "PracticeCredits", "SelfLearningCredits", "Teachers", "TheoryCredits", "TotalCredits" },
                values: new object[,]
                {
                    { "0000001", null, "Day la phan tom tat hoc phan", null, null, "Tai lieu 1\nTai Lieu 2\nTai Lieu 3", "Muc tieu 1\nMuc tieu 2\nMuc tieu 3", "Subject 1", null, 0, 0, "Teacher 1\nTeacher 2\nTeacher3", 0, 0 },
                    { "0000002", null, "Day la phan tom tat hoc phan", null, null, "Tai lieu 1\nTai Lieu 2\nTai Lieu 3", "Muc tieu 1\nMuc tieu 2\nMuc tieu 3", "Subject 2", null, 0, 0, "Teacher 1\nTeacher 2\nTeacher3", 0, 0 },
                    { "0000003", null, "Day la phan tom tat hoc phan", null, null, "Tai lieu 1\nTai Lieu 2\nTai Lieu 3", "Muc tieu 1\nMuc tieu 2\nMuc tieu 3", "Subject 3", null, 0, 0, "Teacher 1\nTeacher 2\nTeacher3", 0, 0 },
                    { "0000004", null, "Day la phan tom tat hoc phan", null, null, "Tai lieu 1\nTai Lieu 2\nTai Lieu 3", "Muc tieu 1\nMuc tieu 2\nMuc tieu 3", "Subject 4", null, 0, 0, "Teacher 1\nTeacher 2\nTeacher3", 0, 0 },
                    { "0000005", null, "Day la phan tom tat hoc phan", null, null, "Tai lieu 1\nTai Lieu 2\nTai Lieu 3", "Muc tieu 1\nMuc tieu 2\nMuc tieu 3", "Subject 5", null, 0, 0, "Teacher 1\nTeacher 2\nTeacher3", 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "Faculty", "FullName", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4cda32b1-7310-40e4-9512-31adfd0452ff", 0, "c0dd8745-e46d-4ce2-b582-3b753cf8a33b", new DateTime(2023, 4, 23, 11, 9, 54, 978, DateTimeKind.Local).AddTicks(4456), "admin@gmail.com", false, "Khoa học máy tính", "Nguyễn Văn A", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAECeT69az2+Xyg2hQA+BmiiwLXg2W4/fh9svfzNyaCthPM08/GV9Wo5gYuk1zyuQftw==", "0900000000", false, "TP.HCM", "a70bf647-2a88-4266-ae3e-b6327c533bc4", false, "admin@gmail.com" },
                    { "794998d9-86f4-4474-95a5-69062d6c9c96", 0, "e4b5d661-c6f9-4ee1-b2ad-a66569175267", new DateTime(2023, 4, 23, 11, 9, 55, 891, DateTimeKind.Local).AddTicks(7449), "user8@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_8", false, false, null, "USER8@GMAIL.COM", "USER8@GMAIL.COM", "AQAAAAIAAYagAAAAEFpbmJ23lywVsMCzujWpL5BfpR0h0t/NFyfnkd+S9vuKZjfrX72ECloM1F2XlxQ1hA==", "0900000000", false, "TP.HCM", "2c3f81ab-51d2-4591-af9e-b989e6583e73", false, "user8@gmail.com" },
                    { "7ab4d702-3bbf-4774-bdea-5e440e73586b", 0, "306ccf8c-c6d6-40fc-acd1-afaf44e59722", new DateTime(2023, 4, 23, 11, 9, 55, 166, DateTimeKind.Local).AddTicks(7134), "user1@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_1", false, false, null, "USER1@GMAIL.COM", "USER1@GMAIL.COM", "AQAAAAIAAYagAAAAEHgsAVFNgECRrIlyw+vdOuxKB/kMnIxsMU7IfIN9+RDedjBGKROD+SuOBR8oXQlCpg==", "0900000000", false, "TP.HCM", "b1dd3a9a-a957-43e6-adb7-0886d8bfd88a", false, "user1@gmail.com" },
                    { "8e1ef777-d494-4866-ba93-e6673f5fe786", 0, "7571a76d-0de7-402d-a9db-8c1818f5ffb9", new DateTime(2023, 4, 23, 11, 9, 55, 983, DateTimeKind.Local).AddTicks(5493), "user9@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_9", false, false, null, "USER9@GMAIL.COM", "USER9@GMAIL.COM", "AQAAAAIAAYagAAAAEA4ABQxkiPQ54CKlM91myTAYAvvn7r3jzcx6D7Ra7hwtuU76dqqdZ9zSC3yrxs4stw==", "0900000000", false, "TP.HCM", "69032fb9-c62a-49c9-b807-9d8201c0813a", false, "user9@gmail.com" },
                    { "ac73d120-517c-4c7a-82ac-0be762e3f790", 0, "c730f0ea-f8f3-4b61-a6a3-b53ce4fbce3b", new DateTime(2023, 4, 23, 11, 9, 55, 264, DateTimeKind.Local).AddTicks(3617), "user2@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_2", false, false, null, "USER2@GMAIL.COM", "USER2@GMAIL.COM", "AQAAAAIAAYagAAAAELbr18nsuBuCLFkReReflepfQQpT9vJKen/EFLldrUHAjZ07QK3PJhRvQhZQiaOlWA==", "0900000000", false, "TP.HCM", "3553203c-7f1c-4a39-8d3a-8b271e3369cb", false, "user2@gmail.com" },
                    { "bd52980f-041a-4757-9fad-b79857756d1b", 0, "cd424021-d729-49f3-9fc9-9d1b501f6169", new DateTime(2023, 4, 23, 11, 9, 55, 68, DateTimeKind.Local).AddTicks(3627), "user0@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_0", false, false, null, "USER0@GMAIL.COM", "USER0@GMAIL.COM", "AQAAAAIAAYagAAAAEDMEvc+cvC2mlu2McmgO/3wEmHhe5+va6BTFP2GHqU7hB0OAN1Hx8oZO2QIkKLKmiw==", "0900000000", false, "TP.HCM", "bd78e0ee-38be-42b6-848f-0a892aa0b461", false, "user0@gmail.com" },
                    { "bd639d64-5e26-46c2-93eb-d50ee3f404aa", 0, "4dbe681e-5156-46ee-be16-a31619d90516", new DateTime(2023, 4, 23, 11, 9, 55, 680, DateTimeKind.Local).AddTicks(5326), "user6@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_6", false, false, null, "USER6@GMAIL.COM", "USER6@GMAIL.COM", "AQAAAAIAAYagAAAAEHC7PcOrGmBPTBvU2VfxwRHh8wxKwfgaxBaF4yXhrpx7wYMQln2Ud7pouByYtwTMAg==", "0900000000", false, "TP.HCM", "99a3cce8-1c70-4f7a-b3d1-7a99de37d289", false, "user6@gmail.com" },
                    { "e5bb027d-f6d8-4256-bcaf-7d768c43a2ba", 0, "a468fa52-67c5-4fb5-8332-0cc699a70458", new DateTime(2023, 4, 23, 11, 9, 55, 783, DateTimeKind.Local).AddTicks(6675), "user7@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_7", false, false, null, "USER7@GMAIL.COM", "USER7@GMAIL.COM", "AQAAAAIAAYagAAAAEO+6JYMsSQnwh+YMRwmUGxZsbTVSwt/f/II5wQwLh1iodDhogRgsbXM/K0+OOYwpYg==", "0900000000", false, "TP.HCM", "a1b1a56f-1b66-4cf7-a0c2-e28585c85ecb", false, "user7@gmail.com" },
                    { "ed4bab8a-8b8f-4a78-af47-09d1f933e0fb", 0, "a0edace9-672a-405b-9db5-8cc1b47c48ce", new DateTime(2023, 4, 23, 11, 9, 55, 365, DateTimeKind.Local).AddTicks(3155), "user3@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_3", false, false, null, "USER3@GMAIL.COM", "USER3@GMAIL.COM", "AQAAAAIAAYagAAAAEJMlZtqrFXsIxdBAfh8XteYuHZ6UxQ+x/ATEJSQ5HMYxI7gg3x4+4yOSf8POOPngEg==", "0900000000", false, "TP.HCM", "7685a2de-ceee-45fd-beb1-fa5d4abac250", false, "user3@gmail.com" },
                    { "f26af492-de43-4c05-bc7e-6fafe55ef06a", 0, "b78105d1-b169-475a-98fd-ab07a678871e", new DateTime(2023, 4, 23, 11, 9, 55, 467, DateTimeKind.Local).AddTicks(3044), "user4@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_4", false, false, null, "USER4@GMAIL.COM", "USER4@GMAIL.COM", "AQAAAAIAAYagAAAAEOSIarA3unF6OPPPijv+xaBp+8PvC/1y1vrN5L+gyEt3EhouodnS8wmLvL/93kZJBQ==", "0900000000", false, "TP.HCM", "6d47bb1d-558b-4968-b717-d6eba822c473", false, "user4@gmail.com" },
                    { "f5b13fa8-3b2f-4b01-a12c-873d85ec7d7e", 0, "579a0368-879f-4f25-930e-2422604acc9e", new DateTime(2023, 4, 23, 11, 9, 55, 579, DateTimeKind.Local).AddTicks(7353), "user5@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_5", false, false, null, "USER5@GMAIL.COM", "USER5@GMAIL.COM", "AQAAAAIAAYagAAAAEL6iw2OPakmmsymZK0Yx0mtghxqjTXR5zI/Sb19DehTGKx/6bSXx+A5CoGX/EPQOdA==", "0900000000", false, "TP.HCM", "95f4f83b-4475-499f-9d9c-bbba929ac5c1", false, "user5@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fe9d8ca0-ca06-4ea4-b651-c07d1da7e7d3", "4cda32b1-7310-40e4-9512-31adfd0452ff" },
                    { "677e3afa-1d6c-469a-9dd3-47888370dc92", "794998d9-86f4-4474-95a5-69062d6c9c96" },
                    { "677e3afa-1d6c-469a-9dd3-47888370dc92", "7ab4d702-3bbf-4774-bdea-5e440e73586b" },
                    { "677e3afa-1d6c-469a-9dd3-47888370dc92", "8e1ef777-d494-4866-ba93-e6673f5fe786" },
                    { "677e3afa-1d6c-469a-9dd3-47888370dc92", "ac73d120-517c-4c7a-82ac-0be762e3f790" },
                    { "677e3afa-1d6c-469a-9dd3-47888370dc92", "bd52980f-041a-4757-9fad-b79857756d1b" },
                    { "677e3afa-1d6c-469a-9dd3-47888370dc92", "bd639d64-5e26-46c2-93eb-d50ee3f404aa" },
                    { "677e3afa-1d6c-469a-9dd3-47888370dc92", "e5bb027d-f6d8-4256-bcaf-7d768c43a2ba" },
                    { "677e3afa-1d6c-469a-9dd3-47888370dc92", "ed4bab8a-8b8f-4a78-af47-09d1f933e0fb" },
                    { "677e3afa-1d6c-469a-9dd3-47888370dc92", "f26af492-de43-4c05-bc7e-6fafe55ef06a" },
                    { "677e3afa-1d6c-469a-9dd3-47888370dc92", "f5b13fa8-3b2f-4b01-a12c-873d85ec7d7e" }
                });

            migrationBuilder.InsertData(
                table: "EvalElements",
                columns: new[] { "Id", "Method", "Name", "Order", "Proportion", "SubjectId" },
                values: new object[,]
                {
                    { 1, "Kiem tra", "Ly thuyet", 1, 20, "0000001" },
                    { 2, "Kiem tra", "Ly thuyet", 2, 20, "0000001" },
                    { 3, "Kiem tra", "Ly thuyet", 3, 20, "0000001" },
                    { 4, "Kiem tra", "Ly thuyet", 4, 20, "0000001" },
                    { 5, "Kiem tra", "Ly thuyet", 5, 20, "0000001" },
                    { 6, "Kiem tra", "Ly thuyet", 1, 20, "0000002" },
                    { 7, "Kiem tra", "Ly thuyet", 2, 20, "0000002" },
                    { 8, "Kiem tra", "Ly thuyet", 3, 20, "0000002" },
                    { 9, "Kiem tra", "Ly thuyet", 4, 20, "0000002" },
                    { 10, "Kiem tra", "Ly thuyet", 5, 20, "0000002" },
                    { 11, "Kiem tra", "Ly thuyet", 1, 20, "0000003" },
                    { 12, "Kiem tra", "Ly thuyet", 2, 20, "0000003" },
                    { 13, "Kiem tra", "Ly thuyet", 3, 20, "0000003" },
                    { 14, "Kiem tra", "Ly thuyet", 4, 20, "0000003" },
                    { 15, "Kiem tra", "Ly thuyet", 5, 20, "0000003" },
                    { 16, "Kiem tra", "Ly thuyet", 1, 20, "0000004" },
                    { 17, "Kiem tra", "Ly thuyet", 2, 20, "0000004" },
                    { 18, "Kiem tra", "Ly thuyet", 3, 20, "0000004" },
                    { 19, "Kiem tra", "Ly thuyet", 4, 20, "0000004" },
                    { 20, "Kiem tra", "Ly thuyet", 5, 20, "0000004" },
                    { 21, "Kiem tra", "Ly thuyet", 1, 20, "0000005" },
                    { 22, "Kiem tra", "Ly thuyet", 2, 20, "0000005" },
                    { 23, "Kiem tra", "Ly thuyet", 3, 20, "0000005" },
                    { 24, "Kiem tra", "Ly thuyet", 4, 20, "0000005" },
                    { 25, "Kiem tra", "Ly thuyet", 5, 20, "0000005" }
                });

            migrationBuilder.InsertData(
                table: "Evaluates",
                columns: new[] { "Id", "Clo", "Method", "Order", "Proportion", "SubjectId", "Target", "Test" },
                values: new object[,]
                {
                    { 1, 1, "Thi viet", 1, 100, "0000001", 75, "Bai kiem tra" },
                    { 2, 2, "Thi viet", 2, 100, "0000001", 75, "Bai kiem tra" },
                    { 3, 3, "Thi viet", 3, 100, "0000001", 75, "Bai kiem tra" },
                    { 4, 4, "Thi viet", 4, 100, "0000001", 75, "Bai kiem tra" },
                    { 5, 5, "Thi viet", 5, 100, "0000001", 75, "Bai kiem tra" },
                    { 6, 1, "Thi viet", 1, 100, "0000002", 75, "Bai kiem tra" },
                    { 7, 2, "Thi viet", 2, 100, "0000002", 75, "Bai kiem tra" },
                    { 8, 3, "Thi viet", 3, 100, "0000002", 75, "Bai kiem tra" },
                    { 9, 4, "Thi viet", 4, 100, "0000002", 75, "Bai kiem tra" },
                    { 10, 5, "Thi viet", 5, 100, "0000002", 75, "Bai kiem tra" },
                    { 11, 1, "Thi viet", 1, 100, "0000003", 75, "Bai kiem tra" },
                    { 12, 2, "Thi viet", 2, 100, "0000003", 75, "Bai kiem tra" },
                    { 13, 3, "Thi viet", 3, 100, "0000003", 75, "Bai kiem tra" },
                    { 14, 4, "Thi viet", 4, 100, "0000003", 75, "Bai kiem tra" },
                    { 15, 5, "Thi viet", 5, 100, "0000003", 75, "Bai kiem tra" },
                    { 16, 1, "Thi viet", 1, 100, "0000004", 75, "Bai kiem tra" },
                    { 17, 2, "Thi viet", 2, 100, "0000004", 75, "Bai kiem tra" },
                    { 18, 3, "Thi viet", 3, 100, "0000004", 75, "Bai kiem tra" },
                    { 19, 4, "Thi viet", 4, 100, "0000004", 75, "Bai kiem tra" },
                    { 20, 5, "Thi viet", 5, 100, "0000004", 75, "Bai kiem tra" },
                    { 21, 1, "Thi viet", 1, 100, "0000005", 75, "Bai kiem tra" },
                    { 22, 2, "Thi viet", 2, 100, "0000005", 75, "Bai kiem tra" },
                    { 23, 3, "Thi viet", 3, 100, "0000005", 75, "Bai kiem tra" },
                    { 24, 4, "Thi viet", 4, 100, "0000005", 75, "Bai kiem tra" },
                    { 25, 5, "Thi viet", 5, 100, "0000005", 75, "Bai kiem tra" }
                });

            migrationBuilder.InsertData(
                table: "SubjectContents",
                columns: new[] { "Id", "Bonus", "Clos", "Content", "Method", "NLessons", "Order", "SubjectId" },
                values: new object[,]
                {
                    { 1, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 1, "0000001" },
                    { 2, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 2, "0000001" },
                    { 3, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 3, "0000001" },
                    { 4, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 4, "0000001" },
                    { 5, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 5, "0000001" },
                    { 6, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 1, "0000002" },
                    { 7, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 2, "0000002" },
                    { 8, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 3, "0000002" },
                    { 9, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 4, "0000002" },
                    { 10, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 5, "0000002" },
                    { 11, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 1, "0000003" },
                    { 12, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 2, "0000003" },
                    { 13, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 3, "0000003" },
                    { 14, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 4, "0000003" },
                    { 15, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 5, "0000003" },
                    { 16, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 1, "0000004" },
                    { 17, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 2, "0000004" },
                    { 18, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 3, "0000004" },
                    { 19, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 4, "0000004" },
                    { 20, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 5, "0000004" },
                    { 21, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 1, "0000005" },
                    { 22, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 2, "0000005" },
                    { 23, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 3, "0000005" },
                    { 24, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 4, "0000005" },
                    { 25, null, "1, 2, 3, 4, 5", "Subject Context", "L, D", 30, 5, "0000005" }
                });

            migrationBuilder.InsertData(
                table: "SubjectOutputStandards",
                columns: new[] { "Id", "Clo", "Content", "SoPerPi", "SubjectId" },
                values: new object[,]
                {
                    { 1, 1, "Dau ra 1", "Text", "0000001" },
                    { 2, 2, "Dau ra 2", "Text", "0000001" },
                    { 3, 3, "Dau ra 3", "Text", "0000001" },
                    { 4, 4, "Dau ra 4", "Text", "0000001" },
                    { 5, 5, "Dau ra 5", "Text", "0000001" },
                    { 6, 1, "Dau ra 1", "Text", "0000002" },
                    { 7, 2, "Dau ra 2", "Text", "0000002" },
                    { 8, 3, "Dau ra 3", "Text", "0000002" },
                    { 9, 4, "Dau ra 4", "Text", "0000002" },
                    { 10, 5, "Dau ra 5", "Text", "0000002" },
                    { 11, 1, "Dau ra 1", "Text", "0000003" },
                    { 12, 2, "Dau ra 2", "Text", "0000003" },
                    { 13, 3, "Dau ra 3", "Text", "0000003" },
                    { 14, 4, "Dau ra 4", "Text", "0000003" },
                    { 15, 5, "Dau ra 5", "Text", "0000003" },
                    { 16, 1, "Dau ra 1", "Text", "0000004" },
                    { 17, 2, "Dau ra 2", "Text", "0000004" },
                    { 18, 3, "Dau ra 3", "Text", "0000004" },
                    { 19, 4, "Dau ra 4", "Text", "0000004" },
                    { 20, 5, "Dau ra 5", "Text", "0000004" },
                    { 21, 1, "Dau ra 1", "Text", "0000005" },
                    { 22, 2, "Dau ra 2", "Text", "0000005" },
                    { 23, 3, "Dau ra 3", "Text", "0000005" },
                    { 24, 4, "Dau ra 4", "Text", "0000005" },
                    { 25, 5, "Dau ra 5", "Text", "0000005" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fe9d8ca0-ca06-4ea4-b651-c07d1da7e7d3", "4cda32b1-7310-40e4-9512-31adfd0452ff" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "677e3afa-1d6c-469a-9dd3-47888370dc92", "794998d9-86f4-4474-95a5-69062d6c9c96" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "677e3afa-1d6c-469a-9dd3-47888370dc92", "7ab4d702-3bbf-4774-bdea-5e440e73586b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "677e3afa-1d6c-469a-9dd3-47888370dc92", "8e1ef777-d494-4866-ba93-e6673f5fe786" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "677e3afa-1d6c-469a-9dd3-47888370dc92", "ac73d120-517c-4c7a-82ac-0be762e3f790" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "677e3afa-1d6c-469a-9dd3-47888370dc92", "bd52980f-041a-4757-9fad-b79857756d1b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "677e3afa-1d6c-469a-9dd3-47888370dc92", "bd639d64-5e26-46c2-93eb-d50ee3f404aa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "677e3afa-1d6c-469a-9dd3-47888370dc92", "e5bb027d-f6d8-4256-bcaf-7d768c43a2ba" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "677e3afa-1d6c-469a-9dd3-47888370dc92", "ed4bab8a-8b8f-4a78-af47-09d1f933e0fb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "677e3afa-1d6c-469a-9dd3-47888370dc92", "f26af492-de43-4c05-bc7e-6fafe55ef06a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "677e3afa-1d6c-469a-9dd3-47888370dc92", "f5b13fa8-3b2f-4b01-a12c-873d85ec7d7e" });

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "EvalElements",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Evaluates",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SubjectContents",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SubjectOutputStandards",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "677e3afa-1d6c-469a-9dd3-47888370dc92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe9d8ca0-ca06-4ea4-b651-c07d1da7e7d3");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "0000001");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "0000002");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "0000003");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "0000004");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "0000005");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4cda32b1-7310-40e4-9512-31adfd0452ff");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "794998d9-86f4-4474-95a5-69062d6c9c96");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7ab4d702-3bbf-4774-bdea-5e440e73586b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e1ef777-d494-4866-ba93-e6673f5fe786");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ac73d120-517c-4c7a-82ac-0be762e3f790");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bd52980f-041a-4757-9fad-b79857756d1b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bd639d64-5e26-46c2-93eb-d50ee3f404aa");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e5bb027d-f6d8-4256-bcaf-7d768c43a2ba");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ed4bab8a-8b8f-4a78-af47-09d1f933e0fb");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f26af492-de43-4c05-bc7e-6fafe55ef06a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f5b13fa8-3b2f-4b01-a12c-873d85ec7d7e");

            migrationBuilder.AlterColumn<string>(
                name: "Target",
                table: "Evaluates",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Proportion",
                table: "Evaluates",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Proportion",
                table: "EvalElements",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ed16290-12b1-4ca7-8fb6-13e879a945b3", "3ed16290-12b1-4ca7-8fb6-13e879a945b3", "Admin", "ADMIN" },
                    { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "Faculty", "FullName", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4a029e96-bcd3-44b4-9066-61aaeaeab6fa", 0, "c3e51348-99ea-4339-9b93-28079f60cde8", new DateTime(2023, 4, 23, 10, 29, 40, 857, DateTimeKind.Local).AddTicks(9934), "user7@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_7", false, false, null, "USER7@GMAIL.COM", "USER7@GMAIL.COM", "AQAAAAIAAYagAAAAEAOcHGIY+Fs8PflYczqU98XlOIOFgweTo69wSUCCENmE703Cnbnokbpw7lNjNZ+6Kw==", "0900000000", false, "TP.HCM", "cbe4c206-64f8-4270-a057-14f0edb1fd5e", false, "user7@gmail.com" },
                    { "4b173b8e-e8d1-411a-8c3d-5584add6a71a", 0, "880c5985-aaf6-4452-9206-a3b400e21e93", new DateTime(2023, 4, 23, 10, 29, 40, 641, DateTimeKind.Local).AddTicks(4377), "user5@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_5", false, false, null, "USER5@GMAIL.COM", "USER5@GMAIL.COM", "AQAAAAIAAYagAAAAEImwecXq2cE1gBjU2CMNXXesZ8m5+rBzFUnmBnAyAzkJeMNke/FOkJWx8Gv/X/pj+w==", "0900000000", false, "TP.HCM", "19380265-0167-4736-9e83-2238691e8d4b", false, "user5@gmail.com" },
                    { "657cc661-90c2-4b6c-a952-e7925b256da0", 0, "e42d2712-1476-45ca-8f62-6856494b9d5e", new DateTime(2023, 4, 23, 10, 29, 40, 136, DateTimeKind.Local).AddTicks(4251), "user0@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_0", false, false, null, "USER0@GMAIL.COM", "USER0@GMAIL.COM", "AQAAAAIAAYagAAAAEByDPfKpNPTDvXRUVKrvdVp9Eey/ETBzUW7R96AhX6uPlZvpBbabVPsrjTh8UdGNKQ==", "0900000000", false, "TP.HCM", "0dac447f-a06f-4b6d-85cd-98d614663f76", false, "user0@gmail.com" },
                    { "7c1279b8-5821-43dd-90ca-9af527dc5135", 0, "b44c52d6-4f19-49a9-a16c-13865755e1d2", new DateTime(2023, 4, 23, 10, 29, 41, 49, DateTimeKind.Local).AddTicks(9107), "user9@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_9", false, false, null, "USER9@GMAIL.COM", "USER9@GMAIL.COM", "AQAAAAIAAYagAAAAENs8hB6LybNBRwuuiasJzAV/SJhZn5xu/G2J7bIGbOkCbrwZEHMKsXnssKsKIgn/Ww==", "0900000000", false, "TP.HCM", "1a8c19b5-5995-4091-ac70-eb5d458445f3", false, "user9@gmail.com" },
                    { "9ee4498d-c1af-4898-9ccc-59a5e0ca95dd", 0, "450d685c-04a1-4653-b160-22867d87b638", new DateTime(2023, 4, 23, 10, 29, 40, 960, DateTimeKind.Local).AddTicks(6724), "user8@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_8", false, false, null, "USER8@GMAIL.COM", "USER8@GMAIL.COM", "AQAAAAIAAYagAAAAEACkFmjJ3t5XYYAzyq3HgaEqqyyUu3S2kqcbs/55z/jCPaRe4X0OMBSKIRnlBEg3Ww==", "0900000000", false, "TP.HCM", "b7b81c8c-ad2f-45c9-a9f8-c6bd4f1ea26f", false, "user8@gmail.com" },
                    { "a72e903f-016b-41f1-af45-77150ee89235", 0, "e3a9ff6c-0064-4c05-943c-534ff777394c", new DateTime(2023, 4, 23, 10, 29, 40, 747, DateTimeKind.Local).AddTicks(5464), "user6@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_6", false, false, null, "USER6@GMAIL.COM", "USER6@GMAIL.COM", "AQAAAAIAAYagAAAAENoDFUDt6BtJfnDUBYKN51u2jla0Z8HvfF1HG9zLyXloD1Ajebs/uEQLpUhAHE2GZA==", "0900000000", false, "TP.HCM", "6033843a-9ddd-454c-b7da-71781e840b4f", false, "user6@gmail.com" },
                    { "c9754d31-d282-470f-b99d-084453b9f1ac", 0, "6359d5fb-c9aa-471b-b43e-b7e5ecabb3c2", new DateTime(2023, 4, 23, 10, 29, 40, 48, DateTimeKind.Local).AddTicks(362), "admin@gmail.com", false, "Khoa học máy tính", "Nguyễn Văn A", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEFaKzEM0SdqA4nY7OfyDq71cFRKQyCVzyJxS0xpRUoASrsEn7j4yUwjIUPS4smo/wQ==", "0900000000", false, "TP.HCM", "d537df78-0388-47b2-91b2-5eafd8b7c168", false, "admin@gmail.com" },
                    { "d8f3c3e9-9cff-449e-a00b-2fc0033308a3", 0, "d4cb5c47-8d5b-4004-9c3e-ec65eb0a3126", new DateTime(2023, 4, 23, 10, 29, 40, 234, DateTimeKind.Local).AddTicks(2805), "user1@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_1", false, false, null, "USER1@GMAIL.COM", "USER1@GMAIL.COM", "AQAAAAIAAYagAAAAECpgqMMG7KrifKnGxUxoyeG1KG0rDrLQ+Y0RSoHrLh3u4AK1Qv02XZKh6DgEvwO5CQ==", "0900000000", false, "TP.HCM", "eb8798c5-31a7-4ed4-b987-aade1aa5ea3c", false, "user1@gmail.com" },
                    { "e14cebd5-2d14-4e8f-9b90-141853435fee", 0, "6fdab28e-5876-4a92-b35f-5751485d80cd", new DateTime(2023, 4, 23, 10, 29, 40, 442, DateTimeKind.Local).AddTicks(6453), "user3@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_3", false, false, null, "USER3@GMAIL.COM", "USER3@GMAIL.COM", "AQAAAAIAAYagAAAAEAq9/8V8XbQ8N2joK6NGg4O5q60ov1fBqbllZq0eFt9+7dteiDb38u4WxgLrg6KlVA==", "0900000000", false, "TP.HCM", "20401cb4-6e20-4273-99e7-60918d8b87bd", false, "user3@gmail.com" },
                    { "f5f17191-fa50-4660-aa39-7c18e27d1543", 0, "2fc32efa-2e3a-42c8-b542-55da056f324a", new DateTime(2023, 4, 23, 10, 29, 40, 541, DateTimeKind.Local).AddTicks(5305), "user4@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_4", false, false, null, "USER4@GMAIL.COM", "USER4@GMAIL.COM", "AQAAAAIAAYagAAAAEO8xGtjfDCsZpSPVurSNsbjKdVeRwczt/e9oGUdMF7+xcPdN0mIkpMzE0XILdX2adA==", "0900000000", false, "TP.HCM", "5ac5aeff-45e1-4386-9b0a-ea9cbfed9ee1", false, "user4@gmail.com" },
                    { "fd719ca2-6ef9-47ad-b91a-b71dc3d7829c", 0, "414e7f2b-ac2a-4ffc-8786-0b4d7987defd", new DateTime(2023, 4, 23, 10, 29, 40, 331, DateTimeKind.Local).AddTicks(4669), "user2@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_2", false, false, null, "USER2@GMAIL.COM", "USER2@GMAIL.COM", "AQAAAAIAAYagAAAAEAa5tj5GlueaKSRnRWcI9t6SFl+4j4qrcnIFoZl9F6lpxaVZrWTZ5TPI7IP8nKAQGA==", "0900000000", false, "TP.HCM", "97f4933d-400d-4ebb-9c11-d7febe72f338", false, "user2@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "4a029e96-bcd3-44b4-9066-61aaeaeab6fa" },
                    { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "4b173b8e-e8d1-411a-8c3d-5584add6a71a" },
                    { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "657cc661-90c2-4b6c-a952-e7925b256da0" },
                    { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "7c1279b8-5821-43dd-90ca-9af527dc5135" },
                    { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "9ee4498d-c1af-4898-9ccc-59a5e0ca95dd" },
                    { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "a72e903f-016b-41f1-af45-77150ee89235" },
                    { "3ed16290-12b1-4ca7-8fb6-13e879a945b3", "c9754d31-d282-470f-b99d-084453b9f1ac" },
                    { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "d8f3c3e9-9cff-449e-a00b-2fc0033308a3" },
                    { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "e14cebd5-2d14-4e8f-9b90-141853435fee" },
                    { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "f5f17191-fa50-4660-aa39-7c18e27d1543" },
                    { "6c96d55c-e00b-4a14-8766-9bec794b2d9b", "fd719ca2-6ef9-47ad-b91a-b71dc3d7829c" }
                });
        }
    }
}
