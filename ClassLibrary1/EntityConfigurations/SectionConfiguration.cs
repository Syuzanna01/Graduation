using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace DataAccessLayer.EntityConfigurations
{
    public class SectionConfiguration : IEntityTypeConfiguration<SectionEntitiy>
    {
        public void Configure(EntityTypeBuilder<SectionEntitiy> builder)
        {
            builder.HasKey(f => f.Id);
        }
    }
}
