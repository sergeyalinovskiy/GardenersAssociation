namespace SA.GA.WebApplication.Controllers
{
    #region Usings
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using SA.GA.Business.Services;
    using SA.GA.Business.Services.Implementation;
    using SA.GA.Common.Models;
    using SA.GA.WebApplication.ViewModels;
    #endregion

    [Route("api/plot")]
    public class PlotController : Controller
    {
        private readonly IPlotService _plotService;
        private readonly IElectricityService _electricityService;
        private readonly IRateService _rateService;

        public PlotController(IPlotService plotService, IElectricityService electricityService, IRateService rateService)
        {
            _plotService = plotService;
            _electricityService = electricityService;
            _rateService = rateService;
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
        public IActionResult Put(int id, [FromBody]PlotViewModel plot)
        {
            if (ModelState.IsValid)
            {
                _plotService.UpdatePlot(MapPlotToBusinessModel(plot));
                return Ok(plot);
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public IActionResult Post([FromBody]PlotViewModel plot)
        {
            if (ModelState.IsValid)
            {
                _plotService.SavePlot(MapPlotToBusinessModel(plot));
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
        public IEnumerable<PlotViewModel> Get()
        {
            return MapListUserToViewModel(_plotService.GetPlotsList());
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
                RateId=electricity.RateId,
                RateName = _rateService.GetRatesList()
                                    .Where(m => m.Id == electricity.RateId)
                                    .Select(m => m.Name)
                                    .FirstOrDefault()

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

        private PlotViewModel MapPlotToViewModel(Plot plot)
        {
            return new PlotViewModel
            {
                Area=plot.Area,
                Id=plot.Id,
                ElectricityId=plot.ElectricityId,
                Privatized=plot.Privatized,
                ViewPrivatized=this.ChoiseChar(plot.Privatized)
            };
        }

        private Plot MapPlotToBusinessModel(PlotViewModel plot)
        {
            return new Plot
            {
                Area = plot.Area,
                Id = plot.Id,
                ElectricityId = plot.ElectricityId,
                Privatized = plot.Privatized
            };
        }

        private IEnumerable<PlotViewModel> MapListUserToViewModel(IEnumerable<Plot> plots)
        {
            List<PlotViewModel> resultList = new List<PlotViewModel>();
            foreach (Plot model in plots)
            {
                resultList.Add(MapPlotToViewModel(model));
            }
            return resultList;
        }

        private string ChoiseChar(bool value)
        {
            string result = "❌";
            if (value)
            {
                result = "✅";
            }
            else
            {
                result = "❌";
            }
            return result;
        }
    }
}