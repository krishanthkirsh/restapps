using ABCRestaurant_Data.Entitys;
using System.Collections.Generic;

namespace ABCRestaurant_Data.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        string Getusername();
        //void AddUser(User user);
        //IEnumerable<User> GetUsers();
        //bool DeleteUser(int userId);
        //User GetUser(int Id);
    }
}
