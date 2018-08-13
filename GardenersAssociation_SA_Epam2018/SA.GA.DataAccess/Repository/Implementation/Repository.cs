using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SA.GA.DataAccess.Repository.Implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;

        private DbSet<T> _table;

        public Repository(DbContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }
        
        public void Create(T item)
        {  
            _table.Add(item);
            SaveChanges();
        }

        public void Delete(int id)
        {
            var item = _table.Find(id);
            _table.Remove(item);
            SaveChanges();
        }

        public IReadOnlyCollection<T> FindBy(Func<T, bool> predicate)
        {
            IReadOnlyCollection<T> list = null;
            try
            {
                list = _table.AsNoTracking().Where(predicate).ToList();
                return list;
            }
            catch (Exception)
            {
                return list;
            }
        }

        public IReadOnlyCollection<T> GetAll()
        {
            IReadOnlyCollection<T> list = null;
            try
            {
                list = _table.AsNoTracking().ToList();
                return list;
            }
            catch (Exception)
            {                
                return list;
            }
        }

        public T GetById(int id)
        {
            T item = null;
            try
            {
                item = _table.Find(id);
                return item;
            }
            catch (Exception)
            {
                return item;
            }
        }

        public void Update(T item)
        {   
            _context.Entry(item).State = EntityState.Modified;
            SaveChanges();
        }

        private void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}