using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCompra.Domain.Core
{
    public class BusinessRuleException : Exception
    {
        public BusinessRuleException(string message) : base(message)
        {
        }
    }
}
