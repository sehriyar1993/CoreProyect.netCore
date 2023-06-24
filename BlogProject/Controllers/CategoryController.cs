using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
	[AllowAnonymous]

	public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());
        public IActionResult Index()
        {
            var values = cm.TGetList();
            return View(values);
        }
    }
}
