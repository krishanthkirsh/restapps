using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ABCRestaurant_Data.DBConnection;
using ABCRestaurant_Data.Entitys;

namespace ABCRestaurant_Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly RestaurantDBContext  _Dbcontext;

        public UserRepository(RestaurantDBContext dBConn)
        {
            this._Dbcontext = dBConn;
        }

        public void AddUser(User user)
        {
           _Dbcontext.Users.Add(user);
        }

        public bool DeleteUser(int userId)
        {
            var removed = false;
            User user = GetUser(userId);

            if(user != null)
            {
                _Dbcontext.Users.Remove(user);
                removed = true;
            }
            return removed;
        }

        public User GetUser(int Id)
        {
            return _Dbcontext.Users.Where(u => u.UserID == Id).FirstOrDefault();
        }

        public IEnumerable<User> GetUsers()
        {
            return _Dbcontext.Users;
        }
    }
}
