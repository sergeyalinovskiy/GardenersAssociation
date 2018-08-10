namespace SA.GA.DataAccess.Repository
{
    #region Usings
    using SA.GA.Common.Models;
    using System.Collections.Generic;
    #endregion
    public interface IHistoryRepository
    {
        void Create(History item);
        void Delete(int id);
        void Update(History item);
        History GetById(int id);
        IEnumerable<History> GetAll();
    }
}