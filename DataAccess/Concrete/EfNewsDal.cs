using Core.DataAccess;
using Core.Entities;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Data;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfNewsDal : EfEntityRepositoryBase<News, AcerProDbContext>, INewsDal
    {

        public void UpdateNews(News newNews)
        {
            using (var context = new AcerProDbContext())
            {
                var updatedCar = context.News.Find(newNews.Id);
                if (updatedCar !=null)
                {
                    var updatedEntity = context.Entry(newNews);
                    updatedEntity.State = EntityState.Modified;
                    context.SaveChanges();
                }
                
            }
        }
    }
}
