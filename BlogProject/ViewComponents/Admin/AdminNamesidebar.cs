using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogProject.ViewComponents.Admin
{
    public class AdminNamesidebar : ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            var name = User.Identity.Name;
            ViewBag.Surname = name;
            var usermail = c.Users.Where(x => x.UserName == name).Select(y => y.Email).FirstOrDefault();
            ViewBag.ImageUrlAdmin = c.Users.Where(x => x.UserName == name).Select(y => y.ImageUrl).FirstOrDefault();
            ViewBag.EmailAdmin = usermail;
            return View();
        }
    }
}
