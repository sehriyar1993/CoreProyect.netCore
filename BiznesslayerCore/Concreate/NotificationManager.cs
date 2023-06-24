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
    public class NotificationManager: INotificationServices
    {
        INotificationDal _not;

        public NotificationManager(INotificationDal not)
        {
            _not = not;
        }

        public void TAdd(Notification t)
        {
            _not.Insert(t);
        }

        public void TDelete(Notification t)
        {
            _not.Delete(t);
        }

        public Notification TGetByID(int id)
        {
            return _not.GetById(id);
        }

        public List<Notification> TGetList()
        {
            return _not.GetList();
        }

        public void TUpdate(Notification t)
        {
            _not.Update(t);
        }
    }
}
