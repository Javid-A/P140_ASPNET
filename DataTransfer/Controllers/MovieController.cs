using DataTransfer.Models;
using DataTransfer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DataTransfer.Controllers
{
    public class MovieController:Controller
    {
        readonly List<Movie> _context;
        readonly List<Category> _categories;
        public MovieController()
        {
            _context = new List<Movie>()
            {
                new Movie
                {
                    Id = 1,
                    Name = "Avatar",
                    Image = "",
                    Duration = 150,
                    IMDB = 8.2
                },
                new Movie
                {
                    Id = 2,
                    Name = "Kurtlar Vadisi Irak",
                    Image = "",
                    Duration = 180,
                    IMDB = 13
                },
                new Movie
                {
                    Id = 3,
                    Name = "Defending Jacob",
                    Image = "",
                    Duration = 130,
                    IMDB = 7.9
                },
                new Movie
                {
                    Id = 4,
                    Name = "Oppenheimer",
                    Image = "",
                    Duration = 180,
                    IMDB = 8.6
                },
                new Movie
                {
                    Id = 5,
                    Name = "Inception",
                    Image = "",
                    Duration = 160,
                    IMDB = 8.7
                },
            };
            _categories = new List<Category>()
            {
                new Category
                {
                    Id = 1,
                    Name = "Sci-Fi"
                },
                new Category
                {
                    Id = 2,
                    Name = "Drama"
                },
                new Category
                {
                    Id = 3,
                    Name = "Comedy"
                },new Category
                {
                    Id = 4,
                    Name = "Horror"
                },new Category
                {
                    Id = 5,
                    Name = "Romantic"
                }
            };
        }
        public IActionResult Index()
        {
            MovieVM model = new MovieVM
            {
                Movies = _context,
                Categories = _categories
            };
            return View(model);
        }
        public IActionResult Details(int Id)
        {
            if (Id == 0) return BadRequest();
            Movie movie = _context.FirstOrDefault(x=>x.Id == Id);
            if (movie is null) return NotFound();
            return View(movie);
        }
    }
}
