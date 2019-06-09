using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ABCRestaurantDataLayer.DBConnection;
using ABCRestaurantDataLayer.Entitys;

namespace ABCRestaurantDataLayer.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DBConn  _Dbcontext;

        public UserRepository(DBConn dBConn)
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
