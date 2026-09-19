using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTW04_BTM01.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult CartIndex()
        {
            return View();
        }
    }
}