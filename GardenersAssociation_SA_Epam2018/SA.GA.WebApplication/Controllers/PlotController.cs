using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SA.GA.Business.Services;
using SA.GA.Common.Models;

namespace SA.GA.WebApplication.Controllers
{
    [Route("api/plots")]
    public class PlotController : Controller
    {
        private readonly IPlotService _plotService;

        public PlotController(IPlotService plotService)
        {
            _plotService = plotService;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Plot plot = _plotService.GetPlotsList().FirstOrDefault(x => x.Id == id);
            if (plot != null)
            {
                _plotService.DeletePlotByPlotId(id);
            }
            return Ok(plot);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Plot plot)
        {
            if (ModelState.IsValid)
            {
                _plotService.UpdatePlot(plot);
                return Ok(plot);
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Plot plot)
        {
            if (ModelState.IsValid)
            {
                _plotService.SavePlot(plot);
                return Ok(plot);
            }
            return BadRequest(ModelState);
        }

        [HttpGet("{id}")]
        public Plot Get(int id)
        {
            Plot plot = _plotService.GetPlotById(id);
            return plot;
        }

        [HttpGet]
        public IEnumerable<Plot> Get()
        {
            return _plotService.GetPlotsList();
        }
    }
}