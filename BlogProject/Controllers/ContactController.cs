using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.EntityFrameWork;
using EntitylayerCore.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BlogProject.Controllers
{
	[AllowAnonymous]

	public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EFContactRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.ContactStatus = true;
            p.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            cm.TAdd(p);
            return RedirectToAction("Index");
        }
    }
}
