using MediatR;
using System;

namespace SistemaCompra.Application.Produto.Command.AtualizarPreco
{
    public class AtualizarPrecoCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
        public decimal Preco { get; set; }
    }
}
