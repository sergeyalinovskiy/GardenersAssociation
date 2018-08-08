using SA.GA.Common.Models;
using SA.GA.DataAccess.Context.Implementation;
using System.Collections.Generic;

namespace SA.GA.DataAccess.Repository.Implementation
{
    public class ElectricityRepository : IElectricityRepository
    {
        private readonly AppContext2 _context;

        public ElectricityRepository(AppContext2 appContext2)
        {
            _context = appContext2;
        }

        public void Create(Electricity item)
        {
            _context.Electricitys.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Electricity item = _context.Electricitys.Find(id);
            if (item != null)
            {
                _context.Electricitys.Remove(item);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Electricity> GetAll()
        {
            var list = _context.Electricitys;
            return list;
        }

        public Electricity GetById(int id)
        {
            var item = _context.Electricitys.Find(id);
            return item;
        }

        public void Update(Electricity item)
        {
            _context.Electricitys.Update(item);
            _context.SaveChanges();
        }
    }
}
