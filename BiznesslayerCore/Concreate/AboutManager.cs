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
    public class AboutManager:IAboutServices
    {
        IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public void TAdd(About t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(About t)
		{
			throw new NotImplementedException();
		}

		public About TGetByID(int id)
		{
			return _aboutDal.GetById(id);
		}

		public List<About> TGetList()
		{
			return _aboutDal.GetList();
		}

		public void TUpdate(About t)
		{
			throw new NotImplementedException();
		}
	}
}
