using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SA.GA.Business.Services;
using SA.GA.Common.Models;

namespace SA.GA.WebApplication.Controllers
{
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
        public IActionResult Post([FromBody]User user)
        {
            if (ModelState.IsValid)
            {
                _userService.SaveUser(user);
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
        public IEnumerable<User> Get()
        {
            return _userService.GetUsersList();
        }

       

    }
}