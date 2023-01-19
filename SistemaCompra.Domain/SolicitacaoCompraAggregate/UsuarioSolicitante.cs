using SistemaCompra.Domain.Core;
using SistemaCompra.Domain.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCompra.Domain.SolicitacaoCompraAggregate
{
    public class UsuarioSolicitante : ValueObject<UsuarioSolicitante>
    {
        public string Nome { get; }

        private UsuarioSolicitante() { }

        public UsuarioSolicitante(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentNullException(nameof(nome));
            if (nome.Length < 5) throw new BusinessRuleException("Nome de usuário deve possuir pelo menos 8 caracteres.");
            
            Nome = nome;
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new List<object>() { Nome };
        }
    }
}
