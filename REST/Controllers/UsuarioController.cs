using System.Threading.Tasks;
using ApiSortidas.Application.Commands.InserirUsuario;
using ApiSortidas.Application.Querys.Queries;
using ApiSortidas.Application.Querys.Queries.ObtemTodosUsuarios;
using ApiSortidas.Application.Querys.Queries.ObtemUsuario;
using ApiSortidas.Infra;
using ApiSortidas.REST.Payloads;
using ApiSortidas.Services;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiSortidas.REST.Controllers
{

	[ApiController]
    //[Route("v1/users")]
    [Route("[controller]/[action]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IMediator _mediator;
        //private readonly Context _context;

        public UsuarioController(IMediator mediator)
        {
            
            _mediator = mediator;
        }


        [HttpPost]
        [Route("")]
        [AllowAnonymous]
        public async Task<ActionResult> Insere(InsereUsuarioPayload request)
        {
            request.Role = "employee";
            var command = new InserirUsuarioCommand(request.Username, request.Email, request.Password, request.Role);
            await _mediator.Send(command);
            return Ok();
        }


        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate(
                    [FromServices] Context context,
                    [FromBody]InsereLoginPayload model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var user = await context.Usuarios.FirstOrDefaultAsync(x => x.Usuario == model.Username && x.Password == model.Password);

                if (user == null)
                    return StatusCode(404, "Usuário ou senha inválidos");
                model.Role = user.Role;
                var token = TokenService.GenerateToken(model);
                user.Password = "";
                //model.Role = "";
                return Ok(new
                {
                    user = user,
                    token = token
                }); ;
            }
            catch
            {
                return StatusCode(500, "Falha na autenticação");
            }
        }

       

       
        

        [HttpGet]
        [Route("")]
        public async Task<ActionResult> ObtemTodas()
        {
            var result = await _mediator.Send(new ObtemTodosOsUsuariosQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetById(int id)
        {

            var command = new ObterUsuarioByIdQuery(id);
            var result = await _mediator.Send(command);
            return Ok(result);
        }


        
    }
}