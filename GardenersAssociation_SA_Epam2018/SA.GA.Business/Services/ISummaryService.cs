using SA.GA.Common;
using System.Collections.Generic;

namespace SA.GA.Business.Services
{
    public interface ISummaryService
    {
        IEnumerable<Summary> GetSummaryList();
        Summary SummaryValues();
    }
}