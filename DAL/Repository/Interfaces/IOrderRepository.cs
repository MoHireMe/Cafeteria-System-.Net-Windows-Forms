using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Repository.Interfaces
{
    public interface IOrderRepository
    {
        // Get methods
        Order GetOrderById(int id);
        ICollection<Order> GetAllOrders();
        ICollection<Order> GetOrdersByDate(DateTime date);
        ICollection<Order> GetOrdersByTotal(decimal total);

        //delete method
        void DeleteOrder(int orderId);
       

        // Add method
        void AddOrder(Order order);





    }
}
