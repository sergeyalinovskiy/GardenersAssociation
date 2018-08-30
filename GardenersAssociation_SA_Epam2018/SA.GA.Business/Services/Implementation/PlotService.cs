namespace SA.GA.Business.Services.Implementation
{
    #region Usings
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using SA.GA.Common.Models;
    using SA.GA.DataAccess.Repository;
    #endregion
    public class PlotService : IPlotService
    {
        private readonly IPlotRepository _plotRepository;
        private readonly IElectricityRepository _electricityRepository;

        public PlotService(IPlotRepository plotRepository, IElectricityRepository electricityRepository)
        {
            if (electricityRepository == null)
            {
                throw new NullReferenceException();
            }
            if (plotRepository == null)
            {
               throw new NullReferenceException();
            }
            _electricityRepository = electricityRepository;
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

        public IEnumerable<Electricity> GetPlotElectricity(int id)
        {
            int electricityId = _plotRepository.GetAll().Where(m => m.Id == id).Select(m => m.ElectricityId).Single();
            List<Electricity> resultElectricities= new List<Electricity>();
            Electricity electricity = _electricityRepository.GetById(electricityId);
            resultElectricities.Add(electricity);
            return resultElectricities;
        }
    }
}