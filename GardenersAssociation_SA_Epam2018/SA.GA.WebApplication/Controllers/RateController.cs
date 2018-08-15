namespace SA.GA.WebApplication.Controllers
{
    #region Usings
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using SA.GA.Common.Models;
    using SA.GA.Business.Services.Implementation;
    #endregion

    [Route("api/rates")]
    public class RateController : Controller
    {
        private readonly IRateService _rateService;

        public RateController(IRateService rateService)
        {
            _rateService = rateService;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Rate rate = _rateService.GetRatesList().FirstOrDefault(x => x.Id == id);
            if (rate != null)
            {
                _rateService.DeleteRateByRateId(id);
            }
            return Ok(rate);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Rate rate)
        {
            if (ModelState.IsValid)
            {
                _rateService.UpdateRate(rate);
                return Ok(rate);
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Rate rate)
        {
            if (ModelState.IsValid)
            {
                _rateService.SaveRate(rate);
                return Ok(rate);
            }
            return BadRequest(ModelState);
        }

        [HttpGet("{id}")]
        public Rate Get(int id)
        {
            Rate rate = _rateService.GetRateById(id);
            return rate;
        }

        [HttpGet]
        public IEnumerable<Rate> Get()
        {
            return _rateService.GetRatesList();
        }
    }
}