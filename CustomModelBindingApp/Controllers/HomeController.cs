using System;
using System.Collections.Generic;
using CustomModelBindingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomModelBindingApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<UserModel> users = new UserModel[3]
            {
                   new UserModel("Can","Karşıyaka"),
                   new UserModel("Serdar","Urla"),
                   new UserModel("Yakup","Torbalı")
            };

            return View(users);
        }

        [HttpPost]
        public IActionResult Index([ModelBinder(BinderType = typeof(CustomModelBinder))]IEnumerable<UserModel> model)
        {
            //return View();
            return Json(model);
        }
    }
}
