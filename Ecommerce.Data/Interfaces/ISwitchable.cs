﻿using EcommerceCore.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCore.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
