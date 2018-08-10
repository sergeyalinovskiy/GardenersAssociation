namespace SA.GA.DataAccess.Repository
{
    #region Usings
    using SA.GA.Common.Models;
    using System.Collections.Generic;
    #endregion
    public interface IPlotRepository
    {
        void Create(Plot item);
        void Delete(int id);
        void Update(Plot item);
        Plot GetById(int id);
        IEnumerable<Plot> GetAll();
    }
}