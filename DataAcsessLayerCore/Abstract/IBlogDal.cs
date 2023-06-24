using EntitylayerCore.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayerCore.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory();
        List<Blog> GetListWithCategoryByWriter(int id);
        List<Blog> GetLast10blog();
    }
}
