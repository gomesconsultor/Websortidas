using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ApiSortidas.Domain.Entities;
using ApiSortidas.Domain.Repositories;
using ApiSortidas.Domain.Repositories.Interface.Entity;
using MediatR;

namespace ApiSortidas.Application.Commands.InserirProduct
{
    public class InserirProductCommandHandler : IRequestHandler<InserirProductCommand>
    {
        private readonly IProductRepository _repository;
        private readonly ICategoryRepository _category;

        public InserirProductCommandHandler(IProductRepository repository, ICategoryRepository categoryRepository)
        {
            _repository = repository;
            _category = categoryRepository;
        }

        public async Task<Unit> Handle(InserirProductCommand request, CancellationToken cancellationToken)
        {
            Category categoria = await _category.Obter(request.CategoryId);
            var produto = new Product(request.Title, request.Description, request.Price, request.Quantity, request.Image, request.CategoryId);
            await _repository.Add(produto);
            return Unit.Value;
            //throw new NotImplementedException(); 
        }
    }
}
