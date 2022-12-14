using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityConfigurations
{
    public class LecturerConfiguration : IEntityTypeConfiguration<LecturerEntitiy>
    {
        public void Configure(EntityTypeBuilder<LecturerEntitiy> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasOne(f => f.Section).WithOne(c => c.Lecturer).HasPrincipalKey<LecturerEntitiy>(x => x.Id);

        }
    }
}
