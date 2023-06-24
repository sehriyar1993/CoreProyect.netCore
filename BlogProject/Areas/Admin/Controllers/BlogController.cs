using BiznesslayerCore.Abstract;
using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using EntitylayerCore.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles = "Admin")]

	public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        private readonly ICategoryServices _categoryServices;
        Context c = new Context();

        public BlogController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        public IActionResult Index()
        {
           
                var values = bm.GetBlogAllCategory();
                return View(values);
            
        }
        [Route("Admin/[controller]/[action]")]
        public IActionResult GetBlogByNameAdmin(string searchString)
        {
            if (searchString != null)
                searchString = searchString.ToLower();
            ViewData["CurrentFilter"] = searchString;
            var values = from x in bm.GetBlogAllCategory() select x;
            if (!string.IsNullOrEmpty(searchString))
            {
                values = values.Where(y => y.BlogTitle.ToLower().Contains(searchString));
            }
            return View(values.ToList());
        }

        public IActionResult Detail(int id)
        {
            ViewBag.idadmin = id;
            var values = bm.TGetBlogIdList(id);
            return View(values);
        }
        public IActionResult Delete(int id)
        {
            var values = bm.TGetByID(id);
            bm.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            List<SelectListItem> valuem = (from x in _categoryServices.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = valuem;
            var values = bm.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Update(Blog p)
        {

            bm.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
