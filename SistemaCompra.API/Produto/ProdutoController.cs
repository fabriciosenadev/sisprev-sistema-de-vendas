using MediatR;
using Microsoft.AspNetCore.Mvc;
using SistemaCompra.Application.Produto.Command.AtualizarPreco;
using SistemaCompra.Application.Produto.Command.RegistrarProduto;
using SistemaCompra.Application.Produto.Query.ObterProduto;
using System;

namespace SistemaCompra.API.Produto
{
    public class ProdutoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProdutoController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet, Route("produto/{id}")]
        public IActionResult Obter(Guid id)
        {
            var query = new ObterProdutoQuery() { Id = id };
            var produtoViewModel = _mediator.Send(query);
            return Ok(produtoViewModel);
        }

        [HttpPost, Route("produto/cadastro")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult CadastrarProduto([FromBody] RegistrarProdutoCommand registrarProdutoCommand)
        {
            _mediator.Send(registrarProdutoCommand);
            return StatusCode(201);
        }

        [HttpPut, Route("produto/atualiza-preco")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult AtualizarPreco([FromBody] AtualizarPrecoCommand atualizarPrecoCommand)
        {
             _mediator.Send(atualizarPrecoCommand);
            return Ok();

        }
    }
}
