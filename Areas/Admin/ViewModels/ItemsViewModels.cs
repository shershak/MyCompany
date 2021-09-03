using System.Linq;
using MyCompany.Domain.Entities;

namespace MyCompany.Areas.Admin.ViewModels
{
    public class ItemsViewModels
    {
        public IQueryable<NewsItem> News { get; set; }
        public IQueryable<ServiceItem> Services { get; set; }

    }
}
