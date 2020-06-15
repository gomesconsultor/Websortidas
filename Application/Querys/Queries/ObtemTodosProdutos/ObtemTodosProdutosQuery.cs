using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSortidas.Application.Querys.ViewModels;
using MediatR;

namespace ApiSortidas.Application.Querys.Queries.ObtemTodosProdutos
{
    public class ObtemTodosProdutosQuery: IRequest<ProdutoViewModel[]>
    {
    }
}
