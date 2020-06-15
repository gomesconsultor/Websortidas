using System;

using System.Collections.Generic;

namespace ApiSortidas.Domain.Entities
{
    public class Category:  Entity
    {
       
        // public Category(int id, string title, IEnumerable<Product> products)
        // {
        //     Id = id;
        //     Title = title;
        //     Products = products;
        // }


        public string Title { get; set; }
        public virtual IEnumerable<Product> Products { get; set;}

        
    }
}