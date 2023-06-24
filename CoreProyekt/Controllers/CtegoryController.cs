using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace CoreProyekt.Controllers
{
    public class CtegoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());
        public IActionResult Index()
        {
            var values = cm.TGetList();
            return View(values);
        }
    }
}
