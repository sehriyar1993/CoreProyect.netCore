﻿using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogProject.ViewComponents
{
	public class CommentList: ViewComponent
	{
		CommentManager cm = new CommentManager(new EFCommentRepository());
		Context c = new Context();
		public IViewComponentResult Invoke(int id)
		{
			ViewBag.imagecomment = c.Blogs.Where(x => x.BlogId == id).Select(y => y.BlogImage).FirstOrDefault();
			var values = cm.TGetList(id);
			return View(values);
		}
	}
}
