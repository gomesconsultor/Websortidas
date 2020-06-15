using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSortidas.Application.Commands.InserirCategoria;
using ApiSortidas.Application.Querys.Queries.ObtemTodasCategorias;
using ApiSortidas.Application.Querys.Queries.ObterCategoria;
using ApiSortidas.Domain.Entities;
using ApiSortidas.REST.Payloads;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSortidas.REST.Controllers
{
    [ApiController]
    //[Route("v1/category")]
    [Route("[controller]/[action]")]

    public class CategoriaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("")]
        [HttpPost]
        public async Task<ActionResult> Insere(InsereCategoriaPayload request)
        {
            var command = new InserirCategoriaCommand(request.Nome);
            await _mediator.Send(command);
            return Ok();
        }

        


        [HttpGet]
        [Route("")]
        public async Task<ActionResult> ObtemTodas()
        {
            //var query = new ObtemTodasASCategoriasQuery();
            var result = await _mediator.Send(new ObtemTodasASCategoriasQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetById(int id)
        {

            var command = new ObterCategoryByIdQuery(id);
            var result = await _mediator.Send(command);
            return Ok(result);

            //return null;
        }

        //[HttpGet]
        //public async Task<ActionResult> ObtemAbertas()
        //{
        //    return await Task.FromResult<ActionResult>(Ok());

        //}
    }
}