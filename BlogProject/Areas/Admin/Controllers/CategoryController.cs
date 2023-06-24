using BiznesslayerCore.Concreate;
using BiznesslayerCore.ValidationRule;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using EntitylayerCore.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using X.PagedList;

namespace BlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles = "Admin")]

	public class CategoryController : Controller
    {
        CategoryManager manager = new CategoryManager(new EFCategoryRepository());
        Context c = new Context();
        [Route("Admin/[controller]/[action]")]
        public IActionResult Index(int page=1)
        {
            var values = manager.TGetList().ToPagedList(page, 10);
            return View(values);
        }
        public IActionResult CateqoriyaWithBlog()
        {
            return View();
        }
        [Route("Admin/[controller]/[action]")]

        [HttpGet]
        public IActionResult CateqoriyaAdd()
        {
            return View();
        }
        [Route("Admin/[controller]/[action]")]

        [HttpPost]
        public IActionResult CateqoriyaAdd(Category p)
        {
            CategoriValidator validationRules = new CategoriValidator();
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {
        
                p.CategoryStatus = true;
                manager.TAdd(p);

                return RedirectToAction("Index", "Category");
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

        public IActionResult ChangeToTrue(int id)
        {
            manager.TChangeToTrue(id);
            return RedirectToAction("Index", "Category", new { area = "Admin" });
        }

        public IActionResult ChangeToFalse(int id)
        {
            manager.TChangeToFalse(id);
            return RedirectToAction("Index", "Category", new { area = "Admin" });
        }
        [Route("Admin/[controller]/[action]/{id}")]

        [HttpGet]
        public IActionResult CateqoryUpdate(int id)
        {
            var values = manager.TGetByID(id);

            return View(values);
        }
        [Route("Admin/[controller]/[action]/{id}")]
        [HttpPost]
        public IActionResult CateqoryUpdate(Category p)
        {
            CategoriValidator validationRules = new CategoriValidator();
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {

                manager.TUpdate(p);

                return RedirectToAction("Index", "Category");
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
    }
}
