using System;

namespace SistemaCompra.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SistemaCompraContext sistemaDeComprasContexto;

        public UnitOfWork(SistemaCompraContext context)
        {
            sistemaDeComprasContexto = context;
        }

        public bool Commit()
        {
            return sistemaDeComprasContexto.SaveChanges() > 0;
        }

        public void Dispose()
        {
            sistemaDeComprasContexto.Dispose();
        }
    }
}
