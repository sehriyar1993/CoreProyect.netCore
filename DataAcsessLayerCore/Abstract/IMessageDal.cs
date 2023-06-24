using EntitylayerCore.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayerCore.Abstract
{
    public interface IMessageDal:IGenericDal<MessageTwo>
    {
        List<MessageTwo> GetListMessageByWriter(int id);
        List<MessageTwo> GetListMessageByInclude(int id);
        MessageTwo GetListNameByWriter(int id);

    }
}
