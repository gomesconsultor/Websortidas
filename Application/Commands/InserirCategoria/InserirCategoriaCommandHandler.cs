using ApiSortidas.Domain.Entities;
using ApiSortidas.Domain.Repositories.Interface.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ApiSortidas.Application.Commands.InserirCategoria
{
    public class InserirCategoriaCommandHandler : IRequestHandler<InserirCategoriaCommand>
    {
        private readonly ICategoryRepository _repository;

        public InserirCategoriaCommandHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(InserirCategoriaCommand request, CancellationToken cancellationToken)
        {
            var categoria = new Category();
            categoria.Title = request.Nome;
            

            //categoria.InsereProdutoCategoria(produto);
            await _repository.Add(categoria);
            return Unit.Value;

        }
    }
}
