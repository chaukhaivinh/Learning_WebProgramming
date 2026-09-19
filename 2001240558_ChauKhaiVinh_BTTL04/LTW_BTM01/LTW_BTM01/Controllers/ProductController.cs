using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTW04_BTM01.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ViewBag.SoLuongGioHang = 3; // Giả lập có 3 sản phẩm trong giỏ
            var products = new List<string>
                { "Áo thun", "Giày sneaker", "Balo" };
            return View(products);
        }
        public ActionResult _CartSummary()
        {
            ViewBag.SoLuongGioHang = 3; // Giả lập có 3 sản phẩm trong giỏ
            return PartialView();
        }
    }
}