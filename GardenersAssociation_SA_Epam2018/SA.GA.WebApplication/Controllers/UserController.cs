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

    [Route("api/users")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IPlotService _plotService;

        public UserController( IUserService userService, IPlotService plotService)
        {
            _plotService = plotService;
            _userService = userService;
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            UserViewModel user = _userService.GetUsersList().FirstOrDefault(x => x.Id == id);
            if(user != null)
            {
                _userService.DeleteUserByUserId(id);
            }
            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                _userService.UpdateUser(user);
                return Ok(user);
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public IActionResult Post([FromBody]UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                _userService.SaveUser(user);
                return Ok(user);
            }
            return BadRequest(ModelState);
        }

        [HttpGet("{id}")]
        public UserViewModel Get(int id)
        {
            UserViewModel user = _userService.GetUserById(id);
            return user;
        }

        [HttpGet]
        public IEnumerable<UserViewModel> Get()
        {
            return _userService.GetUsersList();
        }

        [HttpGet("/getPlots/{id}")]
        public IEnumerable<PlotViewModel> GetPlots(int id)
        {
            IEnumerable<Plot> plots = _userService.GetUserPlots(id);
            IEnumerable<PlotViewModel> resultPlots= this.MapPlotToViewModel(plots);
            
            return resultPlots;
        }

        private PlotViewModel MapPlotToViewModel(Plot plot)
        {
            return new PlotViewModel()
            {
                Id=plot.Id,
                Area=plot.Area,
                ElectricityId=plot.ElectricityId,
                Privatized=plot.Privatized
            };
        }

        private IEnumerable<PlotViewModel> MapPlotToViewModel(IEnumerable<Plot> plots)
        {
            List<PlotViewModel> resultPlots = new List<PlotViewModel>();
            foreach(Plot p in plots)
            {
                resultPlots.Add(this.MapPlotToViewModel(p));
            }
            return resultPlots;
        }
    }
}