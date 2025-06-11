using DAL.Repository.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace BuisnessLayer.Services;
    public class InventoryService
    { private readonly IInventoryRepository _inventoryRepository;
        public InventoryService(IInventoryRepository Inv) {
            _inventoryRepository = Inv;
        }

        public IEnumerable<Inventory> GetAllInventories()
        {
            return _inventoryRepository.GetAllInventories();
        }

        public Inventory GetInventoryByProductId(int productId)
        {
            if (productId <= 0)
            {
                throw new ArgumentException("Invalid product ID", nameof(productId));
        }
            
        
            return _inventoryRepository.GetInventoryByProductId(productId);
            
        }

        public int GetQuantityInStock(Inventory inventory)
        {
            if (inventory == null || inventory.ProductId <= 0)
            {
                throw new ArgumentException("Invalid inventory or product ID", nameof(inventory));
            }
            return _inventoryRepository.GetQuantityInStock(inventory);
        }
        public DateTime GetLastUpdated(Inventory inventory)
        {
            if (inventory == null || inventory.ProductId <= 0)
            {
                throw new ArgumentException("Invalid inventory or product ID", nameof(inventory));
            }
            return _inventoryRepository.GetLastUpdated(inventory);
        }

        public void AddInventory(Inventory inventory)
        {
            if (inventory == null)
            {
                throw new ArgumentNullException(nameof(inventory), "Inventory cannot be null");
            }
            _inventoryRepository.AddInventory(inventory);
        }

        public void RemoveInventory(int productId) {
            if ( productId <= 0)
            {
                throw new ArgumentException("Invalid inventory or product ID");
            }
            _inventoryRepository.DeleteInventory(productId);
        }

        public void UpdateInventory(Inventory inventory)
        {
            if (inventory == null || inventory.ProductId <= 0)
            {
                throw new ArgumentException("Invalid inventory or product ID");
            }
            _inventoryRepository.UpdateInventory(inventory);

        }
    public int IncreamentQuantityInStock(int productId, int quantityToAdd)
        {
            if (productId <= 0 || quantityToAdd <= 0)
            {
                throw new ArgumentException("Invalid product ID or quantity to add");
            }
            
            var inventory = _inventoryRepository.GetInventoryByProductId(productId);
            if (inventory == null)
            {
                throw new KeyNotFoundException($"Inventory for product ID {productId} not found.");
            }
            
            inventory.QuantityInStock += quantityToAdd;
            inventory.LastUpdated = DateTime.Now;
            _inventoryRepository.UpdateInventory(inventory);
            
            return inventory.QuantityInStock;
    }

    public int DecreamentQuantityInStock(int productId, int quantityToRemove)
        {
            if (productId <= 0 || quantityToRemove <= 0)
            {
                throw new ArgumentException("Invalid product ID or quantity to remove");
            }
            
            var inventory = _inventoryRepository.GetInventoryByProductId(productId);
            if (inventory == null)
            {
                throw new KeyNotFoundException($"Inventory for product ID {productId} not found.");
            }
            
            if (inventory.QuantityInStock < quantityToRemove)
            {
                throw new InvalidOperationException("Insufficient stock to remove the requested quantity.");
            }
            
            inventory.QuantityInStock -= quantityToRemove;
            inventory.LastUpdated = DateTime.Now;
            _inventoryRepository.UpdateInventory(inventory);
            
            return inventory.QuantityInStock;
      }


}
