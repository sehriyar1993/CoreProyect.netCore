using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        NotificationManager notificationManager = new NotificationManager(new EFNotificationRepository());
        public IViewComponentResult Invoke()
        {
            var values = notificationManager.TGetList();
            return View(values);
        }
    }
}
