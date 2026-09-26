using LTW04_BTTL3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTW04_BTTL3.Controllers
{
    public class HomeController : Controller
    {
        private Data db = new Data();
        public ActionResult Index()
        {
            return View();
        }
        
        
        public ActionResult MonAn()
        {

            return View(db.Products);
        }

        // 3. Action riêng để vẽ thanh danh mục màu xanh lá (Truyền List<Category>)
        [ChildActionOnly]
        public ActionResult _CategoryMenu()
        {
            return PartialView(db.Categories);
        }
    }
}