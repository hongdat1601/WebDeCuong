using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebDeCuong.Data.Entities;

namespace WebDeCuong.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("Users");

            builder.HasMany(u => u.SubjectUsers)
                .WithOne(su => su.User)
                .HasForeignKey(su => su.UserId);
        }
    }
}
