using SA.GA.Common.Models;
using SA.GA.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SA.GA.Business.Services.Implementation
{
    public class SummaryService : ISummaryService
    {
        private readonly IUserRepository _userRepository;
        private readonly IElectricityRepository _electricityRepository;
        private readonly IPlotRepository _plotRepository;
        private readonly IHistoryRepository _historyRepository;

        public SummaryService(IUserRepository userRepository, 
            IElectricityRepository electricityRepository, IPlotRepository plotRepository,
            IHistoryRepository historyRepository)
        {
            if (electricityRepository == null)
            {
                throw new NullReferenceException();
            }
            if (userRepository == null)
            {
                throw new NullReferenceException();
            }
            if (plotRepository == null)
            {
                throw new NullReferenceException();
            }
            if (historyRepository == null)
            {
                throw new NullReferenceException();
            }
            _historyRepository = historyRepository;
            _plotRepository = plotRepository;
            _electricityRepository = electricityRepository;
            _userRepository = userRepository;
        }

        public IEnumerable<Summary> GetSummaryList()
        {
            _userRepository.GetAll().Select(m => m.Id);
            List<Summary> sammaryResult = new List<Summary>();

            foreach (int i in _userRepository.GetAll().Select(m => m.Id))
            {
                sammaryResult.Add(MapToSammary(i));
            }
            return this.AddSummValue(sammaryResult);
        }

        private List<Summary> AddSummValue(List<Summary> models)
        {
            Summary fullSummory = new Summary();

            foreach(Summary s in models)
            {
                fullSummory.PreviousTestimony += s.PreviousTestimony;
                fullSummory.RecentTestimony += s.RecentTestimony;
                fullSummory.Consumption += s.Consumption;
                fullSummory.NecessaryToPay += s.NecessaryToPay;
            }
            //fullSummory.UserId = 10000;
            models.Add(fullSummory);
            return models;
        }

        private Summary MapToSammary(int userId)
        {
            Summary resultSummary = new Summary();
            foreach(Electricity e in GetUserElectricities(userId))
            {
                resultSummary.PreviousTestimony += e.PreviousTestimony;
                resultSummary.RecentTestimony += e.RecentTestimony;
                resultSummary.Consumption += e.RecentTestimony - e.PreviousTestimony;
                resultSummary.NecessaryToPay += e.NecessaryToPlay;
            }
            resultSummary.UserId = userId;
            return resultSummary;
        }

        private IEnumerable<Electricity> GetUserElectricities(int userId)
        {
            List<Electricity> userElectricities = new List<Electricity>();
            foreach(Plot plot in this.GetUserPlots(userId))
            {
                userElectricities.Add(GetPlotElectricity(plot.Id));
            }
            return userElectricities;
        }

        private IEnumerable<Plot> GetUserPlots(int id)
        {
            IEnumerable<History> historys;
            historys = _historyRepository.GetAll();
            int[] plotsId = historys.Where(m => m.UserId == id).Select(m => m.PlotId).ToArray();
            List<Plot> plots = new List<Plot>();

            foreach (int i in plotsId)
            {
                plots.Add(_plotRepository.GetById(i));
            }
            return plots;
        }

        private Electricity GetPlotElectricity(int id)
        {
            int electricityId = _plotRepository.GetAll().Where(m => m.Id == id).Select(m => m.ElectricityId).Single();
            Electricity electricity = _electricityRepository.GetById(electricityId);          
            return electricity;
        }
    }
}
