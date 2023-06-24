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
	public class WriterManager: IWriterServices
	{
		IWriterdal _writerdal;

		public WriterManager(IWriterdal writerdal)
		{
			_writerdal = writerdal;
		}

        public List<Writer> GetWriterById(int id)
        {
			return _writerdal.GetListAll(x=>x.WriterID==id);
        }

        public void TAdd(Writer t)
		{
			_writerdal.Insert(t);
		}

		public void TDelete(Writer t)
		{
			throw new NotImplementedException();
		}

		public Writer TGetByID(int id)
		{
			return _writerdal.GetById(id);
		}

		public List<Writer> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Writer t)
		{
			_writerdal.Update(t);
		}
	}
}
