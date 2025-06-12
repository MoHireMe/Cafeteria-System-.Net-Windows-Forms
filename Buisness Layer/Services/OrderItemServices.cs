using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository.Interfaces;
using Models;

namespace BuisnessLayer.Services
{
    public class OrderItemServices
    {
        private readonly IOrderItemRepository _orderItemRepository;

        public OrderItemServices(IOrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }

        public OrderItem GetOrderItemById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid OrderItem ID.");

            var item = _orderItemRepository.GetOrderItemById(id);
            if (item == null)
                throw new ArgumentException("OrderItem not found.");

            return item;
        }

        public ICollection<OrderItem> GetAllOrderItems()
        {
            return _orderItemRepository.GetAllOrderItems();
        }

        public ICollection<OrderItem> GetOrderItemsByOrderId(int orderId)
        {
            if (orderId <= 0)
                throw new ArgumentException("Invalid Order ID.");

            return _orderItemRepository.GetOrderItemsByOrderId(orderId);
        }

        public ICollection<OrderItem> GetOrderItemsByProductId(int productId)
        {
            if (productId <= 0)
                throw new ArgumentException("Invalid Product ID.");

            return _orderItemRepository.GetOrderItemsByProductId(productId);
        }

        public void UpdateNumberOfUnits(int orderItemId, int numberOfUnits)
        {
            if (orderItemId <= 0)
                throw new ArgumentException("Invalid OrderItem ID.");
            if (numberOfUnits < 0)
                throw new ArgumentException("Number of units must be non-negative.");

            _orderItemRepository.UpdateNumberOfUnits(orderItemId, numberOfUnits);
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            if (orderItem == null)
                throw new ArgumentNullException(nameof(orderItem));
            if (orderItem.NumberOfUnits < 0)
                throw new ArgumentException("Number of units must be non-negative.");

            _orderItemRepository.AddOrderItem(orderItem);
        }

        public void DeleteOrderItem(int orderItemId)
        {
            var item = _orderItemRepository.GetOrderItemById(orderItemId);
            if (item == null)
                throw new ArgumentException("OrderItem not found.");

            _orderItemRepository.DeleteOrderItem(orderItemId);
        }
      
    }
}
