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
    public class MessageManager:IMessageServices
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public List<MessageTwo> GetListByWriter(int id)
        {
            return _messageDal.GetListAll(x=>x.Receiver==id);
        }

        public void TAdd(MessageTwo t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(MessageTwo t)
        {
            _messageDal.Delete(t);
        }

        public MessageTwo TGetByID(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<MessageTwo> TGetList()
        {
            return _messageDal.GetList();
        }

		public List<MessageTwo> TGetListMessageByInclude(int id)
		{
			return _messageDal.GetListMessageByInclude(id);
		}

		public List<MessageTwo> TGetListMessageByWriter(int id)
        {
            return _messageDal.GetListMessageByWriter(id);
        }

        public MessageTwo TGetListNameByWriter(int id)
        {
            return _messageDal.GetListNameByWriter(id);
        }

        public void TUpdate(MessageTwo t)
        {
            _messageDal.Update(t);
        }
    }
}
