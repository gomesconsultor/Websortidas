using ApiSortidas.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSortidas.Application.Commands.InserirCategoria
{
    public class InserirCategoriaCommand: IRequest
    {
        public InserirCategoriaCommand(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; }
               
       // public IEnumerable<Product> Produtos { get; }

        
    }
}
