namespace SA.GA.Business.Services
{
    #region Usings
    using SA.GA.Common.Models;
    using System.Collections.Generic;
    #endregion
    public interface IPlotService
    {
        Plot GetPlotById(int id);

        void DeletePlotByPlotId(int id);

        IEnumerable<Plot> GetPlotsList();

        void SavePlot(Plot model);

        void UpdatePlot(Plot model);
    }
}