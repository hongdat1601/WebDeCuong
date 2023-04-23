using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebDeCuong.Data.Migrations
{
    /// <inheritdoc />
    public partial class initDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TheoryCredits = table.Column<int>(type: "int", nullable: false),
                    PracticeCredits = table.Column<int>(type: "int", nullable: false),
                    SelfLearningCredits = table.Column<int>(type: "int", nullable: false),
                    TotalCredits = table.Column<int>(type: "int", nullable: false),
                    Teachers = table.Column<string>(type: "text", nullable: false),
                    Documents = table.Column<string>(type: "text", nullable: true),
                    Goals = table.Column<string>(type: "text", nullable: false),
                    Abstract = table.Column<string>(type: "text", nullable: false),
                    A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Faculty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvalElements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Proportion = table.Column<float>(type: "real", nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvalElements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvalElements_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evaluates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Clo = table.Column<int>(type: "int", nullable: false),
                    Test = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Proportion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Target = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evaluates_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NLessons = table.Column<int>(type: "int", nullable: false),
                    Clos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bonus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectContents_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectOutputStandards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clo = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoPerPi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectOutputStandards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectOutputStandards_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectUsers_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_EvalElements_SubjectId",
                table: "EvalElements",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluates_SubjectId",
                table: "Evaluates",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectContents_SubjectId",
                table: "SubjectContents",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectOutputStandards_SubjectId",
                table: "SubjectOutputStandards",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectUsers_SubjectId",
                table: "SubjectUsers",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectUsers_UserId",
                table: "SubjectUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EvalElements");

            migrationBuilder.DropTable(
                name: "Evaluates");

            migrationBuilder.DropTable(
                name: "SubjectContents");

            migrationBuilder.DropTable(
                name: "SubjectOutputStandards");

            migrationBuilder.DropTable(
                name: "SubjectUsers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
