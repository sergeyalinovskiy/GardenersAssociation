using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SA.GA.Common.Models;
using SA.GA.DataAccess.Repository;

namespace SA.GA.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<User> _repository;
        public HomeController(IRepository<User> repository)
        {
            if (repository != null)
            {
                _repository = repository;
            }
        }
        public IActionResult Index()
        {
        
            
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}