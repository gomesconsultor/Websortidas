using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace ApiSortidas.Application.Querys.Queries.ObterCategoria
{
    public class ObterCategoryByIdQuery : IRequest<ObterCategoryByIdResponse>
    {
        public ObterCategoryByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

    }

    
}
