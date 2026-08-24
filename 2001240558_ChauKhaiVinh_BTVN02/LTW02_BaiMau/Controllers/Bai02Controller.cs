using LTW02_BaiMau.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTW02_BaiMau.Controllers
{
    public class Bai02Controller : Controller
    {
        // GET: Bai02
        public ActionResult Employee()
        {
            var e=new Employee();
            ViewData["e"] = e;
            return View();
        }
    }
}