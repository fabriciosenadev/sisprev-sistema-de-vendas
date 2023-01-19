using SistemaCompra.Domain.Core;
using System;

namespace SistemaCompra.Domain.ProdutoAggregate.Events
{
    public class PrecoAtualizadoEvent : Event
    {
        public Guid Id { get; }
        public decimal Preco { get; }

        public PrecoAtualizadoEvent(Guid id, decimal preco)
        {
            Id = id;
            Preco = preco;
        }
    }
}
