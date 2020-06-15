using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ApiSortidas.Domain.Repositories.Interface.Entity;
using MediatR;

namespace ApiSortidas.Application.Querys.Queries.ObterCategoria
{
    public class ObterCategoryByIdHandler : IRequestHandler<ObterCategoryByIdQuery, ObterCategoryByIdResponse>
    {

        public readonly ICategoryRepository _repository;

        public ObterCategoryByIdHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<ObterCategoryByIdResponse> Handle(ObterCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _repository.Obter(request.Id);

            return new ObterCategoryByIdResponse
            {
                Id = request.Id,
                Title = result.Title,
                
            };

            throw new NotImplementedException();
        }
    }
}
