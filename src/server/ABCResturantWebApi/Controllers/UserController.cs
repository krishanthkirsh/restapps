using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ABCRestaurantDataLayer.Repository;
using ABCRestaurantDataLayer.Entitys;

namespace ABCResturantWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
         private readonly IUserRepository _userRepository;

         public UserController(UserRepository userrepository)
         {
             this._userRepository = userrepository;
         }
        // GET: api/User
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public void InsertUser(User user)
        {
            this._userRepository.AddUser(user);
        }

        [HttpGet]
        public bool DeleteUser(int Id)
        {
            bool _result = this._userRepository.DeleteUser(Id);
            return _result;
        }

        [HttpGet]
        public List<User> GetAllUsers()
        {
            List<User> _user = this._userRepository.GetUsers().ToList();
            return _user;
        }

        [HttpGet]
        public User GetSingleUser(int Id)
        {
            User _user = this._userRepository.GetUser(Id);
            return _user;
        }


    }
}
