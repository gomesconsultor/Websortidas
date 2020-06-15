using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiSortidas.Domain.Repositories.Interface.Generics
{
    public interface InterfaceGeneric<T> where T: class
    {
        Task<bool> Add(T obj);
        Task Update(T obj);
        Task<T> Deletar(T obj);
        Task<T> Obter(int id);
        Task<IEnumerable<T>>  GetAll();
        
    }
}
