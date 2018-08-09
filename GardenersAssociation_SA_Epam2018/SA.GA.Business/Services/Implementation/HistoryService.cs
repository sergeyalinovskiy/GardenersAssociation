﻿using System;
using System.Collections.Generic;
using System.Text;
using SA.GA.Common.Models;
using SA.GA.DataAccess.Repository;

namespace SA.GA.Business.Services.Implementation
{
    public class HistoryService : IHistoryService
    {
        private readonly IHistoryRepository _historyRepository;

        public HistoryService(IHistoryRepository historyRepository)
        {
            if (historyRepository == null)
            {
                throw new NullReferenceException();
            }
            _historyRepository = historyRepository;
        }

        public void DeleteHistoryByHistoryId(int id)
        {
            if (id < 1)
            {
                throw new Exception();
            }
            _historyRepository.Delete(id);
        }

        public History GetHistoryById(int id)
        {
            if (id < 1)
            {
                throw new Exception();
            }
            return _historyRepository.GetById(id);
        }

        public IEnumerable<History> GetHistorysList()
        {
            return _historyRepository.GetAll();
        }

        public void SaveHistory(History model)
        {
            if (model == null)
            {
                throw new NullReferenceException();
            }
            _historyRepository.Create(model);
        }

        public void UpdateHistoryt(History model)
        {
            if (model == null)
            {
                throw new NullReferenceException();
            }
            _historyRepository.Update(model);
        }
    }
}