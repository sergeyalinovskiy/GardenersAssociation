using System;
using System.Collections.Generic;
using System.Text;
using SA.GA.Common.Models;
using SA.GA.DataAccess.Repository;

namespace SA.GA.Business.Services.Implementation
{
    public class PlotService : IPlotService
    {
        private readonly IRepository<Plot> _plotRepository;

        public PlotService(IRepository<Plot> plotRepository)
        {
            if (plotRepository == null)
            {
               throw new NullReferenceException();
            }
            _plotRepository = plotRepository;
        }

        public void DeletePlotByPlotId(int id)
        {
            if (id < 1)
            {
                throw new Exception();
            }
            _plotRepository.Delete(id);
        }

        public Plot GetPlotById(int id)
        {
            if (id < 1)
            {
                throw new Exception();
            }
            return _plotRepository.GetById(id);
        }

        public IEnumerable<Plot> GetPlotsList()
        {
            return _plotRepository.GetAll();
        }

        public void SavePlot(Plot model)
        {
            if (model == null)
            {
                throw new NullReferenceException();
            }
            _plotRepository.Create(model);
        }

        public void UpdatePlot(Plot model)
        {
            if (model == null)
            {
                throw new NullReferenceException();
            }
            _plotRepository.Update(model);
        }
    }
}
