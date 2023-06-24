using BiznesslayerCore.Abstract;
using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogProject.Controllers
{

	public class DashBoardController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            var user = User.Identity.Name;
            var id = c.Users.Where(x => x.UserName == user).Select(y => y.Id).FirstOrDefault();
            ViewBag.s1 = c.Blogs.Count();
            ViewBag.s2 = c.Blogs.Where(x => x.AppUserId == id).Count();
            ViewBag.s3 = c.Categories.Count();
            return View();
        }
    }
}
