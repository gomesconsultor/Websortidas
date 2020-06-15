using ApiSortidas.Domain.Entities;
using ApiSortidas.Infra.Maps;
using Microsoft.EntityFrameworkCore;
//using MySql;
//using Microsoft.EntityFrameworkCore.Mysql;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace ApiSortidas.Infra
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<User> Usuarios { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Ingridients> Ingredients { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new ProductMap());
            builder.ApplyConfiguration(new CategoryMap());
            builder.ApplyConfiguration(new IngridientsMap());
        }


        

    }
}