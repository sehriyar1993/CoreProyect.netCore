using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.ViewComponents.Comment
{
	public class CommentListByBlog:ViewComponent
	{
		CommentManager cm = new CommentManager(new EFCommentRepository());
		public IViewComponentResult Invoke()
		{
			var values = cm.TGetList(1);
			return View(values);
		}
	}
}
