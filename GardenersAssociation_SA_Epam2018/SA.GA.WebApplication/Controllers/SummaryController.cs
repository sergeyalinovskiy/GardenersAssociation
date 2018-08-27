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

        //[HttpPost]
        //public IActionResult Post([FromBody]Summary counter)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _summaryService.AddCounterValues(counter);
        //        return Ok(counter);
        //    }
        //    return BadRequest(ModelState);
        //}

        [HttpGet]
        public IEnumerable<Summary> Get()
        {
            return _summaryService.GetSummaryList();
        }

    }
}