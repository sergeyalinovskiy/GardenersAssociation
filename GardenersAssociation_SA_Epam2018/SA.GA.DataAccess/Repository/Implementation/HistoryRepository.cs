using System;
using System.Collections.Generic;
using SA.GA.Common.Models;
using SA.GA.DataAccess.Context.Implementation;

namespace SA.GA.DataAccess.Repository.Implementation
{
    public class HistoryRepository : IHistoryRepository
    {
        AppContext2 _context;

        public HistoryRepository(AppContext2 appContext2)
        {
            _context = appContext2;
        }

        public void Create(History item)
        {
            _context.Historys.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            History item = _context.Historys.Find(id);
            if (item != null)
            {
                _context.Historys.Remove(item);
                _context.SaveChanges();
            }
        }

        public IEnumerable<History> GetAll()
        {
            var list = _context.Historys;
            return list;
        }

        public History GetById(int id)
        {
            var item = _context.Historys.Find(id);
            return item;
        }

        public void Update(History item)
        {
            _context.Historys.Update(item);
            _context.SaveChanges();
        }
    }
}
