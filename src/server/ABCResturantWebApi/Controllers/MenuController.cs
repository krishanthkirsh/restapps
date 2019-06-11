using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ABCRestaurant_Data.Repository;
using ABCRestaurant_Data.Entitys;

namespace ABCResturantWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuRepository _menuRepository;
        public MenuController(IMenuRepository menuRespository)
        {
            this._menuRepository = menuRespository;
        }

        [HttpGet]
        public List<Menu> GetAllProducts()
        {
            List<Menu> _List = this._menuRepository.GetAllMenuProducts().ToList();
            return _List;
        }

        [HttpPost]
        public void InsertMenuProducts(Menu menu)
        {
            this._menuRepository.AddMenu(menu);
        }

        [HttpDelete]
        public bool DeleteMenuProduct(int Id)
        {
            bool _result = this._menuRepository.DeleteMenuProduct(Id);
            return _result;
        }
        [HttpGet]
          public Menu GetMenuProducts(int Id)
        {
            Menu _menu = this._menuRepository.GetMenuProduct(Id);
            return _menu;
        }
        [HttpPost]
        public void UpdateMenuProduct(Menu menu)
        {
            this._menuRepository.UpdateMenuProduct(menu);
        }


        
    }
}