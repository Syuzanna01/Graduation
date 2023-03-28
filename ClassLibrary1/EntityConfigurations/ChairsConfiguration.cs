using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class ChairsConfiguration : IEntityTypeConfiguration<ChairsEntity>
    {
        public void Configure(EntityTypeBuilder<ChairsEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasMany(f => f.Sections).WithOne(e => e.Chairs);
        }
    }
}
