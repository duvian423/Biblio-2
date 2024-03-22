using Microsoft.AspNetCore.Mvc;
    namespace mvc.controllers{
    
        public class UsuariosController : Controller{
            public IActionResult Index(){
                return View();
            }

            public IActionResult Create(){
                return View();
            }

            public IActionResult Delete(){
                return View();
            }
        }
    }