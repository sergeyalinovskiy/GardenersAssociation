using SA.GA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.GA.Business.Services.Implementation
{
    public interface IRateService
    {
        Rate GetRateById(int id);

        void DeleteRateByRateId(int id);

        IEnumerable<Rate> GetRatesList();

        void SaveRate(Rate model);

        void UpdateRate(Rate model);
    }
}
