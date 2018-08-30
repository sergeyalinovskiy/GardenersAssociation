namespace SA.GA.Business.Services
{
    #region Usings
        using SA.GA.Common.Models;
        using System.Collections.Generic;
    #endregion

    public interface ISummaryService
    {
        IEnumerable<Summary> GetSummaryList();
    }
}