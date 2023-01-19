using MediatR;

namespace SistemaCompra.CrossCutting.Bus.Command
{
    public interface ICommand<T> : IRequest<T>
    {
    }
}
