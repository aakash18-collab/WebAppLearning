using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcStudent.Controllers
{
    public class HelloWorldController : Controller
    {
        ////This is default method the controller will be calling
        //public string Index()
        //{
        //    return "Hello World";
        //}
        public IActionResult Index()
        {
            return View();
        }

        //this welcome method should be called manually by us in URL

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello" +" "+ name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
      
    }
}
