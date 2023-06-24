using BiznesslayerCore.Concreate;
using BiznesslayerCore.ValidationRule;
using DataAcsessLayerCore.EntityFrameWork;
using EntitylayerCore.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
	[AllowAnonymous]

	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EFWriterRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer writer)
		{
			WriterValidator validationRules = new WriterValidator();
			ValidationResult validationResult = validationRules.Validate(writer);
			if (validationResult.IsValid)
			{


				writer.WriterStatus = true;
				writer.WriterAbout = "test";
				wm.TAdd(writer);

				return RedirectToAction("Index", "Blog");
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
