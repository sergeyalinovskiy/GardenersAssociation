using SA.GA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.GA.DataAccess.Repository
{
    public interface IPlotRepository
    {
        void Create(Plot item);
        void Delete(int id);
        void Update(Plot item);
        Plot GetById(int id);
        IEnumerable<Plot> GetAll();
    }
}
