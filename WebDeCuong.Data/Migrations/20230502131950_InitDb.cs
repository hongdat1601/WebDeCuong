using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebDeCuong.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Curriculums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curriculums", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Semesters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semesters", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TheoryCredits = table.Column<int>(type: "int", nullable: false),
                    PracticeCredits = table.Column<int>(type: "int", nullable: false),
                    SelfLearningCredits = table.Column<int>(type: "int", nullable: false),
                    TotalCredits = table.Column<int>(type: "int", nullable: false),
                    Teachers = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Documents = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Goals = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Abstract = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    A = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    B = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    C = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Other = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RequestUserMail = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FullName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Faculty = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Gender = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EvalElements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Method = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Proportion = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Evaluates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Clo = table.Column<int>(type: "int", nullable: false),
                    Test = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Method = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Proportion = table.Column<int>(type: "int", nullable: false),
                    Target = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SubjectContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NLessons = table.Column<int>(type: "int", nullable: false),
                    Clos = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Method = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bonus = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SubjectId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SubjectCurriculums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CurriculumId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SubjectOutputStandards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Clo = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SoPerPi = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SubjectId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SubjectUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SubjectId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "868f560d-7b60-4d96-a02d-deeb33ae9b2a", "868f560d-7b60-4d96-a02d-deeb33ae9b2a", "Admin", "ADMIN" },
                    { "a26cf27d-a917-47a7-91e5-ecd8f7263671", "a26cf27d-a917-47a7-91e5-ecd8f7263671", "User", "USER" }
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
                    { "04df6fee-9b2f-44ea-8709-e42075e19065", 0, "8d7ec703-5418-4c0e-8d7f-24814e5a6c29", new DateTime(2023, 5, 2, 20, 19, 50, 600, DateTimeKind.Local).AddTicks(813), "user9@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_9", false, false, null, "USER9@GMAIL.COM", "USER9@GMAIL.COM", "AQAAAAIAAYagAAAAEIpBzyecjul/CO4Ikqfxhxk4/+UdottefBqElCDE6o9einvk/KaUv5E6VIgK+WclbA==", "0900000000", false, "TP.HCM", "87197e69-5fb8-4397-8b12-4297cc343eda", false, "user9@gmail.com" },
                    { "17f6646b-025b-4dc7-ae89-cf4dce101242", 0, "ff03ce34-114b-4ed9-a3c7-e6da3265a524", new DateTime(2023, 5, 2, 20, 19, 50, 22, DateTimeKind.Local).AddTicks(9730), "user4@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_4", false, false, null, "USER4@GMAIL.COM", "USER4@GMAIL.COM", "AQAAAAIAAYagAAAAEEKlv3kRAhUyIWQrd5AtMKkYG/7rXsykllaZUrREaRZNzNqbl4GMB4GMq14Ds9kMlQ==", "0900000000", false, "TP.HCM", "9314edfd-96f5-46ab-876b-d1799245a04e", false, "user4@gmail.com" },
                    { "19692afb-fbc3-40f4-8aa5-66ef2ec2e4e5", 0, "968da335-5a2c-4c25-abcb-ed7649cb9f72", new DateTime(2023, 5, 2, 20, 19, 49, 336, DateTimeKind.Local).AddTicks(7308), "admin@gmail.com", false, "Khoa học máy tính", "Nguyễn Văn A", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEMAEtMVhNKCkDbXDrNBUm7W5+KEMN2NkgHVDPCzcjG8bLRtfCjWB20li3uKnh/5JlQ==", "0900000000", false, "TP.HCM", "b1d85ebf-b570-4233-8ffa-1d879ac22e5e", false, "admin@gmail.com" },
                    { "42b90d73-7449-4d93-88a3-3944db4f23cb", 0, "bd715a11-5baa-4265-8a10-8b6cac025ff4", new DateTime(2023, 5, 2, 20, 19, 50, 259, DateTimeKind.Local).AddTicks(3068), "user6@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_6", false, false, null, "USER6@GMAIL.COM", "USER6@GMAIL.COM", "AQAAAAIAAYagAAAAEKCW7J37TVHX+xJeKeHXpinYDdndUCQ0TPEqh9V1ZMzbak40VJTJJWSbe/VwyVFTHg==", "0900000000", false, "TP.HCM", "668b34f9-d083-4836-bbb9-cfbc15756f2d", false, "user6@gmail.com" },
                    { "797f84eb-78b3-44ec-a7f3-22a647be488e", 0, "e875b709-1279-42bb-8bc6-96710873d488", new DateTime(2023, 5, 2, 20, 19, 50, 373, DateTimeKind.Local).AddTicks(8288), "user7@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_7", false, false, null, "USER7@GMAIL.COM", "USER7@GMAIL.COM", "AQAAAAIAAYagAAAAEG+17s1+szTEvmHry4ssF+mp/XaM5trbu9QOFqtRLKjQaw/URhs6YLHl6RP/u6a3Xg==", "0900000000", false, "TP.HCM", "8f1fd559-7bb1-4d9d-a626-e91c55527782", false, "user7@gmail.com" },
                    { "7f3531fc-a18e-4680-9936-7711fc967332", 0, "0c7b077f-793d-4dfc-b26a-23c4f0c2761d", new DateTime(2023, 5, 2, 20, 19, 49, 746, DateTimeKind.Local).AddTicks(3635), "user2@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_2", false, false, null, "USER2@GMAIL.COM", "USER2@GMAIL.COM", "AQAAAAIAAYagAAAAEKWS+k72f+vRGtVX/JpiQtRbljHkKshYh3fWZSfF7ykC+jYJCJiBeb1GYM3bB45JKA==", "0900000000", false, "TP.HCM", "2624afca-e679-4bc2-828d-ba4e05a78b0e", false, "user2@gmail.com" },
                    { "9150d4c5-a7f9-4d4d-89ff-6e79c5d7f504", 0, "ecaba934-755c-49b0-80d3-9fdc78e8e89a", new DateTime(2023, 5, 2, 20, 19, 50, 492, DateTimeKind.Local).AddTicks(6167), "user8@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_8", false, false, null, "USER8@GMAIL.COM", "USER8@GMAIL.COM", "AQAAAAIAAYagAAAAEJEAWwLl0OewzLsXq/4WzgjJqUbVb+bns70KqYY6pO5EpOig6Fk2lA+AvRRMcBU7Yg==", "0900000000", false, "TP.HCM", "1fc0e115-bfd7-46c4-80e9-1258ee3d260c", false, "user8@gmail.com" },
                    { "a556c3ed-e39f-4c3b-8260-27e299fa5997", 0, "4ec1f7f3-8d0a-4ce4-81b5-f5a5628964c0", new DateTime(2023, 5, 2, 20, 19, 49, 883, DateTimeKind.Local).AddTicks(682), "user3@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_3", false, false, null, "USER3@GMAIL.COM", "USER3@GMAIL.COM", "AQAAAAIAAYagAAAAEAVgbZTOEt8fx6YBXwojGXKXEQOrRGIevaPkv/YqB3rg+eeZ6vjbXJxMgz3L0zO3hg==", "0900000000", false, "TP.HCM", "6b4aa49c-556d-4e06-82e4-42b8e496e129", false, "user3@gmail.com" },
                    { "cce4fe6b-9169-466e-a364-6912b115060e", 0, "4cd4e31d-37cc-4359-9f87-6b07f6e7f54b", new DateTime(2023, 5, 2, 20, 19, 50, 147, DateTimeKind.Local).AddTicks(4242), "user5@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_5", false, false, null, "USER5@GMAIL.COM", "USER5@GMAIL.COM", "AQAAAAIAAYagAAAAEGwrYmbQTbXQiB7IxpeW1ZvzwWb1UMs+BFjge+v2TR9rPlq9zoUs/3HCuluYGfy0pA==", "0900000000", false, "TP.HCM", "bf0dd2a0-f1e2-48bb-990c-3862d3342c8d", false, "user5@gmail.com" },
                    { "d7dec7f8-bfc1-4e09-b815-56bff951adff", 0, "94be165e-0030-41cf-b212-3ffa51c2aff2", new DateTime(2023, 5, 2, 20, 19, 49, 450, DateTimeKind.Local).AddTicks(2060), "user0@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_0", false, false, null, "USER0@GMAIL.COM", "USER0@GMAIL.COM", "AQAAAAIAAYagAAAAECEsOggQYCKLp6ITPVZ3zh1mvrqHCZaTf3DoM1QTELFzvsArkHdSHQLkG8nfybdviQ==", "0900000000", false, "TP.HCM", "40c366ef-f630-4d19-88a9-10e9ec9cd0ad", false, "user0@gmail.com" },
                    { "f4e30aff-2a35-4c10-8266-19627406b95a", 0, "53b04fe9-0125-43d2-83c4-283080de543c", new DateTime(2023, 5, 2, 20, 19, 49, 591, DateTimeKind.Local).AddTicks(3286), "user1@gmail.com", false, "Công nghệ thông tin", "Nguyễn Thị B_1", false, false, null, "USER1@GMAIL.COM", "USER1@GMAIL.COM", "AQAAAAIAAYagAAAAELe+Vf0pIBI1mqdyPNmBn6gc6glPowspffo2BS5hi3MCsMtAfhsBKgaYEKpfTa+0FA==", "0900000000", false, "TP.HCM", "328bb24b-d677-4a34-8441-311b8e5dd5be", false, "user1@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a26cf27d-a917-47a7-91e5-ecd8f7263671", "04df6fee-9b2f-44ea-8709-e42075e19065" },
                    { "a26cf27d-a917-47a7-91e5-ecd8f7263671", "17f6646b-025b-4dc7-ae89-cf4dce101242" },
                    { "868f560d-7b60-4d96-a02d-deeb33ae9b2a", "19692afb-fbc3-40f4-8aa5-66ef2ec2e4e5" },
                    { "a26cf27d-a917-47a7-91e5-ecd8f7263671", "42b90d73-7449-4d93-88a3-3944db4f23cb" },
                    { "a26cf27d-a917-47a7-91e5-ecd8f7263671", "797f84eb-78b3-44ec-a7f3-22a647be488e" },
                    { "a26cf27d-a917-47a7-91e5-ecd8f7263671", "7f3531fc-a18e-4680-9936-7711fc967332" },
                    { "a26cf27d-a917-47a7-91e5-ecd8f7263671", "9150d4c5-a7f9-4d4d-89ff-6e79c5d7f504" },
                    { "a26cf27d-a917-47a7-91e5-ecd8f7263671", "a556c3ed-e39f-4c3b-8260-27e299fa5997" },
                    { "a26cf27d-a917-47a7-91e5-ecd8f7263671", "cce4fe6b-9169-466e-a364-6912b115060e" },
                    { "a26cf27d-a917-47a7-91e5-ecd8f7263671", "d7dec7f8-bfc1-4e09-b815-56bff951adff" },
                    { "a26cf27d-a917-47a7-91e5-ecd8f7263671", "f4e30aff-2a35-4c10-8266-19627406b95a" }
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
                unique: true);

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
                unique: true);
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
