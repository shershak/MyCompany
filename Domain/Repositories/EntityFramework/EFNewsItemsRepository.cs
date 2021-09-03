using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;
using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFNewsItemsRepository : INewsItemsRepository
    {
        private readonly AppDbContext context;
        public EFNewsItemsRepository (AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<NewsItem> GetNewsItems()
        {
            return context.NewsItems;
        }
        public NewsItem GetNewsItemById(Guid id)
        {
            return context.NewsItems.FirstOrDefault(x => x.Id == id);
        }
        public void SaveNewsItem(NewsItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteNewsItem(NewsItem entity)
        {
            context.NewsItems.Remove(new NewsItem() { Id = entity.Id});
            context.SaveChanges();
        }
    }
}
