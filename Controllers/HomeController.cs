using medicalApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace medicalApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DoctorDbContext doctorDbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DoctorDbContext doctorDbContext)
        {
            _logger = logger;
            this.doctorDbContext = doctorDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        
        }

        


    }
}
