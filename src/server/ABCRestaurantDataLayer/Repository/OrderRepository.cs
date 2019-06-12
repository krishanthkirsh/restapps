using System.Collections.Generic;
using System.Linq;
using ABCRestaurant_Data.DBConnection;
using ABCRestaurant_Data.Entitys;
using Microsoft.EntityFrameworkCore;

namespace ABCRestaurant_Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private RestaurantDBContext _dBConn;

        public OrderRepository(RestaurantDBContext dBConn)
        {
            this._dBConn = dBConn;
        }

        public void Add(Order entity)
        {
            _dBConn.Orders.Add(entity);
        }

        public void Delete(Order entity)
        {
            _dBConn.Orders.Remove(entity);
        }

        public Order FindById(int Id)
        {
            return _dBConn.Orders.Where(x => x.OrderID == Id).FirstOrDefault();
        }

        public IEnumerable<Order> List()
        {
            return _dBConn.Orders;
        }

        public void Update(Order entity)
        {
            _dBConn.Entry(entity).State = EntityState.Modified;
            _dBConn.SaveChanges();
        }

        //public void AddOrder(Order order)
        //{
        //    _dBConn.Orders.Add(order);
        //}

        //public bool DeleteOrder(int Id)
        //{
        //    var removed = false;
        //    Order order = GetOrderDetails(Id);
        //    if (order != null)
        //    {
        //        _dBConn.Orders.Remove(order);
        //        removed = true;
        //    }
        //    return removed;
        //}

        //public IEnumerable<Order> GetAllOrders()
        //{
        //    return _dBConn.Orders;
        //}

        //public Order GetOrderDetails(int Id)
        //{
        //    return _dBConn.Orders.Where(x => x.OrderID == Id).FirstOrDefault();
        //}
    }
}
