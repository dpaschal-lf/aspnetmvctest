using Microsoft.AspNetCore.Mvc;

namespace SampleMVCApps.Controllers{
    public class HelloWorldController:Controller{
        public IActionResult Index(){
            ViewData["Message"]="Hello, this is my view";
            return View();
        }
        public IActionResult Welcome(){
            ViewData["Message"]="Hello, welcome to the HelloWorld Application";
            return View();
        }
    }
}