using SA.GA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.GA.Business.Services
{
    public interface IElectricityService
    {
        Electricity GetElectricityById(int id);

        void DeleteElectricityByElectricityId(int id);

        IEnumerable<Electricity> GetElectricitysList();

        void SaveElectricity(Electricity model);

        void UpdateElectricity(Electricity model);
    }
}
