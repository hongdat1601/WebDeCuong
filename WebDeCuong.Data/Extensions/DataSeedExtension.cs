using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeCuong.Data.Entities;

namespace WebDeCuong.Data.Extensions
{
    static class DataSeedExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            // Roles
            var userRoleId = Guid.NewGuid().ToString();
            var adminRoleId = Guid.NewGuid().ToString();

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = userRoleId,
                    Name = "User",
                    NormalizedName = "USER",
                    ConcurrencyStamp = userRoleId
                },
                new IdentityRole
                {
                    Id = adminRoleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = adminRoleId
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);

            // Users
            var users = new List<ApplicationUser>();
            var userRoles = new List<IdentityUserRole<string>>();

            var adminId = Guid.NewGuid().ToString();

            var admin = new ApplicationUser
            {
                Id = adminId,
                Email = "admin@gmail.com",
                UserName = "admin@gmail.com",
                DateOfBirth = DateTime.Now,
                Faculty = "Khoa học máy tính",
                FullName = "Nguyễn Văn A",
                Gender = true,
                NormalizedEmail = "ADMIN@GMAIL.COM",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                PhoneNumber = "0900000000",
                PlaceOfBirth = "TP.HCM",
            };

            PasswordHasher<ApplicationUser> ph = new PasswordHasher<ApplicationUser>();
            admin.PasswordHash = ph.HashPassword(admin, "123456@Abc");

            users.Add(admin);
            userRoles.Add(new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = adminId
            });

            for (int i = 0; i < 10; i++)
            {
                var userId = Guid.NewGuid().ToString();

                var user = new ApplicationUser
                {
                    Id = userId,
                    Email = $"user{i}@gmail.com",
                    UserName = $"user{i}@gmail.com",
                    DateOfBirth = DateTime.Now,
                    Faculty = "Công nghệ thông tin",
                    FullName = $"Nguyễn Thị B_{i}",
                    Gender = false,
                    NormalizedEmail = $"USER{i}@GMAIL.COM",
                    NormalizedUserName = $"USER{i}@GMAIL.COM",
                    PhoneNumber = "0900000000",
                    PlaceOfBirth = "TP.HCM",
                };

                user.PasswordHash = ph.HashPassword(user, "123456@Abc");

                users.Add(user);
                userRoles.Add(new IdentityUserRole<string>
                {
                    RoleId = userRoleId,
                    UserId = userId
                });
            }

            builder.Entity<ApplicationUser>().HasData(users);

            // User Roles
            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);

            // Subject
            List<Subject> subjects = new List<Subject>();
            List<SubjectContent> subjectContents = new List<SubjectContent>();
            List<SubjectOutputStandard> outputStandards = new List<SubjectOutputStandard>();
            List<Evaluate> evaluates = new List<Evaluate>();
            List<EvalElement> evalElements = new List<EvalElement>();

            for (int i = 1; i <= 5; i++)
            {
                Subject subject = new Subject
                {
                    Id = $"{i}".PadLeft(7, '0'),
                    Name = $"Subject {i}",
                    TheoryCredits = 0,
                    PracticeCredits = 0,
                    SelfLearningCredits = 0,
                    TotalCredits = 0,
                    Teachers = "Teacher 1\nTeacher 2\nTeacher3",
                    Documents = "Tai lieu 1\nTai Lieu 2\nTai Lieu 3",
                    Goals = "Muc tieu 1\nMuc tieu 2\nMuc tieu 3",
                    Abstract = "Day la phan tom tat hoc phan",
                    A = null,
                    B = null,
                    C = null,
                    Other = null
                };

                for (int j = 1; j <= 5; j++)
                {
                    SubjectContent subjectContent = new SubjectContent
                    {
                        Id = (i - 1) * 5 + j,
                        Order = j,
                        Content = "Subject Context",
                        NLessons = 30,
                        Clos = "1, 2, 3, 4, 5",
                        Method = "L, D",
                        Bonus = null,
                        SubjectId = subject.Id
                    };

                    SubjectOutputStandard subjectOutputStandard = new SubjectOutputStandard
                    {
                        Id = (i - 1) * 5 + j,
                        Clo = j,
                        Content = $"Dau ra {j}",
                        SoPerPi = "Text",
                        SubjectId = subject.Id,
                    };

                    Evaluate evaluate = new Evaluate
                    {
                        Id = (i - 1) * 5 + j,
                        Order = j,
                        Clo = j,
                        Test = "Bai kiem tra",
                        Method = "Thi viet",
                        Proportion = 100,
                        Target = 75,
                        SubjectId = subject.Id
                    };

                    EvalElement evalElement = new EvalElement
                    {
                        Id = (i - 1) * 5 + j,
                        Order = j,
                        Name = "Ly thuyet",
                        Method = "Kiem tra",
                        Proportion = 20,
                        SubjectId = subject.Id
                    };

                    subjectContents.Add(subjectContent);
                    outputStandards.Add(subjectOutputStandard);
                    evaluates.Add(evaluate);
                    evalElements.Add(evalElement);
                }

                subjects.Add(subject);
            }

            builder.Entity<Subject>().HasData(subjects);
            builder.Entity<SubjectContent>().HasData(subjectContents);
            builder.Entity<SubjectOutputStandard>().HasData(outputStandards);
            builder.Entity<Evaluate>().HasData(evaluates);
            builder.Entity<EvalElement>().HasData(evalElements);

            return builder;
        }
    }
}
