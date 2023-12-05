using Microsoft.AspNetCore.Mvc;

namespace DataTransfer.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            //ViewBag.ProductCount = 20;
            //ViewData["ProductCount"] = 600;
            //TempData["data"] = "test";
            return View();
        }

        public IActionResult Register()
        {
            //some registration process
            //ViewBag.Verified = "Please verify your email account";
            TempData["Verified"] = "Please verify your email account";
            return RedirectToAction(nameof(Index));
        }
    }
}
