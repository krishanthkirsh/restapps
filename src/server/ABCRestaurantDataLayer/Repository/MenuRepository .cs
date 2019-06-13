using ABCRestaurant_Data.DBConnection;
using ABCRestaurant_Data.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ABCRestaurant_Data.Repository
{
    public class MenuRepository : Repository<Menu>, IMenuRepository 
    {
        public MenuRepository(RestaurantDBContext dBConn) 
            : baae(dBConn)
        { }        
    }
}
