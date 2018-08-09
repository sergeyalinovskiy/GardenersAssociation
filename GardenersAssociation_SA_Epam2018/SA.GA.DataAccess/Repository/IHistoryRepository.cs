using SA.GA.Common.Models;
using System.Collections.Generic;

namespace SA.GA.DataAccess.Repository
{
    public interface IHistoryRepository
    {
        void Create(History item);
        void Delete(int id);
        void Update(History item);
        History GetById(int id);
        IEnumerable<History> GetAll();
    }
}
