using System;
using System.Linq;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain.Repositories.Abstract
{
    public interface INewsItemsRepository
    {
        IQueryable<NewsItem> GetNewsItems();
        NewsItem GetNewsItemById(Guid id);
        void SaveNewsItem(NewsItem entity);
        void DeleteNewsItem(NewsItem entity);
    }
}
