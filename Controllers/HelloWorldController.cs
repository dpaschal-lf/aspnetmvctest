using Microsoft.AspNetCore.Mvc;

namespace SampleMVCApps.Controllers{
    public class HelloWorldController:Controller{
        public IActionResult Index(){
            ViewData["Message"]="Hello, this is my view";
        }
    }
}