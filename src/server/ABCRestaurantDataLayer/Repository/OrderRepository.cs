using System.Collections.Generic;
using System.Linq;
using ABCRestaurant_Data.DBConnection;
using ABCRestaurant_Data.Entitys;
using Microsoft.EntityFrameworkCore;

namespace ABCRestaurant_Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public OrderRepository(RestaurantDBContext dBConn)
            : base (dBConn)
        { }       
    }
}
