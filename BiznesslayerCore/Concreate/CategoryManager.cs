using BiznesslayerCore.Abstract;
using DataAcsessLayerCore.Abstract;
using DataAcsessLayerCore.EntityFrameWork;
using EntitylayerCore.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiznesslayerCore.Concreate
{
    public class CategoryManager : ICategoryServices
    {
        ICategoryDal _category;

        public CategoryManager(ICategoryDal category)
        {
            _category = category;
        }

        public void TAdd(Category t)
        {
            _category.Insert(t);
        }

        public void TChangeToFalse(int id)
        {
            _category.ChangeToFalse(id);
        }

        public void TChangeToTrue(int id)
        {
            _category.ChangeToTrue(id);
        }

        public void TDelete(Category t)
        {
            _category.Delete(t);
        }

        public Category TGetByID(int id)
        {
            return _category.GetById(id);
        }

        public List<Category> TGetList()
        {
            return _category.GetList();
        }

        public void TUpdate(Category t)
        {
            _category.Update(t);
        }
    }
}
