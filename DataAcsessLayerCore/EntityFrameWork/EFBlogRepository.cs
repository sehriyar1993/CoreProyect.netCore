using DataAcsessLayerCore.Abstract;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.Repositories;
using EntitylayerCore.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayerCore.EntityFrameWork
{
	public class EFBlogRepository : GenericRepository<Blog>, IBlogDal
	{
		public List<Blog> GetListWithCategory()
		{
			using (var context = new Context())
			{
				return context.Blogs.Include(x => x.Category).ToList();

			}
		}
        public List<Blog> GetLast10blog()
        {
            using (var context = new Context())
            {
                return context.Blogs.Include(x => x.Category).ToList();

            }
        }
        public List<Blog> GetListWithCategoryByWriter(int id)
		{
			using (var context = new Context())
			{
				return context.Blogs.Include(x => x.Category).Where(x=>x.AppUserId == id).ToList();

			}
		}
	}
}
