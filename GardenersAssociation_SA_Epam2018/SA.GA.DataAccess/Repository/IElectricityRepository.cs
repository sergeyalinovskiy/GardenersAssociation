namespace SA.GA.DataAccess.Repository
{
    #region Usings
    using SA.GA.Common.Models;
    using System.Collections.Generic;
    #endregion
    public interface IElectricityRepository
    {
        void Create(Electricity item);
        void Delete(int id);
        void Update(Electricity item);
        Electricity GetById(int id);
        IEnumerable<Electricity> GetAll();
    }
}