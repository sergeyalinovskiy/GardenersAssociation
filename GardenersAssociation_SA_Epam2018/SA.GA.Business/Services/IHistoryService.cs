using SA.GA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.GA.Business.Services
{
    public interface IHistoryService
    {
        History GetHistoryById(int id);

        void DeleteHistoryByHistoryId(int id);

        IEnumerable<History> GetHistorysList();

        void SaveHistory(History model);

        void UpdateHistoryt(History model);
    }
}
