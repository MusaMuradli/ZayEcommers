using Microsoft.AspNetCore.Mvc;

namespace ZayEcommers.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
