using Microsoft.EntityFrameworkCore;
using TaskAspPraktikaTamp.Models;

namespace TaskAspPraktikaTamp.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Car> Cars { get; set; }

    }
}
