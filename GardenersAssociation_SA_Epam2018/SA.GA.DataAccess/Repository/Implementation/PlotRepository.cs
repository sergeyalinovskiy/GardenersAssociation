using SA.GA.Common.Models;
using SA.GA.DataAccess.Context.Implementation;
using System;
using System.Collections.Generic;

namespace SA.GA.DataAccess.Repository.Implementation
{
    public class PlotRepository :IPlotRepository
    {
        private readonly Context.Implementation.AppContext _context;

        public PlotRepository(Context.Implementation.AppContext context)
        {
            if (context == null)
            {
                throw new NullReferenceException();
            }
            _context = context;
        }

        public void Create(Plot item)
        {
            _context.Plots.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Plot item = _context.Plots.Find(id);
            if (item != null)
            {
                _context.Plots.Remove(item);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Plot> GetAll()
        {
            var list = _context.Plots;
            return list;
        }

        public Plot GetById(int id)
        {
            var item = _context.Plots.Find(id);
            return item;
        }

        public void Update(Plot item)
        {
            _context.Plots.Update(item);
            _context.SaveChanges();
        }
    }
}
