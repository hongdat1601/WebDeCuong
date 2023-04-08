using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebDeCuong.Data.Configurations
{
    internal class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            var roles = new List<IdentityRole>();

            var userRole = new IdentityRole();
            userRole.Id = Guid.NewGuid().ToString();
            userRole.Name = "User";
            userRole.NormalizedName = userRole.Name.ToUpper();
            roles.Add(userRole);

            var adminRole = new IdentityRole();
            adminRole.Id = Guid.NewGuid().ToString();
            adminRole.Name = "Admin";
            adminRole.NormalizedName = adminRole.Name.ToUpper();
            roles.Add(adminRole);

            builder.HasData(roles);
        }
    }
}
