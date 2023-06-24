using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.ViewComponents.Admin
{
    public class Last3adminblog : ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = bm.TGetLast3blog();
            return View(values);
        }

    }
    
}
