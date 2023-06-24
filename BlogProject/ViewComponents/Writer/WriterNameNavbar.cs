using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogProject.ViewComponents.Writer
{
    public class WriterNameNavbar: ViewComponent
    {
        WriterManager mm = new WriterManager(new EFWriterRepository());
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            var name = User.Identity.Name;
            ViewBag.ad = name;
            var usermail = c.Users.Where(x => x.UserName == name).Select(y => y.Email).FirstOrDefault();
            var userimage = c.Users.Where(x => x.UserName == name).Select(y => y.ImageUrl).FirstOrDefault();
            ViewBag.mail = usermail;
            ViewBag.sekil = userimage;
            return View();
        }
    }
}
