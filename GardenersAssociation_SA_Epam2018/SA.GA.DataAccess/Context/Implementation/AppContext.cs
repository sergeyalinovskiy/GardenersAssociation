using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SA.GA.DataAccess.Context.Implementation
{
    public class AppContext<T> : DbContext, IDbContext<T> where T : class
    {
        public AppContext() 
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }



        private DbSet<T> EntityTable;

        public bool Create(T item)
        {
            Entry(item).State = EntityState.Added;
            SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var item = EntityTable.Find(id);
            Entry(item).State = EntityState.Deleted;
            SaveChanges();
            return true;
        }

        public ICollection<T> GetAll()
        {
            var list = EntityTable.ToList();
            return list;
        }

        public T GetById(int id)
        {
            var item = this.EntityTable.Find(id);
            return item;
        }

        public bool Update(T item)
        {
            Entry(item).State = EntityState.Modified;
            this.SaveChanges();

            return true;
        }
    }
}