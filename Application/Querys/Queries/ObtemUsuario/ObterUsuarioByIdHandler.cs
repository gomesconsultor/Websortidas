using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ApiSortidas.Domain.Repositories;
using MediatR;

namespace ApiSortidas.Application.Querys.Queries.ObtemUsuario
{
    public class ObterUsuarioByIdHandler: IRequestHandler<ObterUsuarioByIdQuery, ObterUsuarioByIdResponse>
    {
        public readonly IUsuarioRepository _repository;

        public ObterUsuarioByIdHandler(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<ObterUsuarioByIdResponse> Handle(ObterUsuarioByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _repository.ObterPorId(request.Id);

            return new ObterUsuarioByIdResponse
            {
                Id = request.Id,
                Name = result.Usuario,
                Email = result.Email
            };
        }
    }
}

    

