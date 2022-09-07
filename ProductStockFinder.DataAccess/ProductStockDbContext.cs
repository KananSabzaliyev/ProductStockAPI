using Microsoft.EntityFrameworkCore;
using ProductStockFinder.Entities;
using System;

namespace ProductStockFinder.DataAccess
{
    public class ProductStockDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-7U3FDJJ\SQLEXPRESS;Initial Catalog=ProductStockDb;Integrated Security=true;");
        }
        public DbSet<ProductStock> ProductStocks { get; set; }
    }
}
