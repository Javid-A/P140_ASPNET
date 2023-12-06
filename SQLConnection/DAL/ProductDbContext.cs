using Microsoft.EntityFrameworkCore;
using SQLConnection.Models;

namespace SQLConnection.DAL
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> opt):base(opt)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
