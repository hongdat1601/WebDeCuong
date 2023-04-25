using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeCuong.Data.Entities;
namespace WebDeCuong.Data.Configurations
{
	public class SemesterConfiguration : IEntityTypeConfiguration<Semester>
	{
        public void Configure(EntityTypeBuilder<Semester> builder)
        {
            builder.HasMany(s => s.SubjectCurriculum)
                .WithOne(scs => scs.Semester)
                .HasForeignKey(scs => scs.SemesterId);
        }
    }
}

