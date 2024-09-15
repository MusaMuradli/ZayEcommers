using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZayEcommers.DAL;

namespace ZayEcommers.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ShopController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _dbContext.products.Take(4).Include(p=>p.Category).ToListAsync();
            return View(products);
        }
        public IActionResult loadProducts()
        {
            var products =  _dbContext.products.Include(p=>p.Category).Take(4).ToList();
            return PartialView("_ProductPartial",products);
        }

    }
}
