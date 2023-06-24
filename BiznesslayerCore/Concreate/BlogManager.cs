using BiznesslayerCore.Abstract;
using DataAcsessLayerCore.Abstract;
using EntitylayerCore.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiznesslayerCore.Concreate
{
	public class BlogManager : IBlogServices
	{
		IBlogDal _blogdal;

		public BlogManager(IBlogDal blogdal)
		{
			_blogdal = blogdal;
		}

		public List<Blog> GetBlogAllCategory()
		{
			return _blogdal.GetListWithCategory();
		}
		public List<Blog> GetListWithCategoryByWriterBM(int id)
		{
			return _blogdal.GetListWithCategoryByWriter(id);
		}

		public void TAdd(Blog t)
		{
			_blogdal.Insert(t);
		}

		public void TDelete(Blog t)
		{
			_blogdal.Delete(t);
		}

		public Blog TGetByID(int id)
		{
			return _blogdal.GetById(id);
		}
		public List<Blog> TGetBlogIdList(int id)
		{
			return _blogdal.GetListAll(x=>x.BlogId==id);
		}
		public List<Blog> TGetList()
		{
			return _blogdal.GetList();
		}
		public List<Blog> TGetLast3blog()
		{
			return _blogdal.GetList().Take(3).ToList();
		}
        public List<Blog> TGetLast10blog()
        {
            return _blogdal.GetLast10blog().Take(10).ToList();
        }
        public void TUpdate(Blog t)
		{
			_blogdal.Update(t);
		}

		public List<Blog> GetBlogAllCategoryByWriter(int id)
		{

			return _blogdal.GetListAll(x=>x.WriterID==id);
		}
	}
}
