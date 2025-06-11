using DAL.Data;
using DAL.Repository.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class InventoryRepository : IInventoryRepository
    { 
        private readonly ApplicationDbContext _context;


        public InventoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET methods
        public Inventory GetInventoryByProductId(int productId)
        {
            return _context.Inventory.SingleOrDefault(i => i.ProductId == productId);
        }

        public IEnumerable<Inventory> GetAllInventories()
        {
           return _context.Inventory.ToList();
        }

        public int GetQuantityInStock(Inventory inventory)
        {
           return _context.Inventory.SingleOrDefault(i => i.ProductId == inventory.ProductId)?.QuantityInStock ?? -1;  
        }

        public DateTime GetLastUpdated(Inventory inventory)
        {
           return _context.Inventory.SingleOrDefault(i => i.ProductId == inventory.ProductId)?.LastUpdated ?? DateTime.MinValue;
        }

        // Set methods
        public void AddInventory(Inventory inventory)
        {         
                _context.Inventory.Add(inventory);
                _context.SaveChanges(); 
        }

        // Update methods
        public void UpdateInventory(Inventory inventory)
        {
            _context.Inventory.Update(inventory);
            _context.SaveChanges();
        }
        //Delete methods
        public void DeleteInventory(int productId)
        {
            _context.Inventory.Remove(GetInventoryByProductId(productId));
            _context.SaveChanges();
        }
      
    }
}
