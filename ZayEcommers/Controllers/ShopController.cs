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
        public IActionResult LoadProducts(int page = 1)
        {
            int pageSize = 4;
            var products =  _dbContext.products.Include(p=>p.Category).Skip((page-1)*pageSize).Take(pageSize).ToList();
            if (products.Count == 0)
            {
                return new EmptyResult();
            }
            return PartialView("_ProductPartial",products);
        }

    }
}
