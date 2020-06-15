using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSortidas.Domain.Entities;

namespace ApiSortidas.Application.Querys.ViewModels
{
    public class ProdutoViewModel
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Image { get; set; }


        public int CategoryId { get; set; }

        

    }
}
