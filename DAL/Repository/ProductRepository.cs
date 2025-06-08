using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Data;
using DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
namespace DAL.Repository
{
    public class ProductRepository:IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        //GetProductById
        public Product GetProductById(int Id)
        {
            var product = _context.Product
                .Include(p => p.Category)
                .Include(p => p.Inventory)
                .FirstOrDefault(p => p.Id == Id);

            return product;
        }

        //GetProductByName
        public ICollection<Product> GetProductByName(string ProductName)
        {
            return _context.Product
        .Include(p => p.Category)
        .Include(p => p.Inventory)
        .Where(p => p.ProductName.ToLower() == ProductName.ToLower())
        .ToList();
        }

        //GetAllProduct
        public ICollection<Product> GetAllProduct()
        {
            return _context.Product
                .Include(p => p.Category)
                .Include(p => p.Inventory)
                .ToList();
        }

        //GetProductsByCatigory
        public ICollection<Product> GetProductsByCatigory(int CatigoryId)
        {
             return _context.Product
            .Include(p => p.Category)
            .Include(p => p.Inventory)
            .Where(p => p.CategoryId == CatigoryId)
            .ToList();
        }

        //UpdatePricePerUnit
        public void UpdatePricePerUnit(int productId, decimal PricePerUnit)
        {
            var product = _context.Product.Find(productId);
            
            product.PricePerUnit = PricePerUnit;
            _context.SaveChanges();
            
        }
        //UpdateCost
        public void UpdateCost(int productId, decimal Cost)
        {
            var product = _context.Product.Find(productId);
            product.Cost = Cost;
            _context.SaveChanges();
        }

        //UpdateNumberOfUnitsInStore
        public void UpdateNumberOfUnitsInStore(int productId, int NumberOfUnitsInStore)
        {
            var product = _context.Product.Find(productId);
            product.NumberOfUnitsInStore = NumberOfUnitsInStore;
            _context.SaveChanges();

        }
        //UpdateCategory
        public void UpdateCategory(int productId, int CategoryId)
        {
            var product = _context.Product.Find(productId);
            product.CategoryId = CategoryId;
            _context.SaveChanges();

        }

        //Add method 
        public void AddProduct(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();
        }
    }
    
}
