using System;
using System.Collections.Generic;
using System.Text;
using SA.GA.Common.Models;
using SA.GA.DataAccess.Repository;

namespace SA.GA.Business.Services.Implementation
{
    public class ElectricityService : IElectricityService
    {
        private readonly IRepository<Electricity> _electricityRepository;

        public ElectricityService(IRepository<Electricity> electricityRepository)
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
