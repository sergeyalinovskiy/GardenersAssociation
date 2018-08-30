namespace SA.GA.DataAccess.Repository.Implementation
{
    #region Usings
    using SA.GA.Common.Models;
    using System.Collections.Generic;
    #endregion
    public interface IRateRepository
    {
        void Create(Rate item);

        void Delete(int id);

        void Update(Rate item);

        Rate GetById(int id);

        IEnumerable<Rate> GetAll();
    }
}