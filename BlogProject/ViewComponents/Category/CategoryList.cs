using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.ViewComponents.Category
{
	public class CategoryList : ViewComponent
	{
		CategoryManager cm = new CategoryManager(new EFCategoryRepository());
		public IViewComponentResult Invoke()
		{
			var values = cm.TGetList();
			return View(values);
		}
	}
	
}
