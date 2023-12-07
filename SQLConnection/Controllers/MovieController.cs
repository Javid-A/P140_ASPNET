using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLConnection.DAL;
using SQLConnection.Models;

namespace SQLConnection.Controllers
{
    public class MovieController:Controller
    {
        readonly ProductDbContext _context;

        public MovieController(ProductDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            if (id == 0) return BadRequest();
            Movie movie = _context.Movies.AsNoTracking().Include(m=>m.MovieHeader).FirstOrDefault(m=>m.Id == id)!;
            if (movie is null) return NotFound();
            return View(movie);
        }
    }
}
