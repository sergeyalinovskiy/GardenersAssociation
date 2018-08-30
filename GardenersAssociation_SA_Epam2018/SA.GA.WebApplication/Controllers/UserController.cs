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
            User user = _userService.GetUsersList().FirstOrDefault(x => x.Id == id);
            if(user != null)
            {
                _userService.DeleteUserByUserId(id);
            }
            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]User user)
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
                _userService.SaveUser(MapUserToBusinessModel(user));
                return Ok(user);
            }
            return BadRequest(ModelState);
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            User user = _userService.GetUserById(id);
            return user;
        }

        [HttpGet]
        public IEnumerable<UserViewModel> Get()
        {
            return MapListUserToViewModel(_userService.GetUsersList());
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
                Privatized=plot.Privatized,
                ViewPrivatized=this.ChoiseChar(plot.Privatized)
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


        [HttpGet("/getNotActiveUsers")]
        public IEnumerable<UserViewModel> GetNotActiveUsers()
        {
            return MapListUserToViewModel(_userService.GetUsersList().Where(m=>m.Status==false));
        }

        [HttpGet("/getActiveUsers")]
        public IEnumerable<UserViewModel> GetActiveUsers()
        {
            return MapListUserToViewModel(_userService.GetUsersList().Where(m=>m.Status==true));
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

        private UserViewModel MapUserToViewModel(User model)
        {
            return new UserViewModel
            {
                Id = model.Id,
                FirstName=model.FirstName,
                LastName=model.LastName,
                AdditionalInformation=model.AdditionalInformation,
                Address=model.Address,
                MiddleName=model.MiddleName,
                Phone=model.Phone,
                ViewSuppliedElectricity= ChoiseChar(model.SuppliedElectricity),
                ViewStatus= ChoiseChar(model.Status),
                Status = model.Status,
                SuppliedElectricity = model.SuppliedElectricity
            };
        }

        private User MapUserToBusinessModel(UserViewModel model)
        {
            return new User
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                AdditionalInformation = model.AdditionalInformation,
                Address = model.Address,
                MiddleName = model.MiddleName,
                Phone = model.Phone,
                Status=model.Status,
                SuppliedElectricity=model.SuppliedElectricity
            };
        }

        private IEnumerable<UserViewModel> MapListUserToViewModel(IEnumerable<User> users)
        {
            List<UserViewModel> resultList = new List<UserViewModel>();
            foreach(User model in users)
            {
                resultList.Add(MapUserToViewModel(model));
            }
            return resultList;

        }

    }
}