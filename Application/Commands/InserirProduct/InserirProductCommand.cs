using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSortidas.Domain.Entities;
using MediatR;

namespace ApiSortidas.Application.Commands.InserirProduct
{
    public class InserirProductCommand: IRequest
    {
        public InserirProductCommand(string title, string description, decimal price, int quantity, string image, int categoryId )
        {
            Title = title;
            Description = description;
            Price = price;
            Quantity = quantity;
            Image = image;
            CategoryId = categoryId;
            
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Image { get; set; }


        public int CategoryId { get; set; }

       // public Category Category { get; set; }

    }
}
