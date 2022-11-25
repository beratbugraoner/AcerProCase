using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.Data;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, AcerProDbContext>, ICategoryDal
    {

    }
}
