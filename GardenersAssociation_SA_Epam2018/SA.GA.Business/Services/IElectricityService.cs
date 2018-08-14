namespace SA.GA.Business.Services
{
    #region Usings
    using SA.GA.Common.Models;
    using System.Collections.Generic;
    #endregion
    public interface IElectricityService
    {
        Electricity GetElectricityById(int id);

        void DeleteElectricityByElectricityId(int id);

        IEnumerable<Electricity> GetElectricitysList();

        void SaveElectricity(Electricity model);

        void UpdateElectricity(Electricity model);

        Rate ShowRateInfo(int id);
    }
}