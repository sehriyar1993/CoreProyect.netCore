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
    public class EFCommentRepository : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetCommentsBlogs()
        {
            using (var context = new Context())
            {
                return context.Comments.Include(x => x.Blog).ToList();

            }
        }
    }
}
