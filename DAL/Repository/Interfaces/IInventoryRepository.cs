using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface IInventoryRepository
    {
        // GET methods
        Inventory GetInventoryByProductId(int productId);
        IEnumerable<Inventory> GetAllInventories();
        int GetQuantityInStock(Inventory inventory);
        DateTime GetLastUpdated(Inventory inventory);

        // Update methods
        void UpdateInventory(Inventory inventory);

        // Set methods
         void AddInventory(Inventory Inventory);

        // Delete methods
        void DeleteInventory(Inventory inventory);

    }
}
