using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
	[AllowAnonymous]

	public class AboutController : Controller
	{
		AboutManager am = new AboutManager(new EFAboutRepository());
		public IActionResult Index()
		{
			var values = am.TGetList();
			return View(values);
		}
	}
}
