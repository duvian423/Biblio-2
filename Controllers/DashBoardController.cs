using Microsoft.AspNetCore.Mvc;
    namespace mvc.controllers{
    
        public class DashboardController : Controller{
            public IActionResult Index(){
                return View();
            }
        }
    }
