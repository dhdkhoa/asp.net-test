using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCoreForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreForm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            var model = new ProductEditModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(ProductEditModel model)
        {
            string massage = string.Empty;
            if (ModelState.IsValid)
            {
                massage = "Product: " + model.Name + ". Rate: " + model.Rate + ". Rating: " + model.Rating +
                          " created successfully";
            }
            else
            {
                massage = "Fail to create the product. Please try again.";
            }
            return Content(massage);
        }
    }
}
