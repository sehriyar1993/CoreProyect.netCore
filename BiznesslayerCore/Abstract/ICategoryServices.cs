using EntitylayerCore.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiznesslayerCore.Abstract
{
    public interface ICategoryServices : IGenericServices<Category>
    {
        void TChangeToTrue(int id);
        void TChangeToFalse(int id);
    }
}
