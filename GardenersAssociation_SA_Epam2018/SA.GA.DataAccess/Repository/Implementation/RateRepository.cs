using SA.GA.Common.Models;
using SA.GA.DataAccess.Context.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.GA.DataAccess.Repository.Implementation
{
    public class RateRepository : IRateRepository
    {
        private readonly AppContext2 _context;

        public RateRepository(AppContext2 context)
        {
            if (context == null)
            {
                throw new NullReferenceException();
            }
            _context = context;
        }

        public void Create(Rate item)
        {
            _context.Rates.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Rate item = _context.Rates.Find(id);
            if (item != null)
            {
                _context.Rates.Remove(item);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Rate> GetAll()
        {
            var list = _context.Rates;
            return list;
        }

        public Rate GetById(int id)
        {
            var item = _context.Rates.Find(id);
            return item;
        }

        public void Update(Rate item)
        {
            _context.Rates.Update(item);
            _context.SaveChanges();
        }
    }
}
