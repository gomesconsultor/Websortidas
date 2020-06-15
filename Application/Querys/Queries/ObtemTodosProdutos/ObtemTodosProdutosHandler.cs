using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ApiSortidas.Application.Querys.ViewModels;
using ApiSortidas.Domain.Entities;
using ApiSortidas.Domain.Repositories.Interface.Entity;
using ApiSortidas.Infra;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ApiSortidas.Application.Querys.Queries.ObtemTodosProdutos
{
    public class ObtemTodosProdutosHandler : IRequestHandler<ObtemTodosProdutosQuery, ProdutoViewModel[]>
    {
        private readonly IProductRepository _repository;
        private readonly Context _context;
        public ObtemTodosProdutosHandler(IProductRepository repository, Context context)
        {
            _repository = repository;
            _context = context;
        }

        public async Task<ProdutoViewModel[]> Handle(ObtemTodosProdutosQuery request, CancellationToken cancellationToken)
        {
            
            return await _context.Products
             //
            .Select(x => new ProdutoViewModel()
            {
                Title = x.Title,
                Description = x.Description,
                Price = x.Price,
                Quantity = x.Quantity,
                Image = x.Image,
                CategoryId = x.CategoryId,
                
            }).ToArrayAsync();
            
            //var result = await _repository.GetAll();
            //List<ProdutoViewModel> prod = new List<ProdutoViewModel>();
            //foreach (Product ob in result)
            //{
            //    ProdutoViewModel prd = new ProdutoViewModel();
            //    prd.Title = ob.Title;
            //    prd.Description = ob.Description;
            //    prd.Price = ob.Price;
            //    prd.Quantity = ob.Quantity;
            //    prd.Image = ob.Image;
            //    prd.CategoryId = ob.CategoryId;
            //    prod.Add(prd);
            //}

            //return prod.ToArray();
        }
           
    }
    
}
