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
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasMany(s => s.Evaluates)
                .WithOne(e => e.Subject)
                .HasForeignKey(e => e.SubjectId);

            builder.HasMany(s => s.SubjectContents)
                .WithOne(sc => sc.Subject)
                .HasForeignKey(sc => sc.SubjectId);

            builder.HasMany(s => s.EvalElements)
                .WithOne(ee => ee.Subject)
                .HasForeignKey(ee => ee.SubjectId);

            builder.HasMany(s => s.SubjectOutputStandards)
                .WithOne(so => so.Subject)
                .HasForeignKey(so => so.SubjectId);

            builder.HasMany(s => s.SubjectUsers)
                .WithOne(su => su.Subject)
                .HasForeignKey(su => su.SubjectId);
        }
    }
}
