using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCore.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        bool isDeleted { set; get; }
    }
}
