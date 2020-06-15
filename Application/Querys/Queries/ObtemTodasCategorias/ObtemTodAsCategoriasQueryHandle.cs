using ApiSortidas.Application.Querys.ViewModels;
using ApiSortidas.Infra;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ApiSortidas.Application.Querys.Queries.ObtemTodasCategorias
{


    public class ObtemTodAsCategoriasQueryHandle : IRequestHandler<ObtemTodasASCategoriasQuery, CategoriaViewModel[]>
    {
        private readonly Context _context;

        public ObtemTodAsCategoriasQueryHandle(Context context)
        {
            _context = context;
        }

        public async Task<CategoriaViewModel[]> Handle(ObtemTodasASCategoriasQuery request, CancellationToken cancellationToken)
        {
            

            return await _context.Categories.Select(categorie => new CategoriaViewModel()
            {
                Id = categorie.Id,
                Title = categorie.Title

            }).ToArrayAsync();
        }
    }
        
    
}
