using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebDeCuong.Data.Configurations;
using WebDeCuong.Data.Entities;
using WebDeCuong.Data.Extensions;

namespace WebDeCuong.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Subject> Subjects => Set<Subject>();
        public DbSet<Evaluate> Evaluates => Set<Evaluate>();
        public DbSet<SubjectContent> SubjectContents => Set<SubjectContent>();
        public DbSet<EvalElement> EvalElements => Set<EvalElement>();
        public DbSet<SubjectUser> SubjectUsers => Set<SubjectUser>();
        public DbSet<SubjectOutputStandard> SubjectOutputStandards => Set<SubjectOutputStandard>();
        public DbSet<Curriculum> Curriculums => Set<Curriculum>();
        public DbSet<Semester> Semesters => Set<Semester>();
        public DbSet<SubjectCurriculum> SubjectCurriculums => Set<SubjectCurriculum>();
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new SubjectConfiguration());
            builder.ApplyConfiguration(new CurriculumConfiguration());
            builder.ApplyConfiguration(new SemesterConfiguration());
            builder.SeedData();
        }

    }
}
