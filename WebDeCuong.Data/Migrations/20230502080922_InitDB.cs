using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebDeCuong.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
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
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TheoryCredits = table.Column<int>(type: "int", nullable: false),
                    PracticeCredits = table.Column<int>(type: "int", nullable: false),
                    SelfLearningCredits = table.Column<int>(type: "int", nullable: false),
                    TotalCredits = table.Column<int>(type: "int", nullable: false),
                    Teachers = table.Column<string>(type: "ntext", nullable: false),
                    Documents = table.Column<string>(type: "ntext", nullable: true),
                    Goals = table.Column<string>(type: "ntext", nullable: false),
                    Abstract = table.Column<string>(type: "ntext", nullable: false),
                    A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other = table.Column<string>(type: "ntext", nullable: true),
                    RequestUserMail = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Name = table.Column<string>(type: "ntext", nullable: false),
                    Method = table.Column<string>(type: "ntext", nullable: false),
                    Proportion = table.Column<int>(type: "int", nullable: false),
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
                    Proportion = table.Column<int>(type: "int", nullable: false),
                    Target = table.Column<int>(type: "int", nullable: false),
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
                    Content = table.Column<string>(type: "ntext", nullable: false),
                    NLessons = table.Column<int>(type: "int", nullable: false),
                    Clos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bonus = table.Column<string>(type: "ntext", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "SubjectOutputStandards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clo = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "ntext", nullable: false),
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
                    { "55ee118a-2603-443d-81fe-430c9b05e066", "55ee118a-2603-443d-81fe-430c9b05e066", "Admin", "ADMIN" },
                    { "cd9bbb33-3eb6-477c-b87c-80f92896c33c", "cd9bbb33-3eb6-477c-b87c-80f92896c33c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "A", "Abstract", "B", "C", "Documents", "Goals", "Name", "Other", "PracticeCredits", "RequestUserMail", "SelfLearningCredits", "Teachers", "TheoryCredits", "TotalCredits" },
                values: new object[,]
                {
                    { "0000001", null, "Day la phan tom tat hoc phan", null, null, "Tai lieu 1\nTai Lieu 2\nTai Lieu 3", "Muc tieu 1\nMuc tieu 2\nMuc tieu 3", "Subject 1", null, 0, null, 0, "Teacher 1\nTeacher 2\nTeacher3", 0, 0 },
                    { "0000002", null, "Day la phan tom tat hoc phan", null, null, "Tai lieu 1\nTai Lieu 2\nTai Lieu 3", "Muc tieu 1\nMuc tieu 2\nMuc tieu 3", "Subject 2", null, 0, null, 0, "Teacher 1\nTeacher 2\nTeacher3", 0, 0 },
                    { "0000003", null, "Day la phan tom tat hoc phan", null, null, "Tai lieu 1\nTai Lieu 2\nTai Lieu 3", "Muc tieu 1\nMuc tieu 2\nMuc tieu 3", "Subject 3", null, 0, null, 0, "Teacher 1\nTeacher 2\nTeacher3", 0, 0 },
                    { "0000004", null, "Day la phan tom tat hoc phan", null, null, "Tai lieu 1\nTai Lieu 2\nTai Lieu 3", "Muc tieu 1\nMuc tieu 2\nMuc tieu 3", "Subject 4", null, 0, null, 0, "Teacher 1\nTeacher 2\nTeacher3", 0, 0 },
                    { "0000005", null, "Day la phan tom tat hoc phan", null, null, "Tai lieu 1\nTai Lieu 2\nTai Lieu 3", "Muc tieu 1\nMuc tieu 2\nMuc tieu 3", "Subject 5", null, 0, null, 0, "Teacher 1\nTeacher 2\nTeacher3", 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "Faculty", "FullName", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0a8e83dc-5ef8-4179-9493-b49862c3080c", 0, "5aa94164-6edf-406f-a98e-03c24c408b6a", new DateTime(2023, 5, 2, 15, 9, 22, 208, DateTimeKind.Local).AddTicks(648), "user7@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_7", false, false, null, "USER7@GMAIL.COM", "USER7@GMAIL.COM", "AQAAAAIAAYagAAAAELB0FJyKhS9APPv2nnXIE2r6PWK86FtUwO82RkCDnPewXTXiyayKxrF/NlrK48gT6g==", "0900000000", false, "TP.HCM", "cc88f81b-b616-47e4-a7ea-9cf1fa2e9200", false, "user7@gmail.com" },
                    { "235fb507-c66d-465c-aaac-c5fc777e87f2", 0, "eda7adfe-cc28-4da9-b97c-8afeeb604fc4", new DateTime(2023, 5, 2, 15, 9, 21, 157, DateTimeKind.Local).AddTicks(7956), "admin@gmail.com", false, "Khoa học máy tính", "Nguyễn Văn A", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEBH9gVHTMlkHQJ2V8qEYHcPBanoNHJ+RUJ/6uV36rCUVtz6xlxecv0UijZ1gst/Y/w==", "0900000000", false, "TP.HCM", "8d0f29ad-201b-4e2a-88cd-84db60d654aa", false, "admin@gmail.com" },
                    { "24dd35ab-94a0-4697-bc18-bf8dc433eaf3", 0, "b9cd4e4d-14cd-4735-8b09-00c3ee4f0793", new DateTime(2023, 5, 2, 15, 9, 21, 277, DateTimeKind.Local).AddTicks(8399), "user0@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_0", false, false, null, "USER0@GMAIL.COM", "USER0@GMAIL.COM", "AQAAAAIAAYagAAAAECg78Qp9zNIq2D4AVxx1ioYXrQ8jXBF1VMYnBpgkHuiXLLZrl6HDkwjjbWOv0TCuyQ==", "0900000000", false, "TP.HCM", "7cb4cf94-5a23-470d-9f95-75a49eee22a3", false, "user0@gmail.com" },
                    { "3bc840ce-1d87-4687-ab0d-f0d5edf5a8be", 0, "5603bb1c-3b27-4372-bc41-c7a05743ba36", new DateTime(2023, 5, 2, 15, 9, 21, 934, DateTimeKind.Local).AddTicks(6809), "user5@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_5", false, false, null, "USER5@GMAIL.COM", "USER5@GMAIL.COM", "AQAAAAIAAYagAAAAEMZjLhX+rgYT2GKo69O0TqPmMobh7OkJRrHacmZ89v85x1Tc6bFF1g4f6F/DOcgXqg==", "0900000000", false, "TP.HCM", "a5b6cd7b-0c21-4867-b094-4391d67f788e", false, "user5@gmail.com" },
                    { "5d8b1e05-2584-48a8-be28-b8b263b31a11", 0, "4c9c3ff1-670c-4676-baf6-de2047150b11", new DateTime(2023, 5, 2, 15, 9, 22, 449, DateTimeKind.Local).AddTicks(2574), "user9@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_9", false, false, null, "USER9@GMAIL.COM", "USER9@GMAIL.COM", "AQAAAAIAAYagAAAAEI7WqwVCx6A9Esy+Ht07jWXJQ3eSAxPnQ3rOi1aZZKOBoK4+KFZ6pR/a0Xg0k+dWRQ==", "0900000000", false, "TP.HCM", "925d0ea6-4237-4e7c-901a-2b15fa0231fd", false, "user9@gmail.com" },
                    { "6bfede16-ceca-45eb-87bf-33f735c282f0", 0, "2c601a4d-66d9-4546-a33d-f1771765b8f5", new DateTime(2023, 5, 2, 15, 9, 21, 666, DateTimeKind.Local).AddTicks(6168), "user3@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_3", false, false, null, "USER3@GMAIL.COM", "USER3@GMAIL.COM", "AQAAAAIAAYagAAAAEMVz/jrXWP22hVIFH4sMk+1RUkypi03FgSbyY3RnuXgnnEenIefi+98IKMHiya6dtw==", "0900000000", false, "TP.HCM", "7f44e434-354b-4128-baae-9321e497671f", false, "user3@gmail.com" },
                    { "aaaa8253-3c8c-4250-ae09-04a7e565ebcd", 0, "28d61496-1e04-459a-ac00-21cedb3453c7", new DateTime(2023, 5, 2, 15, 9, 22, 333, DateTimeKind.Local).AddTicks(9660), "user8@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_8", false, false, null, "USER8@GMAIL.COM", "USER8@GMAIL.COM", "AQAAAAIAAYagAAAAEHVnU/W69vMI8QRqPyO7lVWu+bDfriyJPtj6BqKP4Gtami8isQkpombdidsZucCfFg==", "0900000000", false, "TP.HCM", "684dc97c-7460-4261-bb33-ebcc91d799d9", false, "user8@gmail.com" },
                    { "af239852-8612-4e4c-8612-c3382d42a0d1", 0, "1e84e5c9-a0d6-4be4-83f4-3f1e332b9e8a", new DateTime(2023, 5, 2, 15, 9, 21, 543, DateTimeKind.Local).AddTicks(2245), "user2@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_2", false, false, null, "USER2@GMAIL.COM", "USER2@GMAIL.COM", "AQAAAAIAAYagAAAAEIvg8jc0DP86uZwnbN/vzVv6/zkzmxLPQ3d/R1f2wqfm3vXgi0rI3alrnPHwT9oivg==", "0900000000", false, "TP.HCM", "ffe7f24b-7ffd-4531-8223-6750a51f90fc", false, "user2@gmail.com" },
                    { "b9b351c1-c58e-4ce8-8cdc-7bdc8e0a3bad", 0, "00006daa-1601-4cee-8d16-391d04abec0e", new DateTime(2023, 5, 2, 15, 9, 22, 79, DateTimeKind.Local).AddTicks(9149), "user6@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_6", false, false, null, "USER6@GMAIL.COM", "USER6@GMAIL.COM", "AQAAAAIAAYagAAAAECBwYH4S704W0WIvtQo1YOa9FTvDsr+w+Yk5fSLB9LX7zlnjbmvIghOBYYB8aGQ73A==", "0900000000", false, "TP.HCM", "abde66d1-578c-4008-b609-f59af7e117ac", false, "user6@gmail.com" },
                    { "caf97252-1da9-4693-b2d8-d6fe50d74af9", 0, "f41c45b7-9efa-41ec-9cde-036504071a16", new DateTime(2023, 5, 2, 15, 9, 21, 413, DateTimeKind.Local).AddTicks(2650), "user1@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_1", false, false, null, "USER1@GMAIL.COM", "USER1@GMAIL.COM", "AQAAAAIAAYagAAAAELuovoO7KPlqDURaEOVvwQbSJKqpoEKi3cay45cKWndqP8TfHaAc7eLinj3U34wiBw==", "0900000000", false, "TP.HCM", "d13dd28e-4b17-48dc-b43e-f2f9f247532d", false, "user1@gmail.com" },
                    { "e0bb91da-ef1a-40ea-8d32-eb200a803efd", 0, "ea3b6474-a234-4bf4-a6c5-0d7e03a0724d", new DateTime(2023, 5, 2, 15, 9, 21, 808, DateTimeKind.Local).AddTicks(2984), "user4@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_4", false, false, null, "USER4@GMAIL.COM", "USER4@GMAIL.COM", "AQAAAAIAAYagAAAAEPwWTh97pvqRO4pcunMt/Ra9uAu9AXhGwJC9GeVLdaABhQRBQIoy9tKViBLkQqzlvA==", "0900000000", false, "TP.HCM", "a864c881-ef4c-41d4-bc61-b88b7442ca97", false, "user4@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cd9bbb33-3eb6-477c-b87c-80f92896c33c", "0a8e83dc-5ef8-4179-9493-b49862c3080c" },
                    { "55ee118a-2603-443d-81fe-430c9b05e066", "235fb507-c66d-465c-aaac-c5fc777e87f2" },
                    { "cd9bbb33-3eb6-477c-b87c-80f92896c33c", "24dd35ab-94a0-4697-bc18-bf8dc433eaf3" },
                    { "cd9bbb33-3eb6-477c-b87c-80f92896c33c", "3bc840ce-1d87-4687-ab0d-f0d5edf5a8be" },
                    { "cd9bbb33-3eb6-477c-b87c-80f92896c33c", "5d8b1e05-2584-48a8-be28-b8b263b31a11" },
                    { "cd9bbb33-3eb6-477c-b87c-80f92896c33c", "6bfede16-ceca-45eb-87bf-33f735c282f0" },
                    { "cd9bbb33-3eb6-477c-b87c-80f92896c33c", "aaaa8253-3c8c-4250-ae09-04a7e565ebcd" },
                    { "cd9bbb33-3eb6-477c-b87c-80f92896c33c", "af239852-8612-4e4c-8612-c3382d42a0d1" },
                    { "cd9bbb33-3eb6-477c-b87c-80f92896c33c", "b9b351c1-c58e-4ce8-8cdc-7bdc8e0a3bad" },
                    { "cd9bbb33-3eb6-477c-b87c-80f92896c33c", "caf97252-1da9-4693-b2d8-d6fe50d74af9" },
                    { "cd9bbb33-3eb6-477c-b87c-80f92896c33c", "e0bb91da-ef1a-40ea-8d32-eb200a803efd" }
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

            migrationBuilder.CreateIndex(
                name: "IX_SubjectOutputStandards_SubjectId",
                table: "SubjectOutputStandards",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_Name",
                table: "Subjects",
                column: "Name",
                unique: true);

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
                name: "SubjectCurriculums");

            migrationBuilder.DropTable(
                name: "SubjectOutputStandards");

            migrationBuilder.DropTable(
                name: "SubjectUsers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Curriculums");

            migrationBuilder.DropTable(
                name: "Semesters");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
