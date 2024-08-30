using medicalApp.Models;
using medicalApp.newModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace medicalApp.Controllers
{
    public class UserController : Controller
    {
        private readonly DoctorDbContext doctorDbContext;
        private readonly ILogger<HomeController> _logger;

        public UserController(ILogger<HomeController> logger, DoctorDbContext doctorDbContext) {
            _logger = logger;
            this.doctorDbContext = doctorDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoginUser(string errormessage) {
            ViewData["errormsg"] = errormessage;
            return View();
        }

        [HttpPost]
        public IActionResult LoginUser(Login log) {
            if (ModelState.IsValid)
            {
                User user = (from tempUser in doctorDbContext.Users
                             where tempUser.Email == log.Email
                             select tempUser).FirstOrDefault();

                if (user == null) {
                    return RedirectToAction("LoginUser", "User", new { errormessage = "Email Not Found" });
                
                }
            }
            return RedirectToAction("LoginUser", "User",new {errormessage = "Not found" });

        }


        [HttpPost]
        public IActionResult createUser(User user)
        {
            if (ModelState.IsValid) {  
                doctorDbContext.Add(user);
                doctorDbContext.SaveChanges();
                ViewData["userId"] = user.UserId;
            }
            
           

            return RedirectToAction("index");
        }
    }
}
