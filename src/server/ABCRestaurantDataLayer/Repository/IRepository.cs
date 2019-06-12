using ABCRestaurant_Data.Entitys;
using System.Collections.Generic;

namespace ABCRestaurant_Data.Repository
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> List();
        T FindById(int Id);
    }
}
