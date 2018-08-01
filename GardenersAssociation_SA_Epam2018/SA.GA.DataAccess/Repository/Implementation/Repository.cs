using SA.GA.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.GA.DataAccess.Repository.Implementation
{
    public class Repository<T>: IRepository<T> where T : class
    {
        private readonly IDbContext<T> _context;

        public Repository(IDbContext<T> context)
        {
            if (context == null)
            {
                throw new ArgumentNullException();
            }
            _context = context;
        }

        public void Create(T item)
        {
            _context.Create(item);
        }

        public void Delete(int id)
        {
            _context.Delete(id);
        }

        public ICollection<T> GetAll()
        {
            var list = _context.GetAll();
            return list;
        }

        public T GetById(int id)
        {
            var item = _context.GetById(id);
            return item;
        }

        public void Update(T item)
        {
            _context.Update(item);
        }
    }
}
