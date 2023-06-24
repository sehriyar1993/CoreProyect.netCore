using Microsoft.AspNetCore.Mvc;

namespace CoreProyekt.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
