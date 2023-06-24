using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using EntitylayerCore.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BlogProject.Controllers
{
	[AllowAnonymous]

	public class CommentController : Controller
	{
		Context context = new Context();
		CommentManager  cm = new CommentManager(new EFCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult PartialAddComment(Comment p)
		{
			p.CommentDate = DateTime.Parse(DateTime.Now.ToShortTimeString());
			p.CommentStatus = true;
			cm.TAdd(p);
			return RedirectToAction("Index", "Blog");
		}
		public PartialViewResult CommentListByBlog(int id)
		{
			var values = cm.TGetList(id);
			return PartialView(values);
		}
	}
}
