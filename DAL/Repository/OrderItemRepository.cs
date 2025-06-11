using DAL.Data;
using DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class OrderItemRepository:IOrderItemRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get methods
        public OrderItem GetOrderItemById(int id)
        {
            return _context.OrderItem.SingleOrDefault(oi => oi.Id == id);
        }

        public ICollection<OrderItem> GetAllOrderItems()
        {
            return _context.OrderItem.ToList();
        }

        public ICollection<OrderItem> GetOrderItemsByOrderId(int orderId)
        {
            return _context.OrderItem.Where(oi => oi.OrderId == orderId).ToList();
        }

        public ICollection<OrderItem> GetOrderItemsByProductId(int productId)
        {
            return _context.OrderItem.Where(oi => oi.ProductId == productId).ToList();
        }

        // Update methods
        public void UpdateNumberOfUnits(int orderItemId, int numberOfUnits)
        {
            var orderItem = _context.OrderItem.Find(orderItemId);
            if (orderItem != null)
            {
                orderItem.NumberOfUnits = numberOfUnits;
                _context.SaveChanges();
            }
        }

        // Delete method
        public void DeleteOrderItem(int orderItemId)
        {
            var orderItem = _context.OrderItem.Find(orderItemId);
            if (orderItem != null)
            {
                _context.OrderItem.Remove(orderItem);
                _context.SaveChanges();
            }
        }

        // Add method
        public void AddOrderItem(OrderItem orderItem)
        {
            _context.OrderItem.Add(orderItem);
            _context.SaveChanges();
        }
    }
}
}
