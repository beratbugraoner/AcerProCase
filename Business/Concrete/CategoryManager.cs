using Business.Abstract;
using Business.Contants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Data;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            using (var context = new AcerProDbContext())
            {
                var addedCategories = context.Categories.Find(category.CategoryId);
                if (addedCategories == null)
                {
                    context.Categories.Add(category);
                    context.SaveChanges();
                    return new SuccessResult(Messages.CategoryAdded);
                }
                return new ErrorResult(Messages.NewsNotFound);
            }
        }

        public IResult Delete(Category category)
        {
            using (var context = new AcerProDbContext())
            {
                var deletedCategories = context.Categories.Find(category.CategoryId);
                if (deletedCategories != null)
                {
                    context.Categories.Remove(deletedCategories);
                    context.SaveChanges();
                    return new SuccessResult(Messages.CategoryDeleted);
                }
                return new ErrorResult(Messages.NewsNotFound);
            }
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList());
        }

        
        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }

        public IResult Update(Category category)
        {
            using (var context = new AcerProDbContext())
            {
                var updatedCategories = context.Categories.Find(category.CategoryId);
                if (updatedCategories != null)
                {
                    _categoryDal.Update(category);
                    return new SuccessResult(Messages.CategoryUpdated);
                }
                return new ErrorResult(Messages.NewsNotFound);
            }
        }
    }
}
