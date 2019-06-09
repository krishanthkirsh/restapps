using ABCRestaurantDataLayer.DBConnection;
using ABCRestaurantDataLayer.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ABCRestaurantDataLayer.Repository
{
    class MenuRepository : IMenuRepository
    {
        private DBConn _dBConn;
        public MenuRepository(DBConn dBConn)
        {
            this._dBConn = dBConn;
        }

        public void AddMenu(Menu menu)
        {
            _dBConn.Menus.Add(menu);
        }

        public bool DeleteMenuProduct(int Id)
        {
            var removed = false;
            Menu menu = GetMenuProduct(Id);

            if (menu != null)
            {
                _dBConn.Menus.Remove(menu);
                removed = true;
            }

            return removed;
        }

        public IEnumerable<Menu> GetAllMenuProducts()
        {
            return _dBConn.Menus;
        }

        public Menu GetMenuProduct(int Id)
        {
            return _dBConn.Menus.Where(x => x.MenuID == Id).FirstOrDefault();
        }

        public void UpdateMenuProduct(Menu menu)
        {
            _dBConn.Entry(menu).State = EntityState.Modified;
            _dBConn.SaveChanges();
        }
    }
}
