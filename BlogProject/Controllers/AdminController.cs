using DataAcsessLayerCore.Conreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogProject.Controllers
{
    [AllowAnonymous]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        public PartialViewResult AdminSidebarPartial()
        {
           
            return PartialView();
        }
    }
}
