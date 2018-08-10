namespace SA.GA.Business.Services.Implementation
{
    #region Usings
    using SA.GA.Common.Models;
    using System.Collections.Generic;
    #endregion
    public interface IRateService
    {
        Rate GetRateById(int id);

        void DeleteRateByRateId(int id);

        IEnumerable<Rate> GetRatesList();

        void SaveRate(Rate model);

        void UpdateRate(Rate model);
    }
}