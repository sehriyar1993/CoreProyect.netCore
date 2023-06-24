using BiznesslayerCore.Abstract;
using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogProject.ViewComponents.Writer
{
    public class WriterMessageNotification: ViewComponent
    {
      MessageManager mm = new MessageManager(new EFMessageRepository());
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
			//var val = await _userManager.FindByNameAsync(User.Identity.Name);
			//ViewBag.memberName = values.UserName + " " + values.Surname;
			var user = User.Identity.Name;
            var id = c.Users.Where(x => x.UserName == user).Select(y => y.Id).FirstOrDefault();
            var values = mm.TGetListMessageByWriter(id);
            return View(values);
        }
    }
}
