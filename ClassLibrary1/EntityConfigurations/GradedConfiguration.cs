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
    public class GradedConfiguration: IEntityTypeConfiguration<GradedEntity>
    {
        public void Configure(EntityTypeBuilder<GradedEntity> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasOne(g=>g.Student).WithMany(k=>k.Gradeds);
        }
    }
}
