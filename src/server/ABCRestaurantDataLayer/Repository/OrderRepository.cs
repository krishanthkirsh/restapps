using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ABCRestaurant_Data.DBConnection;
using ABCRestaurant_Data.Entitys;

namespace ABCRestaurant_Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private RestaurantDBContext _dBConn;

        public OrderRepository(RestaurantDBContext dBConn)
        {
            this._dBConn = dBConn;
        }

        public void AddOrder(Order order)
        {
            _dBConn.Orders.Add(order);
        }

        public bool DeleteOrder(int Id)
        {
            var removed = false;
            Order order = GetOrderDetails(Id);
            if(order != null)
            {
                _dBConn.Orders.Remove(order);
                removed = true;
            }
            return removed;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _dBConn.Orders;
        }

        public Order GetOrderDetails(int Id)
        {
            return _dBConn.Orders.Where(x => x.OrderID == Id).FirstOrDefault();
        }
    }
}
