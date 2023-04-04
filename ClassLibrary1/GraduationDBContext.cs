using DataAccessLayer.Entities;
using DataAccessLayer.EntityConfigurations;
using Graduation.DAL.Entitiys;
using Graduation.DAL.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation.DAL
{
    public class GraduationDBContext : DbContext
    {
        public GraduationDBContext() { }
        public GraduationDBContext(DbContextOptions<GraduationDBContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;database=University;Integrated Security=True; Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new SectionConfiguration());
            modelBuilder.ApplyConfiguration(new InstituteConfiguration());
            modelBuilder.ApplyConfiguration(new LecturerConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new ChairsConfiguration());
            modelBuilder.ApplyConfiguration(new LecturerGroupConfiguration());
            modelBuilder.ApplyConfiguration(new GradedConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public DbSet<StudentEntity> Students { get; set; }
        public DbSet<LecturerEntitiy> Lecturers { get; set; }
        public DbSet<SectionEntitiy> Sections { get; set; }
        public DbSet<GroupEntity> Groups { get; set; }
        public DbSet<ChairsEntity> Chairs { get; set; }
        public DbSet<LecturerGroupEntity> LecturerGroups { get; set; }
        public DbSet<InstituteEntity> Institutes { get; set; }
        public DbSet<GradedEntity> Gradeds { get; set; }
        public DbSet<SubjectEntity> Subjects { get; set; }
    }
}
