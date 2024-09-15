using Microsoft.AspNetCore.Mvc;

namespace ZayEcommers.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
