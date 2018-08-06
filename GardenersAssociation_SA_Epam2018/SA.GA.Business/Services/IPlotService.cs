using SA.GA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.GA.Business.Services
{
    public interface IPlotService
    {
        Plot GetPlotById(int id);

        void DeletePlotByPlotId(int id);

        IEnumerable<Plot> GetPlotsList();

        void SavePlot(Plot model);

        void UpdatePlot(Plot model);
    }
}
