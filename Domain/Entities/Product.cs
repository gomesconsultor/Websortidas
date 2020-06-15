using System;

namespace ApiSortidas.Domain.Entities
{
    public class Product:  Entity
    {
        public Product(string title, string description, decimal price, int quantity, string image, int categoryId)
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

        public virtual Category Category { get; set; }


    }
}