using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSortidas.Domain.Entities;
using ApiSortidas.Domain.Repositories.Interface.Generics;

namespace ApiSortidas.Domain.Repositories.Interface.Entity
{
    public interface IProductRepository: InterfaceGeneric<Product>
    {
    }
}
