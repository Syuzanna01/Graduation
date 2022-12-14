using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class PulpitConfiguration : IEntityTypeConfiguration<PulpitEntity>
    {
        public void Configure(EntityTypeBuilder<PulpitEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasMany(a => a.Institutes).WithOne(e => e.Pulpit);
        }
    }
}
