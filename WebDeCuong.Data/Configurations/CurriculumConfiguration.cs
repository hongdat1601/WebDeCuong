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
    public class CurriculumConfiguration : IEntityTypeConfiguration<Curriculum>
    {
        public void Configure(EntityTypeBuilder<Curriculum> builder)
        {
            builder.HasMany(c => c.SubjectCurriculum)
                .WithOne(scs => scs.Curriculum)
                .HasForeignKey(scs => scs.CurriculumId);
        }
    }
}

