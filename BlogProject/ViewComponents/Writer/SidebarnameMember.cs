using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogProject.ViewComponents.Writer
{
    public class SidebarnameMember : ViewComponent
    {
        WriterManager mm = new WriterManager(new EFWriterRepository());
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            var name = User.Identity.Name;
            ViewBag.addd = name;
            var usermail = c.Users.Where(x => x.UserName == name).Select(y => y.Email).FirstOrDefault();
            ViewBag.profile = c.Users.Where(x => x.UserName == name).Select(y => y.ImageUrl).FirstOrDefault();
            ViewBag.mailll = usermail;
            return View();
        }
    }
}
