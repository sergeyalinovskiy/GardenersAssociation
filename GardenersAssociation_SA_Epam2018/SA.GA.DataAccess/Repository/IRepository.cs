using System;
using System.Collections.Generic;
using System.Text;

namespace SA.GA.DataAccess.Repository
{
    public interface IRepository<T> where T : class
    {
        void Create(T item);

        void Delete(int id);

        void Update(T item);

        IReadOnlyCollection<T> GetAll();

        T GetById(int id);
    }
}