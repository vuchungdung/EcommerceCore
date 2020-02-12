using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCore.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
