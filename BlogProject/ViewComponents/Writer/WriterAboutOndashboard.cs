using BiznesslayerCore.Abstract;
using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using EntitylayerCore.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.ViewComponents.Writer
{
    public class WriterAboutOndashboard: ViewComponent
    {
        WriterManager _writerServices = new WriterManager(new EFWriterRepository());
        private readonly UserManager<AppUser> _usermanager;
        Context c = new Context();

        public WriterAboutOndashboard(UserManager<AppUser> usermanager)
        {
            _usermanager = usermanager;
        }

        public IViewComponentResult Invoke()
        {
            var name = User.Identity.Name;
           ViewBag.Name = name;
            var usermail = c.Users.Where(x => x.UserName == name).Select(y=>y.Email).FirstOrDefault();
            var userimage = c.Users.Where(x => x.UserName == name).Select(y=>y.ImageUrl).FirstOrDefault();
            var about = c.Users.Where(x => x.UserName == name).Select(y=>y.About).FirstOrDefault();
            ViewBag.Mail = usermail;
            ViewBag.M = userimage;
            ViewBag.about = about;

            //var id = c.Writers.Where(x => x.WriterMail == user).Select(y => y.WriterID).FirstOrDefault();
            //var values = _writerServices.GetWriterById(id);
            return View();
        }
    }
}
