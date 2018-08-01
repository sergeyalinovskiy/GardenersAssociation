using System.Collections.Generic;

namespace SA.GA.DataAccess.Context
{
    public interface IDbContext<T> where T: class
    {
        ICollection<T> GetAll();
        bool Create(T item);
        bool Update(T item);
        bool Delete(int id);
        T GetById(int id);
    }
}