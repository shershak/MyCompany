using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;
using MyCompany.Domain.Entities;
using MyCompany.Service;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageIndex"));
        }
        public IActionResult Contacts()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
        }
        public IActionResult Message()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Message(MessageItem model)
        {
            if (ModelState.IsValid)
            {
                string text = $"<strong>Cообщение от: {model.Name}, {model.Email}.</strong><br>{model.Text}";
                Mail.Send(model.Title, Config.CompanyEmail, text).Wait();
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}
