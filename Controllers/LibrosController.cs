using Microsoft.AspNetCore.Mvc;
    namespace mvc.controllers{
    
        public class LibrosController : Controller{
            public IActionResult Index(){
                return View();
            }

                        public IActionResult Create(){
                return View();
            }

            public IActionResult Delete(){
                return View();
            }
            public IActionResult DetallesLibro(){
                return View();
            }
        }
    }