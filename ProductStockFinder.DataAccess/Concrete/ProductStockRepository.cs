using ProductStockFinder.DataAccess.Abstract;
using ProductStockFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStockFinder.DataAccess.Concrete
{
    public class ProductStockRepository : IProductStockRepository
    {
        public ProductStock CreateProductStock(ProductStock productStock)
        {
            using (var productStockDbContext = new ProductStockDbContext())
            {
                productStockDbContext.ProductStocks.Add(productStock);
                productStockDbContext.SaveChanges();
                return productStock;
            }
        }

        public void DeleteProduct(int id)
        {
            using (var productStockDbContext = new ProductStockDbContext())
            {
                var deletedProductStock = GetProductStockById(id);
                productStockDbContext.ProductStocks.Remove(deletedProductStock);
                productStockDbContext.SaveChanges();
            }
        }

        public List<ProductStock> GetAllProductStock()
        {
            using(var productStockDbContext = new ProductStockDbContext())
            {
                return productStockDbContext.ProductStocks.ToList();
            }
        }

        public ProductStock GetProductStockById(int id)
        {
            using (var productStockDbContext = new ProductStockDbContext())
            {
                return productStockDbContext.ProductStocks.Find(id);
            }
        }

        public ProductStock UpdateProductStock(ProductStock productStock)
        {
            using (var productStockDbContext = new ProductStockDbContext())
            {
                productStockDbContext.ProductStocks.Update(productStock);
                productStockDbContext.SaveChanges();
                return productStock;
            }
        }
    }
}
