using ABCRestaurantDataLayer.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABCRestaurantDataLayer.Repository
{
    interface IOrderRepository
    {
        void AddOrder(Order order);
        Order GetOrderDetails(int Id);
        IEnumerable<Order> GetAllOrders();
        bool DeleteOrder(int Id);
    }
}
