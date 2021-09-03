using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;
using MyCompany.Domain.Entities;
using System.Linq;
using MyCompany.Areas.Admin.ViewModels;

namespace MyCompany.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            IQueryable<NewsItem> NewsItems = dataManager.NewsItems.GetNewsItems();
            IQueryable<ServiceItem> ServiceItems = dataManager.ServiceItems.GetServiceItems();
            ItemsViewModels viewModels = new ItemsViewModels()
            {
                News = NewsItems,
                Services = ServiceItems
            };
            return View(viewModels);
        }
    }
}