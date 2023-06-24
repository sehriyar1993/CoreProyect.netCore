using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.ViewComponents.Blog
{
	public class BlogLast3 : ViewComponent
	{
		BlogManager bm = new BlogManager(new EFBlogRepository());
		public IViewComponentResult Invoke()
		{
			var values = bm.TGetLast3blog();
			return View(values);
		}
	
	}
}
