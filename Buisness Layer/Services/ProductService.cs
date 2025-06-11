using DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository.Interfaces;
using Models;

namespace BuisnessLayer.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product GetProductById(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
                throw new ArgumentException("Product not found.");
            return product;
        }

        public Product GetProductByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Product name must not be empty.");

            var product = _productRepository.GetProductByName(name);
            if (product == null)
                throw new ArgumentException("Product not found.");

            return product;
        }

        public ICollection<Product> GetAllProducts()
        {
            return _productRepository.GetAllProduct();
        }

        public ICollection<Product> GetProductsByCategory(int categoryId)
        {
            if (categoryId <= 0)
                throw new ArgumentException("Invalid category ID.");

            return _productRepository.GetProductsByCatigory(categoryId);
        }

        public void UpdatePricePerUnit(int productId, decimal pricePerUnit)
        {
            if (productId < 0)
                throw new ArgumentException("product Id must be non-negative.");


            if (pricePerUnit < 0)
                throw new ArgumentException("Price per unit must be non-negative.");

            EnsureProductExists(productId);

            _productRepository.UpdatePricePerUnit(productId, pricePerUnit);
        }

        public void UpdateCost(int productId, decimal cost)
        {
            if (productId < 0)
                throw new ArgumentException("product Id must be non-negative.");
            if (cost < 0)
                throw new ArgumentException("Cost must be non-negative.");

            EnsureProductExists(productId);

            _productRepository.UpdateCost(productId, cost);
        }

        public void UpdateNumberOfUnitsInStore(int productId, int numberOfUnits)
        {
            if (productId < 0)
                throw new ArgumentException("product Id must be non-negative.");
            if (numberOfUnits < 0)
                throw new ArgumentException("Number of units must be non-negative.");

            EnsureProductExists(productId);

            _productRepository.UpdateNumberOfUnitsInStore(productId, numberOfUnits);
        }

        public void UpdateCategory(int productId, int categoryId)
        {
            if (productId < 0)
                throw new ArgumentException("product Id must be non-negative.");
            if (categoryId <= 0)
                throw new ArgumentException("Invalid category ID.");

            EnsureProductExists(productId);

            _productRepository.UpdateCategory(productId, categoryId);
        }

        public void AddProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            if (string.IsNullOrWhiteSpace(product.ProductName))
                throw new ArgumentException("Product name is required.");

            if (product.PricePerUnit < 0)
                throw new ArgumentException("Price per unit must be non-negative.");

            if (product.Cost < 0)
                throw new ArgumentException("Cost must be non-negative.");

            if (product.NumberOfUnitsInStore < 0)
                throw new ArgumentException("Number of units must be non-negative.");

            if (product.CategoryId <= 0)
                throw new ArgumentException("Invalid category ID.");

            _productRepository.AddProduct(product);
        }

        public void DeleteProduct(int productId)
        {
            EnsureProductExists(productId);

            _productRepository.DeleteProduct(productId);
        }

        // Helper method to ensure product exists
        private void EnsureProductExists(int productId)
        {
            var product = _productRepository.GetProductById(productId);
            if (product == null)
                throw new ArgumentException("Product not found.");
        }
    }
}
