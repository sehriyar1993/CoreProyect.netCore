using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using EntitylayerCore.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.Linq;
using X.PagedList;

namespace BlogProject.Areas.Admin.Controllers
{
    
    [Area("Admin")]
	[Authorize(Roles = "Admin")]
	public class CommentController : Controller
    {
        Context context = new Context();
        CommentManager cm = new CommentManager(new EFCommentRepository());
        [HttpGet]
        [Route("Admin/[controller]/[action]")]

        public IActionResult Index(int page = 1)
        {
            var values = cm.TGetCommentsBlogs().ToPagedList(page, 6);
            return View(values);
        }
        [Route("Admin/[controller]/[action]")]

        public PartialViewResult PartialAddCommentAdmin()
        {
            return PartialView();
        }
        [HttpPost]
        [Route("Admin/[controller]/[action]")]

        public IActionResult PartialAddCommentAdmin(Comment p)
        {
            var user = User.Identity.Name;
            var name = context.Users.Where(x => x.UserName == user).Select(y => y.Name).FirstOrDefault();
            ViewBag.Adminblog = context.Users.Where(x => x.UserName == user).Select(y => y.ImageUrl).FirstOrDefault();
            p.CommentUserName = name;
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortTimeString());
            p.CommentStatus = true;
            cm.TAdd(p);
            return RedirectToAction("Index", "Blog");
        }
    }
}
