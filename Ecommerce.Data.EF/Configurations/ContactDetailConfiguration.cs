using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EcommerceCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EcommerceCore.Data.EF.Extensions;

namespace EcommerceCore.Data.EF.Configurations
{
    public class ContactDetailConfiguration : DbEntityConfiguration<ContactDetail>
    {
        public override void Configure(EntityTypeBuilder<ContactDetail> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}
