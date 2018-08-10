namespace SA.GA.Business.Services
{
    #region Usings
    using SA.GA.Common.Models;
    using System.Collections.Generic;
    #endregion
    public interface IHistoryService
    {
        History GetHistoryById(int id);

        void DeleteHistoryByHistoryId(int id);

        IEnumerable<History> GetHistorysList();

        void SaveHistory(History model);

        void UpdateHistoryt(History model);
    }
}