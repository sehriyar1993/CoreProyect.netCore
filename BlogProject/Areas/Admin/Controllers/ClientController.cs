using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using EntitylayerCore.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;
using X.PagedList;

namespace BlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles = "Admin")]

	public class ClientController : Controller
    {
        MessageManager mm = new MessageManager(new EFMessageRepository());
        AppUserManager mmm = new AppUserManager(new EFAppUserRepository());
        private readonly UserManager<AppUser> _userManager;

        Context c = new Context();

        public ClientController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index(int page = 1)
        {
            var user = User.Identity.Name;
            ViewBag.User = user;
            var usermail = c.Users.Where(x => x.UserName == user).Select(y => y.Email).FirstOrDefault();
            var userimage = c.Users.Where(x => x.UserName == user).Select(y => y.ImageUrl).FirstOrDefault();
            ViewBag.Mail = usermail;
            ViewBag.M = userimage;
            var name = c.Writers.Where(x => x.WriterMail == user).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.Name = name;
            var values = mmm.TGetList().ToPagedList(page, 10);
            return View(values);
        }
        public IActionResult Delete(int id)
        {
            var values = mmm.TGetByID(id);
            mmm.TDelete(values);
            return RedirectToAction("Index");
        }
        [Route("Admin/[controller]/[action]/{id}")]

        public IActionResult Detail(int id)
        {
                var values = mmm.TGetByID(id);
                return View(values);
            
        }
    }
}
