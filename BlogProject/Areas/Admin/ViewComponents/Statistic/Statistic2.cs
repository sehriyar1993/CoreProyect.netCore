using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2 : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EFAboutRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var values = aboutManager.TGetByID(1);
            return View(values);
        }
    }
}
