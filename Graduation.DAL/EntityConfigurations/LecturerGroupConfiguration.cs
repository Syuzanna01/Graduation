using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class LecturerGroupConfiguration: IEntityTypeConfiguration<LecturerGroupEntity>
    {
        public void Configure(EntityTypeBuilder<LecturerGroupEntity> builder)
        {
            builder.HasKey(d => d.Id);
            builder.HasOne(c => c.Lecturer).WithMany(d => d.LecturerGroups);
            builder.HasOne(b => b.Group).WithMany(d => d.LecturerGroups);
        }
    }
}
