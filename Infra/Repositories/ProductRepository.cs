using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSortidas.Domain.Entities;
using ApiSortidas.Domain.Repositories.Interface.Entity;
using Microsoft.EntityFrameworkCore;

namespace ApiSortidas.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task<bool> Add(Product obj)
        {
            bool result = false;
            try
            {
                _context.Products.Add(obj);
                await _context.SaveChangesAsync();
                result = true;
            }
            catch
            {

            };

            return result;
        }

        public Task<Product> Deletar(Product obj)
        {
            throw new NotImplementedException();
        }

        public async  Task<IEnumerable<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> Obter(int id)
        {
            return await _context.Products.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Update(Product obj)
        {
            _context.Entry<Product>(obj).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
