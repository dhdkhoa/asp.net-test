using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCLayout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Greeting = "Hello World";
            ViewBag.Product = new ProductModel()
            {
                Id = 1,
                Name = "Đăng Khoa",
                Brand = "Đinh",
                Price = 100000
            };
            return View();
        }
    }
}
