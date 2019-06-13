using ABCRestaurant_Data.DBConnection;
using ABCRestaurant_Data.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ABCRestaurant_Data.Repository
{
    public class Repository<T> : IRepository 
    {
     private RestaurantDBContext _dBConn;
     internal DbSet<T> dbSet;


        public Repository(RestaurantDBContext dBConn)
        {
            this._dBConn = dBConn;
        }

        public void Add(T entity)
        {
            _dBConn.dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dBConn.dbSet.Remove(entity);
        }

        public Menu FindById(int Id)
        {
            return _dBConn.dbSet.Where(x => x.MenuID == Id).FirstOrDefault();
        }

        public IEnumerable<T> List()
        {
            return _dBConn.dbSet;
        }

        public void Update(T entity)
        {
            _dBConn.Entry(entity).State = EntityState.Modified;
            _dBConn.SaveChanges();
        }
    }
}
