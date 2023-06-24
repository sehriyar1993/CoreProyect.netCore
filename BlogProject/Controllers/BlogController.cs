using BiznesslayerCore.Abstract;
using BiznesslayerCore.Concreate;
using BiznesslayerCore.ValidationRule;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using EntitylayerCore.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace BlogProject.Controllers
{
	public class BlogController : Controller
	{
		BlogManager bm = new BlogManager(new EFBlogRepository());
        private readonly ICategoryServices _categoryServices;
        Context c= new Context();

		public BlogController(ICategoryServices categoryServices)
		{
			_categoryServices = categoryServices;
		}
        [AllowAnonymous]

        public IActionResult Index(int page = 1)
		{
			var values = bm.GetBlogAllCategory().ToPagedList(page,6);
			return View(values);
		}
        [AllowAnonymous]
		public IActionResult GetBlogByName(string searchString)
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
		[AllowAnonymous]

		public IActionResult BlogReadAll(int id)
        {
			ViewBag.i = id;	
            var values = bm.TGetBlogIdList(id);
            return View(values);
        }
		
		public IActionResult BloglistByWriter()
        {
            var user = User.Identity.Name;
            var id = c.Users.Where(x => x.UserName == user).Select(y => y.Id).FirstOrDefault();
            var values = bm.GetListWithCategoryByWriterBM(id);
            return View(values);
        }
	
		public IActionResult GetBlogByNameWriter(string searchString)
		{
			var user = User.Identity.Name;
			var id = c.Users.Where(x => x.UserName == user).Select(y => y.Id).FirstOrDefault();
			if (searchString != null)
				searchString = searchString.ToLower();
			ViewData["CurrentFilter"] = searchString;
			var values = from x in bm.GetListWithCategoryByWriterBM(id) select x;
			if (!string.IsNullOrEmpty(searchString))
			{
				values = values.Where(y => y.BlogTitle.ToLower().Contains(searchString));
			}
			return View(values.ToList());
		}
		[HttpGet]
	
		public IActionResult Add()
        {
			List<SelectListItem> values = (from x in _categoryServices.TGetList()
										   select new SelectListItem
										   {
											   Text = x.CategoryName,
											   Value = x.CategoryID.ToString()
										   }).ToList();
			ViewBag.v = values;
			
			return View();
        }
        [HttpPost]
	
		public IActionResult Add(Blog p)
        {
            BlogValidator validationRules = new BlogValidator();
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {
                var user = User.Identity.Name;
                var id = c.Users.Where(x => x.UserName == user).Select(y => y.Id).FirstOrDefault();
                p.AppUserId = id;
                p.WriterID = 1;
                p.BlogStatus = true;
                p.BlogDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                bm.TAdd(p);

                return RedirectToAction("BloglistByWriter", "Blog");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
	
		public IActionResult Delete(int id)
        {
            var values = bm.TGetByID(id);
            bm.TDelete(values);
            return RedirectToAction("BloglistByWriter", "Blog");
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

   //         p.BlogStatus = true;
			//p.BlogDate = DateTime.Parse(DateTime.Now.ToShortDateString());
   //         p.WriterID = 1; 
			bm.TUpdate(p);
            return RedirectToAction("BloglistByWriter", "Blog");
        }
    }
}
