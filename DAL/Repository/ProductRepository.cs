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
                
                .SingleOrDefault(p => p.Id == Id);

            return product;
        }

        //GetProductByName
        public Product GetProductByName(string ProductName)
        {
            return _context.Product.Include(p => p.Category).SingleOrDefault(p => p.ProductName == ProductName);
        ;
        }

        //GetAllProduct
        public ICollection<Product> GetAllProduct()
        {
            return _context.Product
                .Include(p => p.Category)
                
                .ToList();
        }

        //GetProductsByCatigory
        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            return _context.Product
                .Where(p => p.CategoryId == categoryId)
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


        // Delete method
        public void DeleteProduct(int ProductId)
        {
            var Product = _context.Product.Find(ProductId);

            _context.Product.Remove(Product);
            _context.SaveChanges();

        }
    }
    
}
