using Microsoft.EntityFrameworkCore;
using ZayEcommers.DAL.Entities;

namespace ZayEcommers.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            
        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Slider> slider { get; set; }

    }
}
