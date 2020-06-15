using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSortidas.Application.Commands.InserirProduct;
using ApiSortidas.Application.Querys.Queries.ObtemTodosProdutos;
using ApiSortidas.REST.Payloads;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSortidas.REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProdutoController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [Route("")]
        [HttpPost]
        public async Task<ActionResult> Insere(InsereProductPlayload request)
        {
            var command = new InserirProductCommand(request.Title, request.Description, request.Price, request.Quantity, request.Image, request.CategoryId);
            await _mediator.Send(command);
            return Ok();
        }


        [HttpGet]
        [Route("")]
        public async Task<ActionResult> ObtemTodas()
        {
            var result = await _mediator.Send(new ObtemTodosProdutosQuery());
            return Ok(result);





        }
    }
}
