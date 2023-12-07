using Microsoft.AspNetCore.Mvc;
using SQLConnection.DAL;
using SQLConnection.Models;

namespace SQLConnection.Controllers
{
    public class HomeController:Controller
    {
        readonly ProductDbContext _context;
        public HomeController(ProductDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Movie> model = _context.Movies.ToList();
            return View(model);
        }
    }
}
