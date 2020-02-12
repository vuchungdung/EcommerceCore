using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EcommerceCore.Data.EF.Extensions;
using EcommerceCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCore.Data.EF.Configurations
{
    public class TagConfiguration : DbEntityConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.Property(c => c.Id).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
        }
    }
}
