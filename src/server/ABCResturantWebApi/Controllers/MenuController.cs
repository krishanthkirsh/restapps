using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ABCRestaurantDataLayer.Repository;

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

        public string Get()
        {
            var tes = this._menuRepository;
            return "mystring";
        }
        
    }
}