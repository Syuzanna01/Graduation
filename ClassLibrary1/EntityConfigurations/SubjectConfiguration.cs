using DataAccessLayer.Entities;
using Graduation.DAL.Entitiys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation.DAL.EntityConfigurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<SubjectEntity>
    {
        public void Configure(EntityTypeBuilder<SubjectEntity> builder)
        {
            builder.HasKey(l => l.Id);
            //builder.HasOne(l => l.Kredit).HasOne();
            //builder.HasMany(k => k.Gradeds).WithOne(l => l.Subject);

        }
    }
}
