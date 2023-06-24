using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using X.PagedList;

namespace BlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles = "Admin")]

	public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EFContactRepository());

        public IActionResult Index(int page = 1)
        {
            var values = cm.TGetList().ToPagedList();
            return View(values);
        }
    }
}
