using Microsoft.AspNetCore.Mvc;
    namespace mvc.controllers{
    
        public class landingController : Controller{
            public IActionResult Index(){
                return View();
            }
        }
    }