using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
	
	public class NotificationController : Controller
        
    {
        NotificationManager notificationManager = new NotificationManager(new EFNotificationRepository());

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllowNotification()
        {
            var values = notificationManager.TGetList();
            return View(values);
        }
    }
}
