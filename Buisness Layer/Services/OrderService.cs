using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository.Interfaces;
using Models;

namespace BuisnessLayer.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order GetOrderById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid order ID.");

            var order = _orderRepository.GetOrderById(id);
            if (order == null)
                throw new ArgumentException("Order not found.");

            return order;
        }

        public ICollection<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public ICollection<Order> GetOrdersByDate(DateTime date)
        {
            return _orderRepository.GetOrdersByDate(date);
        }

        public ICollection<Order> GetOrdersByTotal(decimal total)
        {
            if (total < 0)
                throw new ArgumentException("Total must be non-negative.");

            return _orderRepository.GetOrdersByTotal(total);
        }

        public void AddOrder(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            if (order.Total < 0)
                throw new ArgumentException("Order total must be non-negative.");

            _orderRepository.AddOrder(order);
        }

        public void DeleteOrder(int orderId)
        {
            var order = _orderRepository.GetOrderById(orderId);
            if (order == null)
                throw new ArgumentException("Order not found.");

            _orderRepository.DeleteOrder(orderId);
        }
    }
}
