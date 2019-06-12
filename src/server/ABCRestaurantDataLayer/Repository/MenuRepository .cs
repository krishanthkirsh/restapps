using ABCRestaurant_Data.DBConnection;
using ABCRestaurant_Data.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ABCRestaurant_Data.Repository
{
    public class MenuRepository : IMenuRepository 
    {
        private RestaurantDBContext _dBConn;

        public MenuRepository(RestaurantDBContext dBConn)
        {
            this._dBConn = dBConn;
        }

        public void Add(Menu entity)
        {
            _dBConn.Menus.Add(entity);
        }

        public void Delete(Menu entity)
        {
            _dBConn.Menus.Remove(entity);
        }

        public Menu FindById(int Id)
        {
            return _dBConn.Menus.Where(x => x.MenuID == Id).FirstOrDefault();
        }

        public IEnumerable<Menu> List()
        {
            return _dBConn.Menus;
        }

        public void Update(Menu entity)
        {
            _dBConn.Entry(entity).State = EntityState.Modified;
            _dBConn.SaveChanges();
        }

        //public void Add(Menu menu)
        //{
        //    _dBConn.Menus.Add(menu);
        //}

        //public bool Delete(int Id)
        //{
        //    var removed = false;
        //    Menu menu = FindById(Id);

        //    if (menu != null)
        //    {
        //        _dBConn.Menus.Remove(menu);
        //        removed = true;
        //    }

        //    return removed;
        //}

        //public IEnumerable<Menu> List()
        //{
        //    return _dBConn.Menus;
        //}

        //public Menu FindById(int Id)
        //{
        //    return _dBConn.Menus.Where(x => x.MenuID == Id).FirstOrDefault();
        //}

        //public void Update(Menu menu)
        //{
        //    _dBConn.Entry(menu).State = EntityState.Modified;
        //    _dBConn.SaveChanges();
        //}
    }
}
