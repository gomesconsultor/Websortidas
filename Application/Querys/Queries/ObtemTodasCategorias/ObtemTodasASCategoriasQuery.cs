using ApiSortidas.Application.Querys.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSortidas.Application.Querys.Queries.ObtemTodasCategorias
{
    public class ObtemTodasASCategoriasQuery : IRequest<CategoriaViewModel[]>
    {
    }
}
