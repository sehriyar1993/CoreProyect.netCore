using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace BlogProject.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1: ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        MessageManager messageManager = new MessageManager(new EFMessageRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var user = User.Identity.Name;
            var id = c.Writers.Where(x => x.WriterMail == user).Select(y => y.WriterID).FirstOrDefault();
            ViewBag.s1 = c.Blogs.Count();
            ViewBag.message = c.MessageTwos.Count();
            ViewBag.s2 = c.Blogs.Where(x => x.WriterID == id).Count();
            ViewBag.s3 = c.Categories.Count();
            //string api = "293a1a1514bd43dc916800c08859ed4e";
           // string connection = "https://api.openweathermap.org/data/2.5/weather?q=Baku&mode=xml&appid=" +api;
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Baku&mode=xml&appid=293a1a1514bd43dc916800c08859ed4e&units=metric";
            XDocument document = XDocument.Load(connection);
            ViewBag.a51 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}
