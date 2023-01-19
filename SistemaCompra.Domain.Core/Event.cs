using MediatR;
using System;

namespace SistemaCompra.Domain.Core
{
    public abstract class Event : INotification
    {
        public DateTime DataOcorrencia => DateTime.Now;
    }
}
