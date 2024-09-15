using Microsoft.AspNetCore.Mvc;

namespace ZayEcommers.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
