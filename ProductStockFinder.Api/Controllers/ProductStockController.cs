using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductStockFinder.Business;
using ProductStockFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStockFinder.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductStockController : ControllerBase
    {
        private IProductStockService _productStockService;
        public ProductStockController()
        {
            _productStockService = new ProductStockManager();
        }
        [HttpGet]
        public List<ProductStock> Get()
        {
            return _productStockService.GetAllProductStock();
        }
        [HttpGet("{id}")]
        public ProductStock Get(int id)
        {
            return _productStockService.GetProductStockById(id);
        }

        [HttpPut]
        [Route("AddStock/{id}/{count}")]
        public async Task<ProductStock> AddStock(int id,int count)
        {
            var ProductStock = _productStockService.GetProductStockById(id);
            ProductStock.ProductStockCount += count;
            return await _productStockService.UpdateProductStock(ProductStock);
        }
        [HttpPut]
        [Route("RemoveStock/{id}/{count}")]
        public async Task<ProductStock> RemoveStock(int id, int count)
        {
            var ProductStock = _productStockService.GetProductStockById(id);
            ProductStock.ProductStockCount -= count;
            return await _productStockService.UpdateProductStock(ProductStock);
        }
    }
}
