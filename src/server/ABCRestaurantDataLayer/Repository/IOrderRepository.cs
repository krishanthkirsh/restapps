using ABCRestaurant_Data.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABCRestaurant_Data.Repository
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        Order GetOrderDetails(int Id);
        IEnumerable<Order> GetAllOrders();
        bool DeleteOrder(int Id);
    }
}
