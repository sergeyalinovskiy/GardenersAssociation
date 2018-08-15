namespace SA.GA.WebApplication.Controllers
{
    #region Usings
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using SA.GA.Business.Services;
    using SA.GA.Common.Models;
    using SA.GA.WebApplication.ViewModels;
    #endregion

    [Route("api/plot")]
    public class PlotController : Controller
    {
        private readonly IPlotService _plotService;
        private readonly IElectricityService _electricityService;

        public PlotController(IPlotService plotService, IElectricityService electricityService)
        {
            _plotService = plotService;
            _electricityService = electricityService;
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

        [HttpGet("/getPlotElectricity/{id}")]
        public IEnumerable<ElectricityViewModel> GetPlotElectricity(int id)
        {
            IEnumerable<Electricity> electricities = _plotService.GetPlotElectricity(id);
            IEnumerable<ElectricityViewModel> plotElectricities = this.MapElectricityListToViewModel(electricities);

            return plotElectricities;
        }

        private ElectricityViewModel MapElectricityToViewModel(Electricity electricity)
        {
            return new ElectricityViewModel()
            {
                Id = electricity.Id,
                Year=electricity.Year,
                Mounth=electricity.Mounth,
                BankCollections=electricity.BankCollections,
                Losses=electricity.Losses,
                Paid=electricity.Paid,
                NecessaryToPlay=electricity.NecessaryToPlay,
                PreviousTestimony=electricity.PreviousTestimony,
                RecentTestimony=electricity.RecentTestimony,
                RateId=electricity.RateId                
            };
        }

        private IEnumerable<ElectricityViewModel> MapElectricityListToViewModel(IEnumerable<Electricity> electricities)
        {
            List<ElectricityViewModel> resultElectricity = new List<ElectricityViewModel>();
            foreach (Electricity e in electricities)
            {
                resultElectricity.Add(this.MapElectricityToViewModel(e));
            }
            return resultElectricity;
        }
    }
}