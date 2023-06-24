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
    public class ContactManager: IContactServices
    {
        IContactDal _contactdal;

        public ContactManager(IContactDal contactdal)
        {
            _contactdal = contactdal;
        }

        public void TAdd(Contact t)
        {
           _contactdal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public Contact TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> TGetList()
        {
            return _contactdal.GetList();
        }

        public void TUpdate(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
