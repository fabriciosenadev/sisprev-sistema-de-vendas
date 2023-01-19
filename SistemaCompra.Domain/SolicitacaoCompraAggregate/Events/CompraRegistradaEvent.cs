using SistemaCompra.Domain.Core;
using System;
using System.Collections.Generic;

namespace SistemaCompra.Domain.SolicitacaoCompraAggregate.Events
{
    public class CompraRegistradaEvent : Event
    {
        public Guid Id { get; }
        public IEnumerable<Item> Itens { get; }
        public decimal TotalGeral { get; }

        public CompraRegistradaEvent(Guid id, IEnumerable<Item> itens, decimal TotalGeral)
        {
            Id = id;
            Itens = itens;
            this.TotalGeral = TotalGeral;
        }
    }
}
