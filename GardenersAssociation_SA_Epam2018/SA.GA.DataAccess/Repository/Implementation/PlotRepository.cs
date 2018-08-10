﻿namespace SA.GA.DataAccess.Repository.Implementation
{
    #region Usings
    using SA.GA.Common.Models;
    using SA.GA.DataAccess.Context.Implementation;
    using System.Collections.Generic;
    #endregion
    public class PlotRepository :IPlotRepository
    {
        private readonly AppContext2 _context;

        public PlotRepository(AppContext2 appContext2)
        {
            _context = appContext2;
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