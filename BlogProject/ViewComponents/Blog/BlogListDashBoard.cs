using BiznesslayerCore.Concreate;
using DataAcsessLayerCore.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogProject.ViewComponents.Blog
{
    public class BlogListDashBoard: ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        public  IViewComponentResult Invoke()
        {
            var values = bm.TGetLast10blog();
            return View(values);
        }
    }
}
