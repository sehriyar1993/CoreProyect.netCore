using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.EntityFrameWork;
using EntitylayerCore.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
	[AllowAnonymous]

	public class NewletterController : Controller
	{
		NewsLettermanager nm = new NewsLettermanager(new EfNewsLetterRepository());
		[HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult SubscribeMail(NewsLetter p)
		{
			p.MailStatus = true;
			nm.TAdd(p);
			return RedirectToAction("Index", "Blog");
		}
	}
}
