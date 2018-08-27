﻿using SA.GA.Common.Models;
using System.Collections.Generic;

namespace SA.GA.Business.Services
{
    public interface ISummaryService
    {
        IEnumerable<Summary> GetSummaryList();
        //void AddCounterValues(Summary counter);
    }
}