using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AJAXTest01.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AJAXTest01.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HelloAjax()
        {
            return Content("Hello Ajax", "text/plain");
        }

        public IActionResult Sum(int a, int b)
        {
            return Content((a+ b).ToString(), "text/plain");
        }

        public IActionResult DisplayObject()
        {
            Product p1 = new Product("pr1", "Name 1", 1000);
            return Json(p1);
        }

        public IActionResult DisplayListObject()
        {
            List<Product> listProduct = new List<Product>();
            listProduct.Add(new Product("pr1", "Name 1", 1000));
            listProduct.Add(new Product("pr2", "Name 2", 2000));
            listProduct.Add(new Product("pr3", "Name 3", 3000));
            return Json(listProduct);
        }
    }
}
