using ABCRestaurantDataLayer.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABCRestaurantDataLayer.Repository
{
    public interface IMenuRepository
    {
        void AddMenu(Menu menu);
        Menu GetMenuProduct(int Id);
        IEnumerable<Menu> GetAllMenuProducts();
        bool DeleteMenuProduct(int Id);
        void UpdateMenuProduct(Menu menu);
    }
}
