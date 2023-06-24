using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogProject.ViewComponents.Admin
{
    public class AdminMessage : ViewComponent
    {
        MessageManager mm = new MessageManager(new EFMessageRepository());
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.saymesaj = c.MessageTwos.Count();
            var user = User.Identity.Name;
            var id = c.Users.Where(x => x.UserName == user).Select(y => y.Id).FirstOrDefault();
            var values = mm.TGetListMessageByWriter(id);
            return View(values);
        }

    
    }
}
