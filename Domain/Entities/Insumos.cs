using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSortidas.Domain.Entities
{
    public class Insumos: Entity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Unity { get; set; }

        public int Quantity { get; set; }
    }
}
