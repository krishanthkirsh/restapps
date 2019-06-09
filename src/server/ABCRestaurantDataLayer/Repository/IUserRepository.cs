using ABCRestaurantDataLayer.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABCRestaurantDataLayer.Repository
{
    interface IUserRepository
    {
        void AddUser(User user);
        IEnumerable<User> GetUsers();
        bool DeleteUser(int userId);
        User GetUser(int Id);
    }
}
