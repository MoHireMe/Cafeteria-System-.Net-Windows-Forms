using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Repository.Interfaces
{
    public interface IOrderItemRepository
    {
        // Get methods
        OrderItem GetOrderItemById(int id);
        ICollection<OrderItem> GetAllOrderItems();
        ICollection<OrderItem> GetOrderItemsByOrderId(int orderId);
        ICollection<OrderItem> GetOrderItemsByProductId(int productId);

        // Update methods
        void UpdateNumberOfUnits(int orderItemId, int numberOfUnits);

        // Delete method
        void DeleteOrderItem(int orderItemId);

        // Add method
        void AddOrderItem(OrderItem orderItem);
    }
}
