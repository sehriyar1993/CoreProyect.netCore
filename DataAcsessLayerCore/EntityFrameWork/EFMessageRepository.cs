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
    public class EFMessageRepository : GenericRepository<MessageTwo>, IMessageDal
    {
        
        public List<MessageTwo> GetListMessageByWriter(int id)
        {
            using (var context = new Context())
            {
                return context.MessageTwos.Include(x => x.SenderAppUser).Where(x => x.ReceiverID == id).ToList();

            }
        }
		public List<MessageTwo> GetListMessageByInclude(int id)
		{
			using (var context = new Context())
			{
				return context.MessageTwos.Include(x => x.RecieverAppUser).Where(x => x.SenderId == id).ToList();

			}
		}
		public MessageTwo GetListNameByWriter(int id)
        {
            using (var context = new Context())
            {
                return context.MessageTwos.Include(x => x.RecieverAppUser).Where(x => x.ReceiverID == id).FirstOrDefault();

            }
        }
    }
}
