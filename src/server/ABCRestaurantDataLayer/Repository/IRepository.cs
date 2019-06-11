using System;
using System.Collections.Generic;
using System.Text;
using ABCRestaurant_Data.Entitys;

namespace ABCRestaurant_Data.Repository
{
    public interface IRepository <T> where T: IEntity
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(int Id);
    }
}
