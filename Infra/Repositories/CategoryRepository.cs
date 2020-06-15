using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSortidas.Domain.Entities;  // Model
using ApiSortidas.Domain.Repositories.Interface.Entity; //IPrincipal
using Microsoft.EntityFrameworkCore;

namespace ApiSortidas.Infra.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async Task<bool> Add(Category obj)
        {
            bool result = false;
            try
            {
                _context.Categories.Add(obj);
                await _context.SaveChangesAsync();
                result = true;
            }
            catch
            {

            };
            
            return result;
        }

        public Task<Category> Deletar(Category obj)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> Obter(int id)
        {
            return await _context.Categories.Where(x => x.Id == id).FirstOrDefaultAsync(); 
        }

        public async Task Update(Category obj)
        {
              _context.Entry<Category>(obj).State = EntityState.Modified;
             await _context.SaveChangesAsync();
        }
    }
    
}
