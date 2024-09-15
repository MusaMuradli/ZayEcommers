using Microsoft.AspNetCore.Mvc;

namespace ZayEcommers.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        
    }
}