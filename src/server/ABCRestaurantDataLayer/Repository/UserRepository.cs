using ABCRestaurant_Data.DBConnection;
using ABCRestaurant_Data.Entitys;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ABCRestaurant_Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly RestaurantDBContext _Dbcontext;

        public UserRepository(RestaurantDBContext dBConn)
        {
            this._Dbcontext = dBConn;
        }

        public void Add(User entity)
        {
            _Dbcontext.Users.Add(entity);
        }

        public void Delete(User entity)
        {
            _Dbcontext.Remove(entity);
        }

        public User FindById(int Id)
        {
            return _Dbcontext.Users.Where(x => x.UserID == Id).FirstOrDefault();
        }

        public string Getusername()
        {
            return "Tesing UserName";
        }

        public IEnumerable<User> List()
        {
            return _Dbcontext.Users;
        }

        public void Update(User entity)
        {
            _Dbcontext.Entry(entity).State = EntityState.Modified;
            _Dbcontext.SaveChanges();
        }

        //public void AddUser(User user)
        //{
        //    _Dbcontext.Users.Add(user);
        //}

        //public bool DeleteUser(int userId)
        //{
        //    var removed = false;
        //    User user = GetUser(userId);

        //    if (user != null)
        //    {
        //        _Dbcontext.Users.Remove(user);
        //        removed = true;
        //    }
        //    return removed;
        //}

        //public User GetUser(int Id)
        //{
        //    return _Dbcontext.Users.Where(u => u.UserID == Id).FirstOrDefault();
        //}

        //public IEnumerable<User> GetUsers()
        //{
        //    return _Dbcontext.Users;
        //}
    }
}
