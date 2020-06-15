using System;
using MediatR;

namespace ApiSortidas.Application.Querys.Queries.ObtemUsuario
{
    public class ObterUsuarioByIdQuery : IRequest<ObterUsuarioByIdResponse>
    {
        public ObterUsuarioByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
       
    }
}
