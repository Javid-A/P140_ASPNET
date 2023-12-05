using DataTransfer.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataTransfer.Controllers
{
    public class ProductController : Controller
    {
        private readonly List<Computer> _context;
        public ProductController()
        {
            _context = new List<Computer>
            {
                new Computer
                {
                    Id = 1,
                    Brand = "Lenovo",
                    Model = "ThinkPad gen 3th",
                    Ram = "16GB",
                    Memory = "256GB"
                },
                new Computer
                {
                    Id = 2,
                    Brand = "HP",
                    Model = "OMEN",
                    Ram = "16GB",
                    Memory = "512GB"
                },
                new Computer
                {
                    Id = 3,
                    Brand = "ASUS",
                    Model = "TUF Gaming",
                    Ram = "16GB",
                    Memory = "1TB"
                },
                new Computer
                {
                    Id = 4,
                    Brand = "MacBook Pro",
                    Model = "M3 Pro Max",
                    Ram = "24GB",
                    Memory = "1TB"
                },
                new Computer
                {
                    Id = 5,
                    Brand = "Kur",
                    Model = "Cayi",
                    Ram = "512MB",
                    Memory = "2GB"
                },
                new Computer
                {
                    Id = 6,
                    Brand = "Samsung",
                    Model = "FlexBook",
                    Ram = "16GB",
                    Memory = "512GB"
                }
            };
        }

        public IActionResult Index()
        {
            List<Computer> aksdaksdkas = _context;
            return View(aksdaksdkas);
        }
        public IActionResult Details(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            Computer comp = _context.FirstOrDefault(c => c.Id == id);
            if (comp is null) return NotFound();
            ViewBag.Data = id;
            return View(comp);
        }
    }
}
