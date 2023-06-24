using BiznesslayerCore.Abstract;
using BiznesslayerCore.Concreate;
using BiznesslayerCore.ValidationRule;
using BlogProject.Models;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using EntitylayerCore.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers
{
	
	public class WriterController : Controller
	{
		WriterManager wm = new WriterManager(new EFWriterRepository());
        MessageManager mm = new MessageManager(new EFMessageRepository());
        AppUserManager mmm = new AppUserManager(new EFAppUserRepository());
        private readonly UserManager<AppUser> _userManager;

        Context c = new Context();

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
		{
            var user = User.Identity.Name;
            ViewBag.User = user;
            var usermail = c.Users.Where(x => x.UserName == user).Select(y => y.Email).FirstOrDefault();
            var userimage = c.Users.Where(x => x.UserName == user).Select(y => y.ImageUrl).FirstOrDefault();
            ViewBag.Mail = usermail;
            ViewBag.M = userimage;
            var name = c.Writers.Where(x => x.WriterMail == user).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.Name = name;
			return View();
		}
		public IActionResult test()
		{
			return View();
		}
		public PartialViewResult Membernavbar()
		{
            var user = User.Identity.Name;
            ViewBag.User = user;
            ViewBag.Us = user;
            var usermail = c.Users.Where(x => x.UserName == user).Select(y => y.Email).FirstOrDefault();
            var userimage = c.Users.Where(x => x.UserName == user).Select(y => y.ImageUrl).FirstOrDefault();
            ViewBag.Mail1 = usermail;
            ViewBag.Msekil = userimage;
            return PartialView();
		}
		[HttpGet]
        public async Task<IActionResult> EditProfile()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUserImage userEditViewModel = new AppUserImage();
            userEditViewModel.Id = values.Id;
            userEditViewModel.username = values.UserName;
            userEditViewModel.name = values.Name;
            userEditViewModel.surname = values.Surname;
            userEditViewModel.phonenumber = values.PhoneNumber;
            userEditViewModel.about = values.About;
            userEditViewModel.mail = values.Email;
            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> EditProfile(AppUserImage p)
        {
            //var values = await _userManager.FindByNameAsync(User.Identity.Name);
            //AppUserImage userEditViewModel = new AppUserImage();
            //userEditViewModel.name = values.Name;
            //userEditViewModel.surname = values.Surname;
            //userEditViewModel.phonenumber = values.PhoneNumber;
            //userEditViewModel.mail = values.Email;
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "wwwroot/WriterImage" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                user.ImageUrl = imagename;
            }
            user.ImageUrl = p.imageurl;
            user.Name = p.name;
            user.Id = p.Id;
            user.Surname = p.surname;
            user.Email = p.mail;
            user.PhoneNumber = p.phonenumber;
            user.UserName = p.username;
            user.About = p.about;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
				return RedirectToAction("SignIn", "RegisterUser");
			}
			return View();
        
        }
        [HttpGet]
        public IActionResult WriterAdd()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult WriterAdd(AppUserImage p, AppUser w)
        {
            //WriterValidator wl = new WriterValidator();
            //ValidationResult result = wl.Validate(w);
            //if(p.ImageUrl != null)
            //{
                var _path = Path.GetExtension(p.Image.FileName);
                var newimagename = Guid.NewGuid() + _path;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImage", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.Image.CopyTo(stream);
                w.ImageUrl = newimagename;
            //}
            //if (result.IsValid)
            //{
                w.Name = p.name;
                w.About = p.about;
                w.Email = p.mail;
                w.UserName = p.username;
                w.Surname = p.surname;
            w.PhoneNumber = p.phonenumber;
            w.PasswordHash = p.password;
                mmm.TAdd(w);
                return RedirectToAction("Index", "Dashboard");

            //}
            //else
            //{
            //    foreach (var item in result.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}
            //return View();
        }
        public IActionResult WriterMessage()

        {
            var user = User.Identity.Name;
            var id = c.Users.Where(x => x.UserName == user).Select(y => y.Id).FirstOrDefault();
            var values = mm.TGetListMessageByWriter(id);
            return View(values);
        }
		public IActionResult SendMessage()

		{
			var user = User.Identity.Name;
			var id = c.Users.Where(x => x.UserName == user).Select(y => y.Id).FirstOrDefault();
			var values = mm.TGetListMessageByInclude(id);
			return View(values);
		}
		public IActionResult MessageDetail(int id)
        {
          
            var values = mm.TGetByID(id);
            return View(values);
        }
        [HttpGet]
         public IActionResult AddMessage()
        {
			List<SelectListItem> values = (from x in mmm.TGetList()
										   select new SelectListItem
										   {
											   Text = x.Email,
											   Value = x.Id.ToString()
										   }).ToList();
			ViewBag.vappuser = values;
			return View();

        }
        [HttpPost]
        public IActionResult AddMessage(MessageTwo p)
        {
            var user = User.Identity.Name;
            var id = c.Users.Where(x => x.UserName == user).Select(y => y.Id).FirstOrDefault();
            p.SenderId = id;
            //p.ReceiverID = 2;
            p.MessageStatus = true;
            p.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            mm.TAdd(p);
            return RedirectToAction("WriterMessage");

        }
    }
}
