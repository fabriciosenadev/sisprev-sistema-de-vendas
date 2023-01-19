using MediatR;
using SistemaCompra.Domain.ProdutoAggregate.Events;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaCompra.Application.Produto.Command.AtualizarPreco
{
    public class PrecoAtualizadoEventHandler : INotificationHandler<PrecoAtualizadoEvent>
    {
        public Task Handle(PrecoAtualizadoEvent notification, CancellationToken cancellationToken)
        {
            return null;//SignalIR Todo
        }
    }
}
