using EntitylayerCore.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiznesslayerCore.Abstract
{
    public interface IMessageServices:IGenericServices<MessageTwo>
    {
        List<MessageTwo> GetListByWriter(int id);
        List<MessageTwo> TGetListMessageByWriter(int id);
		List<MessageTwo> TGetListMessageByInclude(int id);

		MessageTwo TGetListNameByWriter(int id);


    }
}
