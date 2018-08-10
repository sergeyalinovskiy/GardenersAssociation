namespace SA.GA.Business.Services.Implementation
{
    #region Usings
    using System;
    using System.Collections.Generic;
    using SA.GA.Common.Models;
    using SA.GA.DataAccess.Repository;
    #endregion
    public class ElectricityService : IElectricityService
    {
        private readonly IElectricityRepository _electricityRepository;

        public ElectricityService(IElectricityRepository electricityRepository)
        {
            if (electricityRepository == null)
            {
                throw new NullReferenceException();
            }
            _electricityRepository = electricityRepository;
        }
        public void DeleteElectricityByElectricityId(int id)
        {
            if (id < 1)
            {
                throw new Exception();
            }
            _electricityRepository.Delete(id);
        }

        public Electricity GetElectricityById(int id)
        {
            if (id < 1)
            {
                throw new Exception();
            }
            return _electricityRepository.GetById(id);
        }

        public IEnumerable<Electricity> GetElectricitysList()
        {
            return _electricityRepository.GetAll();
        }

        public void SaveElectricity(Electricity model)
        {
            if (model == null)
            {
                throw new NullReferenceException();
            }
            _electricityRepository.Create(model);
        }

        public void UpdateElectricity(Electricity model)
        {
            if (model == null)
            {
                throw new NullReferenceException();
            }
            _electricityRepository.Update(model);
        }
    }
}
