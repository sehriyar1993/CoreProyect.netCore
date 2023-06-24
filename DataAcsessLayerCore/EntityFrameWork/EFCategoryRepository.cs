using DataAcsessLayerCore.Abstract;
using DataAcsessLayerCore.Conreate;
using DataAcsessLayerCore.Repositories;
using EntitylayerCore.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayerCore.EntityFrameWork
{
    public class EFCategoryRepository: GenericRepository<Category> , ICategoryDal
    {
        Context context = new Context();
        public void ChangeToFalse(int id)
        {
            var values = context.Categories.Find(id);
            values.CategoryStatus = false;
            context.Update(values);
            context.SaveChanges();
        }

        
        public void ChangeToTrue(int id)
        {
            var values = context.Categories.Find(id);
            values.CategoryStatus = true;
            context.Update(values);
            context.SaveChanges();
        }
    }
}
