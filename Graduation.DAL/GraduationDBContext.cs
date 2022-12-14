using DataAccessLayer.Entities;
using DataAccessLayer.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation.DAL
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("server=DESKTOP-12K9FRQ;database=GraduationDB;trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new SectionConfiguration());
            modelBuilder.ApplyConfiguration(new InstituteConfiguration());
            modelBuilder.ApplyConfiguration(new LecturerConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new PulpitConfiguration());
            modelBuilder.ApplyConfiguration(new LecturerGroupConfiguration());
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public DbSet<StudentEntity> Students { get; set; }
        public DbSet<LecturerEntitiy> Lecturers { get; set; }
        public DbSet<SectionEntitiy> Sections { get; set; }
        public DbSet<GroupEntity> Groups { get; set; }
        public DbSet<PulpitEntity> Pulpits { get; set; }
        public DbSet<LecturerGroupEntity> LecturerGroups { get; set; }
        public DbSet<InstituteEntity> Institutes { get; set; }
    }
}
