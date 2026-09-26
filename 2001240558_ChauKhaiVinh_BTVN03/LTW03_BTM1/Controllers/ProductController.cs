using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTW03_BTM1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Search()
        {

            return View();
        }
        public ActionResult ResultName(string Name)
        {
            ViewBag.Message = "Tên sản phẩm: " + Name;
            return View();
        }
    }
}