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
    public class OrderRepository:IOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get methods
        public Order GetOrderById(int id)
        {
            return _context.Order
                .Include(o => o.OrderItems)
                .SingleOrDefault(o => o.Id == id);
        }

        public ICollection<Order> GetAllOrders()
        {
            return _context.Order
                .Include(o => o.OrderItems)
                .ToList();
        }

        public ICollection<Order> GetOrdersByDate(DateTime date)
        {
            return _context.Order
                .Include(o => o.OrderItems)
                .Where(o => o.CreatedAt.Date == date.Date)
                .ToList();
        }

        public ICollection<Order> GetOrdersByTotal(decimal total)
        {
            return _context.Order
                .Include(o => o.OrderItems)
                .Where(o => o.Total == total)
                .ToList();
        }

        // Delete method
        public void DeleteOrder(int orderId)
        {
            var order = _context.Order.Find(orderId);
           
                _context.Order.Remove(order);
                _context.SaveChanges();
            
        }

        // Add method
        public void AddOrder(Order order)
        {
            _context.Order.Add(order);
            _context.SaveChanges();
        }
    }

}

