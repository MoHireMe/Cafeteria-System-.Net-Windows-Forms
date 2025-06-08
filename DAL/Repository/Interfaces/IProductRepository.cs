using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Repository.Interfaces
{
    public interface IProductRepository
    {
        //Get method
        Product GetProductById(int Id);
        ICollection<Product> GetProductByName(string ProductName);
        ICollection<Product> GetAllProduct();
        ICollection<Product> GetProductsByCatigory(int CatigoryId);

        //Update method
        void UpdatePricePerUnit(int productId,decimal PricePerUnit);
        void UpdateCost(int productId, decimal Cost);
        void UpdateNumberOfUnitsInStore(int productId, int NumberOfUnitsInStore);
        void UpdateCategory(int productId, int CategoryId);
        
        //Add method 
        void AddProduct(Product product);   
    }
}
