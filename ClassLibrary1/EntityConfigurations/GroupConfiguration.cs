using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<GroupEntity>
    {
        public void Configure(EntityTypeBuilder<GroupEntity> builder)
        {
            builder.HasKey(b => b.Id);
            builder.HasOne(f => f.Section).WithMany(b => b.Groups);//.HasForeignKey(b => b.SectionId);
            builder.HasMany(e => e.Students).WithOne(d => d.Group);
        }
    }
}
