using ApiSortidas.Domain.Entities;
using ApiSortidas.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ApiSortidas.Application.Commands.InserirUsuario
{
    public class InserirUsuarioCommandHandler : IRequestHandler<InserirUsuarioCommand>
    {

        private readonly IUsuarioRepository _repository;

        public InserirUsuarioCommandHandler(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(InserirUsuarioCommand request, CancellationToken cancellationToken)
        {
           var usuario = new User(request.Username, request.Email, request.Password, request.Role);
            await _repository.Insere(usuario);
            return Unit.Value;
            //throw new NotImplementedException(); 
        }
    }
}
