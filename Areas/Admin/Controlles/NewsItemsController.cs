using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Areas.Admin.Controllers;
using MyCompany.Domain;
using MyCompany.Domain.Entities;
using MyCompany.Service;

namespace MyCompany.Areas.Admin.Controlles
{
    [Area("Admin")]
    public class NewsItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public NewsItemsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.NewsItems.GetNewsItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageNews");
            return View(dataManager.NewsItems.GetNewsItems());
        }
        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new NewsItem() : dataManager.NewsItems.GetNewsItemById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(NewsItem model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                if (model.Status == null)
                {
                    model.Status = "true";
                    string text = "Ваша новость \"" + model.Title + "\" опубликована!";
                    Mail.Send(Config.SubjectMailNews, model.Email, text).Wait();
                }
                dataManager.NewsItems.SaveNewsItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(NewsItem model)
        {
            dataManager.NewsItems.DeleteNewsItem(model);

            string text = "Ваша новость не опубликована! \"" + model.Title + "\" не соответствует требованиям нашего сайта!";
            Mail.Send(Config.SubjectMailNews, model.Email, text).Wait();

            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
