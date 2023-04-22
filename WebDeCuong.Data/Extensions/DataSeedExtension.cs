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

            return builder;
        }
    }
}
