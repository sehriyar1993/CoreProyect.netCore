using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogProject.Areas.Admin.ViewComponents.WidgetLastMessage
{
    public class LastMessageForWidget : ViewComponent
    {
        MessageManager mm = new MessageManager(new EFMessageRepository());
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.a11 = c.MessageTwos.OrderByDescending(x => x.MessageId).Select(x => x.MessageDetail).Take(1).FirstOrDefault(); 
            ViewBag.a12 = c.MessageTwos.OrderByDescending(x => x.MessageId).Select(x => x.Subject).Take(1).FirstOrDefault(); 
            var id = c.MessageTwos.OrderByDescending(x => x.MessageStatus == true ).Select(x=>x.MessageId).Take(1).FirstOrDefault(); 
            ViewBag.aa1 = c.MessageTwos.OrderByDescending(x => x.MessageId).Select(x => x.MessageDate.ToShortDateString()).Take(1).FirstOrDefault();
            

            
            var values = mm.TGetListMessageByWriter(id);
            return View(values);
        }
    }
}