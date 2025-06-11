using DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace BuisnessLayer.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository prod)
        {
            _productRepository = prod;
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return _productRepository.GetAllProduct();
        }
        public Product GetProductById(int id)
        {
            if (id == null)
            {
                throw new Exception("Error");   
            }
            return _productRepository.GetProductById(id);
        }
    }
}
