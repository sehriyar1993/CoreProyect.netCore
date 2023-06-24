using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogProject.ViewComponents.Admin
{
    public class Sidebarinbox : ViewComponent
    {
        MessageManager mm = new MessageManager(new EFMessageRepository());
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.saymesaj1 = c.MessageTwos.Count();
            ViewBag.saymesaj2 = c.Notifications.Count();
            ViewBag.saymesaj3 = c.Blogs.Count();
            ViewBag.saymesaj4 = c.Categories.Count();
            
           
            return View();
        }
    }
}