using AutoMapper;
using MediatR;
using SistemaCompra.Domain.ProdutoAggregate;
using SistemaCompra.Infra.Data.UoW;
using System;
using System.Threading;
using System.Threading.Tasks;
using ProdutoAgg = SistemaCompra.Domain.ProdutoAggregate;

namespace SistemaCompra.Application.Produto.Command.AtualizarPreco
{
    public class AtualizarPrecoCommandHandler : CommandHandler, IRequestHandler<AtualizarPrecoCommand, bool>
    {
        private readonly IProdutoRepository _produtoRepository;

        public AtualizarPrecoCommandHandler(ProdutoAgg.IProdutoRepository produtoRepository, IUnitOfWork uow, IMediator mediator) : base(uow, mediator)
        {
            this._produtoRepository = produtoRepository;
        }
        public Task<bool> Handle(AtualizarPrecoCommand request, CancellationToken cancellationToken)
        {
            var produto = _produtoRepository.Obter(request.Id);
            produto.AtualizarPreco(request.Preco);
            _produtoRepository.Atualizar(produto);

            Commit();
            PublishEvents(produto.Events);

            return Task.FromResult(true);
        }
    }
}
