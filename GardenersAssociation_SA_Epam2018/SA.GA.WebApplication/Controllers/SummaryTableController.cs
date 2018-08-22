using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SA.GA.Business.Services;

namespace SA.GA.WebApplication.Controllers
{
    [Route("api/summary")]
    public class SummaryTableController : Controller
    {
        private readonly IUserService _userService;
        private readonly IElectricityService _electricityService;
        public SummaryTableController(IUserService userService, IElectricityService electricityService)
        {
            _electricityService = electricityService;
            _userService = userService;
        }

    }
}