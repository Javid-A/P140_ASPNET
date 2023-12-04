using Microsoft.AspNetCore.Mvc;

namespace P140_ASPNET.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {

            //some codes
            return View();
        }

        public IActionResult About()
        {
            //some codes
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }
    }
}
