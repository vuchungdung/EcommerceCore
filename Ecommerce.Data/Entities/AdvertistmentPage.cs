﻿using EcommerceCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EcommerceCore.Data.Entities
{
    [Table("AdvertistmentPages")]
    public class AdvertistmentPage : DomainEntity<string>
    {
        public string Name { get; set; }

        public virtual ICollection<AdvertistmentPosition> AdvertistmentPositions { get; set; }

    }
}
