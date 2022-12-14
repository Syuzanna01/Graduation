using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class InstituteConfiguration : IEntityTypeConfiguration<InstituteEntity>
    {
        public void Configure(EntityTypeBuilder<InstituteEntity> builder)
        {
            builder.HasKey(a => a.Id);
            builder.HasMany(f => f.Sections).WithOne(a => a.Institute);
        }
    }
}
