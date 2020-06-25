using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SessionsLesson.Models;

namespace SessionsLesson.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
       [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            ProductModel productModel = new ProductModel();
            ViewBag.products = productModel.findAll();
            return View();
        }
    }
}