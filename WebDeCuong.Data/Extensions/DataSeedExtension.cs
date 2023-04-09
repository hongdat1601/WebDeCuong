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
            var adminId = Guid.NewGuid().ToString();
            var userId = Guid.NewGuid().ToString();

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

            var user = new ApplicationUser
            {
                Id = userId,
                Email = "user@gmail.com",
                UserName = "user@gmail.com",
                DateOfBirth = DateTime.Now,
                Faculty = "Công nghệ thông tin",
                FullName = "Nguyễn Thị B",
                Gender = false,
                NormalizedEmail = "USER@GMAIL.COM",
                NormalizedUserName = "USER@GMAIL.COM",
                PhoneNumber = "0900000000",
                PlaceOfBirth = "TP.HCM",
            };

            user.PasswordHash = ph.HashPassword(user, "123456@Abc");

            builder.Entity<ApplicationUser>().HasData(new List<ApplicationUser>
            {
                user, admin
            });

            // User Roles
            builder.Entity<IdentityUserRole<string>>().HasData(new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = adminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = userRoleId,
                    UserId = userId
                },
            });

            return builder;
        }
    }
}
