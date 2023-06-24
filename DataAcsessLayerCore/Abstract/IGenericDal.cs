using EntitylayerCore.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayerCore.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        List<T> GetList();
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        T GetById(int id);
        List<T> GetListAll(Expression<Func<T, bool>> filter);
    }
}
