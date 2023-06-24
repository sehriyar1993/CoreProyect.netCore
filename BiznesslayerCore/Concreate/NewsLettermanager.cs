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
	public class NewsLettermanager : INewsLetterServices
	{
		INewsletterDAl _newsletterDAl;

		public NewsLettermanager(INewsletterDAl newsletterDAl)
		{
			_newsletterDAl = newsletterDAl;
		}

		public void TAdd(NewsLetter t)
		{
			_newsletterDAl.Insert(t);
		}

		public void TDelete(NewsLetter t)
		{
			throw new NotImplementedException();
		}

		public NewsLetter TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<NewsLetter> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(NewsLetter t)
		{
			throw new NotImplementedException();
		}
	}
}
