using ProductStockFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStockFinder.Business
{
    public interface IProductStockService
    {
        List<ProductStock> GetAllProductStock();
        ProductStock GetProductStockById(int id);
        ProductStock CreateProductStock(ProductStock productStock);
        Task<ProductStock> UpdateProductStock(ProductStock productStock);
        void DeleteProduct(int id);
    }
}
