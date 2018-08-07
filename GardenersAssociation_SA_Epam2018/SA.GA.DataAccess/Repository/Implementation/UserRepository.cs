using SA.GA.Common.Models;
using SA.GA.DataAccess.Context.Implementation;
using System;
using System.Collections.Generic;

namespace SA.GA.DataAccess.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly Context.Implementation.AppContext _context;

        public UserRepository(Context.Implementation.AppContext context)
        {
            if (context == null)
            {
                throw new NullReferenceException();
            }
            _context = context;
        }

        public void Create(User item)
        {
            _context.Users.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            User item = _context.Users.Find(id);
            if (item != null)
            {
                _context.Users.Remove(item);
                _context.SaveChanges();
            }
        }

        public IEnumerable<User> GetAll()
        {
            var list = _context.Users;
            return list;
        }

        public User GetById(int id)
        {
            var item = _context.Users.Find(id);
            return item;
        }

        public void Update(User item)
        {
            _context.Users.Update(item);
            _context.SaveChanges();
        }
    }
}
