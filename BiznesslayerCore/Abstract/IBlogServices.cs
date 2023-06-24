using EntitylayerCore.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiznesslayerCore.Abstract
{
	public interface IBlogServices : IGenericServices<Blog>
	{
		List<Blog> GetBlogAllCategory();
		List<Blog> GetBlogAllCategoryByWriter(int id);
		List<Blog> TGetLast10blog();


    }
}
