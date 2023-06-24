using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogProject.ViewComponents.Admin
{
    public class AdminNotification : ViewComponent
    {
        NotificationManager notificationManager = new NotificationManager(new EFNotificationRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.saynot = c.Notifications.Count();

            var values = notificationManager.TGetList();
            return View(values);
        }
    }
    
}
