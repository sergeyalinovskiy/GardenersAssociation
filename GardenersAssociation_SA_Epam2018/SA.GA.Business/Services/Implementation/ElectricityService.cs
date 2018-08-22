namespace SA.GA.Business.Services.Implementation
{
    #region Usings
    using System;
    using System.Collections.Generic;
    using SA.GA.Common.Models;
    using SA.GA.DataAccess.Repository;
    using SA.GA.DataAccess.Repository.Implementation;
    #endregion
    public class ElectricityService : IElectricityService
    {
        private readonly IElectricityRepository _electricityRepository;
        private readonly IRateRepository _rateRepository;

        public ElectricityService(IElectricityRepository electricityRepository, IRateRepository rateRepository)
        {
            if (electricityRepository == null)
            {
                throw new NullReferenceException();
            }
            if (rateRepository == null)
            {
                throw new NullReferenceException();
            }
            _rateRepository = rateRepository;
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
           
            _electricityRepository.Create(CalculateNecessaryToPay(model));
        }

        private Electricity CalculateNecessaryToPay(Electricity model)
        {
            Rate rateModel =_rateRepository.GetById(model.RateId);
            double rateValue = rateModel.Value;
            model.NecessaryToPlay = (model.RecentTestimony - model.PreviousTestimony) * model.Losses * model.BankCollections /** rateValue*/;
            return model;
        }

        public void UpdateElectricity(Electricity model)
        {
            if (model == null)
            {
                throw new NullReferenceException();
            }
            _electricityRepository.Update(CalculateNecessaryToPay(model));
        }

        public IEnumerable<Rate> ShowRateInfo(int id)
        {
            int ElectricityRateId =_electricityRepository.GetById(id).RateId;
            Rate rate = _rateRepository.GetById(ElectricityRateId);
            List<Rate> rates = new List<Rate>();
            rates.Add(rate);
            return rates;
        }

    }
}
