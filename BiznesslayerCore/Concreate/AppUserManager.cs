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
    public class AppUserManager: IAppUserServices
    {
        IAppUserDal _appuserdal;

        public AppUserManager(IAppUserDal appuserdal)
        {
            _appuserdal = appuserdal;
        }

        public void TAdd(AppUser t)
        {
            _appuserdal.Insert(t);
        }

        public void TDelete(AppUser t)
        {
            _appuserdal.Delete(t);
        }

        public AppUser TGetByID(int id)
        {
            return _appuserdal.GetById(id);
        }

        public List<AppUser> TGetList()
        {
            return _appuserdal.GetList();
        }

        public void TUpdate(AppUser t)
        {
            _appuserdal.Update(t);
        }
    }
}
