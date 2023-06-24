using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiznesslayerCore.Abstract
{
    public interface IGenericServices<T>
    {
        
            void TAdd(T t);
            void TDelete(T t);
            void TUpdate(T t);
            List<T> TGetList();
            T TGetByID(int id);

            
        
    }
}
