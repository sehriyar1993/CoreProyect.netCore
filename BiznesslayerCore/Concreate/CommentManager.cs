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
	public class CommentManager : ICommentServices
	{
		ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		public void TAdd(Comment t)
		{
			_commentDal.Insert(t);
		}

		public void TDelete(Comment t)
		{
			_commentDal.Delete(t);
		}

		public Comment TGetByID(int id)
		{
			throw new NotImplementedException();
		}

        public List<Comment> TGetCommentsBlogs()
        {
            return _commentDal.GetCommentsBlogs();
        }

        public List<Comment> TGetList(int id)
		{
			return _commentDal.GetListAll(x=>x.BlogId==id);
		}

		public List<Comment> TGetList()
		{
			return _commentDal.GetList();
		}

		public void TUpdate(Comment t)
		{
			throw new NotImplementedException();
		}
	}
}
