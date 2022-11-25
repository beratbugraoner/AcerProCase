using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Data;
using Entities.Concrete;
using Entities.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class NewsManager : INewsService
    {    
        private readonly INewsDal _newsDal;
        public NewsManager( INewsDal newsDal)
        {
            _newsDal = newsDal;
        }

        public IResult Add(News news)
        {
            using (var context = new AcerProDbContext())
            {
                var addedNews = context.News.Find(news.Id);
                if (addedNews == null)
                {
                    context.News.Add(news);
                    context.SaveChanges();
                    return new SuccessResult(Messages.NewsAdded);
                }
                return new ErrorResult(Messages.NewsNotFound);
            }
        }

        public IResult ChangeTheStatusFalse(News news)
        {
            using (var context = new AcerProDbContext())
            {
                var changeStatusNews = context.News.Find(news.Id);
                if (changeStatusNews != null)
                {
                    changeStatusNews.Status = false;
                    context.News.Update(changeStatusNews);
                    context.SaveChanges();
                    return new SuccessResult(Messages.NewsUpdated);
                }
                return new ErrorResult(Messages.NewsNotFound);
            }
        }

        public IResult ChangeTheStatusTrue(News news)
        {
            using (var context = new AcerProDbContext())
            {
                var changeStatusNews = context.News.Find(news.Id);
                if (changeStatusNews != null)
                {
                    changeStatusNews.Status = true;
                    context.News.Update(changeStatusNews);
                    context.SaveChanges();
                    return new SuccessResult(Messages.NewsUpdated);
                }
                return new ErrorResult(Messages.NewsNotFound);
            }
        }

        public IResult Delete(News news)
        {
            using (var context = new AcerProDbContext())
            {
                var deletedNews = context.News.Find(news.Id);
                if (deletedNews != null)
                {
                    context.News.Remove(deletedNews);
                    context.SaveChanges();
                    return new SuccessResult(Messages.NewsDeleted);
                }
                return new ErrorResult(Messages.NewsNotFound);
            }
        }

        public IDataResult<List<News>> GetAll()
        {
            return new SuccessDataResult<List<News>>(_newsDal.GetList(), Messages.NewsListed);
        }

        public IDataResult<List<News>> GetAllActiveNews()
        {
            return new SuccessDataResult<List<News>>(_newsDal.GetList(p => p.Status == true),Messages.NewsListed);
        }

        public IDataResult<List<News>> GetAllNewsByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<News>>(_newsDal.GetList(p => p.CategoryId == categoryId),Messages.NewsListed);
        }

        public IDataResult<News> GetById(int productId)
        {
            return new SuccessDataResult<News>(_newsDal.Get(p => p.Id == productId),Messages.NewsListed);
        }

        public IResult Update(News news)
        {
            using (var context = new AcerProDbContext())
            {
                var updatedNews = context.News.Find(news.Id);
                if (updatedNews != null)
                {
                    _newsDal.Update(news);
                    return new SuccessResult(Messages.NewsUpdated);
                }
                return new ErrorResult(Messages.NewsNotFound);
            }
        }


    }
}
