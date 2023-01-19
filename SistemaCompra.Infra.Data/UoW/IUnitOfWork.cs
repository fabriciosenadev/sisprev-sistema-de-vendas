using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCompra.Infra.Data.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
