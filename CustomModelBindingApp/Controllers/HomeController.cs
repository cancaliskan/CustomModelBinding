using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

            return View(users.ToList());
        }

        [HttpPost]
        public IActionResult Index([ModelBinder(BinderType = typeof(CustomModelBinder))]string model)
        {
            //return View();
            return Json(model);
        }
    }
}
