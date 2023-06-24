using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogProject.ViewComponents.Blog
{
	public class WriterlastBlog:ViewComponent
	{
		BlogManager bm = new BlogManager(new EFBlogRepository());
		Context c = new Context();
		public IViewComponentResult Invoke()
		{
            var user = User.Identity.Name;
            var id = c.Users.Where(x => x.UserName == user).Select(y => y.Id).FirstOrDefault();
            var values = bm.GetBlogAllCategoryByWriter(id);
			return View(values);
		}
	}
}
