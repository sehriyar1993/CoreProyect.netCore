using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using EntitylayerCore.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;
using System.Linq;
using BlogProject.Models;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace BlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles = "Admin")]

	public class WidgetController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        MessageManager mm = new MessageManager(new EFMessageRepository());
        AppUserManager mmm = new AppUserManager(new EFAppUserRepository());

        Context c = new Context();
        [HttpGet]
        [Route("Admin/[controller]/[action]")]
        public IActionResult Index()
        {
            var user = User.Identity.Name;
            ViewBag.User = c.Users.Where(x => x.UserName == user).Select(y => y.Surname).FirstOrDefault();
            ViewBag.UserMail = c.Users.Where(x => x.UserName == user).Select(y => y.Email).FirstOrDefault();
            ViewBag.Userimage = c.Users.Where(x => x.UserName == user).Select(y => y.ImageUrl).FirstOrDefault();
            ViewBag.Usernumber = c.Users.Where(x => x.UserName == user).Select(y => y.PhoneNumber).FirstOrDefault();

            ViewBag.username = c.Users.Where(x => x.UserName == user).Select(y => y.Name).FirstOrDefault();
            ViewBag.comments = c.Comments.Count();
            ViewBag.contact = c.Contacts.Count();
            ViewBag.b = c.Blogs.Count();
            ViewBag.riter = c.Writers.Count();
            ViewBag.letter = c.NewsLetters.Count();
            ViewBag.not = c.Notifications.Count();
            ViewBag.puan = c.BlogRaytings.Count();
            ViewBag.lastcontact = c.Contacts.OrderByDescending(x=>x.ContactId).Select(x=>x.ContactSubject).Take(1).FirstOrDefault();
            ViewBag.adminname = c.Admins.OrderByDescending(x=>x.AdminId==1).Select(x=>x.Name).Take(1).FirstOrDefault();
            ViewBag.adminname = c.Admins.OrderByDescending(x=>x.AdminId==1).Select(x=>x.Name).Take(1).FirstOrDefault();
            ViewBag.admi = c.Admins.OrderByDescending(x=>x.AdminId == 1).Select(x=>x.ImageUrl).Take(1).FirstOrDefault();
            ViewBag.lastcontactname = c.Contacts.OrderByDescending(x=>x.ContactId).Select(x=>x.ContactName).Take(1).FirstOrDefault();
            ViewBag.lastcontact1 = c.Contacts.OrderByDescending(x=>x.ContactId).Select(x=>x.ContactMail).Take(1).FirstOrDefault();
            ViewBag.lastblog = c.Blogs.OrderByDescending(x=>x.BlogId).Select(x=>x.BlogTitle).Take(1).FirstOrDefault();
            ViewBag.aa = c.MessageTwos.OrderByDescending(x=>x.MessageId).Select(x=>x.MessageDate.ToShortDateString()).Take(1).FirstOrDefault();
            ViewBag.message = c.MessageTwos.Count();
            ViewBag.lastblog1 = c.Blogs.OrderByDescending(x=>x.BlogId).Select(x=>x.BlogContent.Substring(0, x.BlogContent.Substring(0, 120).LastIndexOf(" "))).Take(1).FirstOrDefault();

            ViewBag.image = c.Writers.OrderByDescending(x => x.WriterID).Select(x => x.WriterImage).Take(1).FirstOrDefault();
            ViewBag.name = c.Writers.OrderByDescending(x => x.WriterID).Select(x => x.WriterName).Take(1).FirstOrDefault();
            ViewBag.mail = c.Writers.OrderByDescending(x => x.WriterID).Select(x => x.WriterMail).Take(1).FirstOrDefault();
            ViewBag.about = c.Notifications.OrderByDescending(x => x.NotificationID).Select(x => x.NotificationType).Take(1).FirstOrDefault();

            return View();
        }
       
        [HttpPost]
        [Route("Admin/[controller]/[action]")]

        public IActionResult Index([FromForm] MailRequestAdmin mailRequest)
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
            var url = Url.Action("Index", "Widget", new { area = "Admin" });
            HttpContext.Response.Redirect(url);
            return View();
            //return RedirectToAction("Index", "Widget", new { area = "Admin" });
        }
    }
}
