using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebDeCuong.Data.Migrations
{
    /// <inheritdoc />
    public partial class SemesteUpdater : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "677e3afa-1d6c-469a-9dd3-47888370dc92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe9d8ca0-ca06-4ea4-b651-c07d1da7e7d3");

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

            migrationBuilder.CreateTable(
                name: "Curriculums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curriculums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Semesters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semesters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubjectCurriculums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurriculumId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SemesterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectCurriculums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectCurriculums_Curriculums_CurriculumId",
                        column: x => x.CurriculumId,
                        principalTable: "Curriculums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectCurriculums_Semesters_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semesters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectCurriculums_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_SubjectCurriculums_CurriculumId",
                table: "SubjectCurriculums",
                column: "CurriculumId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectCurriculums_SemesterId",
                table: "SubjectCurriculums",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectCurriculums_SubjectId",
                table: "SubjectCurriculums",
                column: "SubjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubjectCurriculums");

            migrationBuilder.DropTable(
                name: "Curriculums");

            migrationBuilder.DropTable(
                name: "Semesters");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "677e3afa-1d6c-469a-9dd3-47888370dc92", "677e3afa-1d6c-469a-9dd3-47888370dc92", "User", "USER" },
                    { "fe9d8ca0-ca06-4ea4-b651-c07d1da7e7d3", "fe9d8ca0-ca06-4ea4-b651-c07d1da7e7d3", "Admin", "ADMIN" }
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
        }
    }
}
