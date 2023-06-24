using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using EntitylayerCore.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using X.PagedList;
using MimeKit;
using MailKit.Net.Smtp;
using BlogProject.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace BlogProject.Areas.Admin.Controllers
{
   
    [Area("Admin")]
	[Authorize(Roles = "Admin")]

	public class MessageController : Controller
    {
        WriterManager wm = new WriterManager(new EFWriterRepository());
        MessageManager mm = new MessageManager(new EFMessageRepository());
        AppUserManager mmm = new AppUserManager(new EFAppUserRepository());
        private readonly UserManager<AppUser> _userManager;

        Context c = new Context();

        public MessageController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult MailSend()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MailSend([FromForm] MailRequestAdmin mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "ficihaciyev@gmail.com");

            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mailRequest.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = mailRequest.Subject;

            SmtpClient client = new SmtpClient();
            try
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("ficihaciyev@gmail.com", "qcjrvjxbbuvckfcv\r\n");
                client.Send(mimeMessage);
                client.Disconnect(true);
                // display a success message
                ViewBag.Message = "Email sent successfully.";
            }
            catch (Exception ex)
            {
                // display an error message
                ViewBag.Message = "Email failed to send: " + ex.Message;
            }

            return View();
        }
        public IActionResult Index(string searchString)
        {
            var user = User.Identity.Name;
            var id = c.Users.Where(x => x.UserName == user).Select(y => y.Id).FirstOrDefault();
            if (searchString != null)
                searchString = searchString.ToLower();
            ViewData["CurrentFilter"] = searchString;
            var values = from x in mm.TGetListMessageByWriter(id) select x;
            if (!string.IsNullOrEmpty(searchString))
            {
                values = values.Where(y => y.SenderAppUser.Email.ToLower().Contains(searchString));
            }
            return View(values.ToList());
            //var user = User.Identity.Name;
            //var id = c.Users.Where(x => x.UserName == user).Select(y => y.Id).FirstOrDefault();
            //var values = mm.TGetListMessageByWriter(id).ToPagedList(page, 3);

            //return View(values);
        }
        public IActionResult GetMessageByNameWriter(string searchString)
        {
            var user = User.Identity.Name;
            var id = c.Users.Where(x => x.UserName == user).Select(y => y.Id).FirstOrDefault();
            if (searchString != null)
                searchString = searchString.ToLower();
            ViewData["CurrentFilter"] = searchString;
            var values = from x in mm.TGetListMessageByWriter(id) select x;
            if (!string.IsNullOrEmpty(searchString))
            {
                values = values.Where(y => y.SenderAppUser.Email.ToLower().Contains(searchString));
            }
            return View(values.ToList());
        }
        public IActionResult Detail(int id)
        {
            var values = mm.TGetByID(id);
            return View(values);

        }
        public IActionResult Send(string searchString)
        {
            var user = User.Identity.Name;
            var id = c.Users.Where(x => x.UserName == user).Select(y => y.Id).FirstOrDefault();
            if (searchString != null)
                searchString = searchString.ToLower();
            ViewData["CurrentFilter"] = searchString;
            var values = from x in mm.TGetListMessageByInclude(id) select x;
            if (!string.IsNullOrEmpty(searchString))
            {
                values = values.Where(y => y.RecieverAppUser.Email.ToLower().Contains(searchString));
            }
            return View(values.ToList());

            //var user = User.Identity.Name;
            //var id = c.Users.Where(x => x.UserName == user).Select(y => y.Id).FirstOrDefault();
            //var values = mm.TGetListMessageByInclude(id);
            //return View(values);
        }
        [HttpGet]
        [Route("Admin/[controller]/[action]")]
        public IActionResult Add()
        {
            List<SelectListItem> values = (from x in mmm.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.Email,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.vappuse = values;
            return View();

        }
        [HttpPost]
        [Route("Admin/[controller]/[action]")]
        public IActionResult Add(MessageTwo p)
        {
            var user = User.Identity.Name;
            var id = c.Users.Where(x => x.UserName == user).Select(y => y.Id).FirstOrDefault();
            p.SenderId = id;
            //p.ReceiverID = 2;
            p.MessageStatus = true;
            p.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            mm.TAdd(p);
            return RedirectToAction("Index", "Category");

        }
        
    }
    //public IActionResult MailSend(MailRequestAdmin mailRequest)
    //    {
    //        MimeMessage mimeMessage = new MimeMessage();

    //        MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "ficihaciyev@gmail.com");

    //        mimeMessage.From.Add(mailboxAddressFrom);
           
    //            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);
    //            mimeMessage.To.Add(mailboxAddressTo);
          

    //        var bodyBuilder = new BodyBuilder();
    //        bodyBuilder.TextBody = mailRequest.Body;
    //        mimeMessage.Body = bodyBuilder.ToMessageBody();

    //        mimeMessage.Subject = mailRequest.Subject;

    //        SmtpClient client = new SmtpClient();
    //        client.Connect("smtp.gmail.com", 587, false);
    //        client.Authenticate("ficihaciyev@gmail.com", "qcjrvjxbbuvckfcv\r\n");
    //        client.Send(mimeMessage);
    //        client.Disconnect(true);
    //        return View();
    //    }
    
}
