using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface INewsService
    {
        IDataResult<List<News>> GetAll();
        IDataResult<List<News>> GetAllActiveNews();
        IDataResult<List<News>> GetAllNewsByCategoryId(int id);
        IDataResult<News> GetById(int productId);
        IResult Add(News news);
        IResult Update(News news);
        IResult Delete(News news);
        IResult ChangeTheStatusTrue(News news);
        IResult ChangeTheStatusFalse(News news);
    }
}
