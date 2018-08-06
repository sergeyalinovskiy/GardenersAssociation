using System;
using System.Collections.Generic;
using SA.GA.Common.Models;
using SA.GA.DataAccess.Repository;

namespace SA.GA.Business.Services.Implementation
{
    public class RateService : IRateService
    {
        private readonly IRepository<Rate> _rateRepository;

        public RateService(IRepository<Rate> rateRepository)
        {
            if (rateRepository == null)
            {
                throw new NullReferenceException();
            }
            _rateRepository = rateRepository;
        }
        public void DeleteRateByRateId(int id)
        {
            if (id < 1)
            {
                throw new Exception();
            }
            _rateRepository.Delete(id);
        }

        public Rate GetRateById(int id)
        {
            if (id < 1)
            {
                throw new Exception();
            }
            return _rateRepository.GetById(id);
        }

        public IEnumerable<Rate> GetRatesList()
        {
            return _rateRepository.GetAll();
        }

        public void SaveRate(Rate model)
        {
            if (model == null)
            {
                throw new NullReferenceException();
            }
            _rateRepository.Create(model);
        }

        public void UpdateRate(Rate model)
        {
            if (model == null)
            {
                throw new NullReferenceException();
            }
            _rateRepository.Update(model);
        }
    }
}
