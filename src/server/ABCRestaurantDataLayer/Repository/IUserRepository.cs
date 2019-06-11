using ABCRestaurant_Data.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABCRestaurant_Data.Repository
{
    public interface IUserRepository
    {
        void AddUser(User user);
        IEnumerable<User> GetUsers();
        bool DeleteUser(int userId);
        User GetUser(int Id);
    }
}
