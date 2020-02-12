using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EcommerceCore.Data.EF.Extensions;
using EcommerceCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCore.Data.EF.Configurations
{
    public class ProductTagConfiguration : DbEntityConfiguration<ProductTag>
    {
        public override void Configure(EntityTypeBuilder<ProductTag> entity)
        {
            entity.Property(c => c.TagId).HasMaxLength(50).IsRequired()
            .HasMaxLength(50).IsUnicode(false).HasColumnType("varchar(50)");
            // etc.
        }
    }
}
