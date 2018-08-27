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

    [Route("api/electricitys")]
    public class ElectricityController : Controller
    {
        private readonly IElectricityService _electricityService;
        private readonly IRateService _rateService;

        public ElectricityController(IElectricityService electricityService, IRateService rateService)
        {
            _electricityService = electricityService;
            _rateService = rateService;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Electricity electricity = _electricityService.GetElectricitysList().FirstOrDefault(x => x.Id == id);
            if (electricity != null)
            {
                _electricityService.DeleteElectricityByElectricityId(id);
            }
            return Ok(electricity);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Electricity electricity)
        {
            if (ModelState.IsValid)
            {
                _electricityService.UpdateElectricity(electricity);
                return Ok(electricity);
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Electricity electricity)
        {
            if (ModelState.IsValid)
            {
                _electricityService.SaveElectricity(electricity);
                return Ok(electricity);
            }
            return BadRequest(ModelState);
        }

        [HttpGet("{id}")]
        public Electricity Get(int id)
        {
            Electricity electricity = _electricityService.GetElectricityById(id);
            return electricity;
        }

        [HttpGet]
        public IEnumerable<ElectricityViewModel> Get()
        {
            return MapElectricityListToViewModel(_electricityService.GetElectricitysList());
        }

        [HttpGet("GetRateInfo/{id}")]
        public IEnumerable<RateViewModel> GetRateInfo(int id)
        {
            IEnumerable<RateViewModel> rates = this.MapRateListToViewModel(_electricityService.ShowRateInfo(id));
            return rates;
        }

        private RateViewModel MapRateToViewModel(Rate rate)
        {
            return new RateViewModel()
            {
                Id = rate.Id,
                Name = rate.Name,
                Value = rate.Value,
                From = rate.From,
                To = rate.To,
                
            };
        }

        private IEnumerable<RateViewModel> MapRateListToViewModel(IEnumerable<Rate> rates)
        {
            List<RateViewModel> resultPlots = new List<RateViewModel>();
            foreach (Rate r in rates)
            {
                resultPlots.Add(this.MapRateToViewModel(r));
            }
            return resultPlots;
        }

        private IEnumerable<ElectricityViewModel> MapElectricityListToViewModel(IEnumerable<Electricity> electricities)
        {
            List<ElectricityViewModel> resultElectricities = new List<ElectricityViewModel>();
            foreach (Electricity e in electricities)
            {
                resultElectricities.Add(this.MapElectricityToViewModel(e));
            }
            return resultElectricities;
        }

        private ElectricityViewModel MapElectricityToViewModel(Electricity e)
        {
            return new ElectricityViewModel()
            {
                Id = e.Id,
                BankCollections = e.BankCollections,
                Losses = e.Losses,
                NecessaryToPlay = e.NecessaryToPlay,
                Paid = e.Paid,
                Year = e.Year,
                Mounth = e.Mounth,
                PreviousTestimony = e.PreviousTestimony,
                RecentTestimony = e.RecentTestimony,
                RateId = e.RateId,
                RateName = _rateService.GetRatesList()
                                    .Where(m => m.Id == e.RateId)
                                    .Select(m => m.Name)
                                    .FirstOrDefault()

            };
        }
        private Electricity MapElectricityToBusinessModel(ElectricityViewModel e)
        {
            return new Electricity()
            {
                Id = e.Id,
                BankCollections = e.BankCollections,
                Losses = e.Losses,
                NecessaryToPlay = e.NecessaryToPlay,
                Paid = e.Paid,
                Year = e.Year,
                Mounth = e.Mounth,
                PreviousTestimony = e.PreviousTestimony,
                RecentTestimony = e.RecentTestimony,
                RateId = e.RateId
            };
        }

    }

    
}