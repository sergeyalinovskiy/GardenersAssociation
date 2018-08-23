using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SA.GA.Business.Services;
using SA.GA.Common;
using SA.GA.Common.Models;

namespace SA.GA.WebApplication.Controllers
{
    [Route("api/summary")]
    public class SummaryController : Controller
    {
        private readonly ISummaryService _summaryService;

        public SummaryController(ISummaryService summaryService)
        {
            _summaryService = summaryService;
        }

        [HttpGet]
        public IEnumerable<Summary> Get()
        {
            return _summaryService.GetSummaryList();
        }

    }
}