using DataAcsessLayerCore.Abstract;
using DataAcsessLayerCore.Repositories;
using EntitylayerCore.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayerCore.EntityFrameWork
{
	public class EfNewsLetterRepository:GenericRepository<NewsLetter> , INewsletterDAl
	{
	}
}
