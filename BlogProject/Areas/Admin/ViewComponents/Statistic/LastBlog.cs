using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Areas.Admin.ViewComponents.Statistic
{
    public class LastBlog : ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        MessageManager messageManager = new MessageManager(new EFMessageRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            return View();
        }
    
    }
}
