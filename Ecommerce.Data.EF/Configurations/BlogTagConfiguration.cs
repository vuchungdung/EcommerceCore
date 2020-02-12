
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EcommerceCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EcommerceCore.Data.EF.Extensions;
using Microsoft.EntityFrameworkCore;

namespace EcommerceCore.Data.EF.Configurations
{
    public class BlogTagConfiguration : DbEntityConfiguration<BlogTag>
    {
        public override void Configure(EntityTypeBuilder<BlogTag> entity)
        {
            entity.Property(c => c.TagId).IsRequired()
            .IsUnicode(false).HasMaxLength(50).HasColumnType("varchar(50)");
        }
    }
}
