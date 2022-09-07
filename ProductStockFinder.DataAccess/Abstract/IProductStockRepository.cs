using ProductStockFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStockFinder.DataAccess.Abstract
{
    public interface IProductStockRepository
    {
        List<ProductStock> GetAllProductStock();
        ProductStock GetProductStockById(int id);
        ProductStock CreateProductStock(ProductStock productStock);
        ProductStock UpdateProductStock(ProductStock productStock);
        void DeleteProduct(int id);
    }
}
