using ProductStockFinder.DataAccess.Abstract;
using ProductStockFinder.DataAccess.Concrete;
using ProductStockFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProductStockFinder.Business
{
    public class ProductStockManager : IProductStockService
    {

        private readonly HttpClient httpClient;
       
        private IProductStockRepository _productStockRepository;
        public ProductStockManager()
        {
            _productStockRepository = new ProductStockRepository();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:38371/");
        }
        public ProductStock CreateProductStock(ProductStock productStock)
        {
            return _productStockRepository.CreateProductStock(productStock);
        }

        public void DeleteProduct(int id)
        {
            _productStockRepository.DeleteProduct(id);
        }

        public List<ProductStock> GetAllProductStock()
        {
            return _productStockRepository.GetAllProductStock();
        }

        public ProductStock GetProductStockById(int id)
        {
            return _productStockRepository.GetProductStockById(id);
        }

        public async Task<ProductStock> UpdateProductStock(ProductStock productStock)
        {
            var response = await httpClient.GetAsync($"api/Products/{productStock.ProductStockId}");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadFromJsonAsync<ProductStock>();
                return _productStockRepository.UpdateProductStock(productStock);
            }
            else
            {
                throw new Exception("Id is invalid");
            }
        }
    }
    
}
