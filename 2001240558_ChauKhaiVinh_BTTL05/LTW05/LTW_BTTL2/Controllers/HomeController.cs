using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTW_BTTL2.Models;
using LTW05_BTTL2.Models;
using Microsoft.Ajax.Utilities;

namespace LTW_BTTL2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        Data csdl=new Data();
        public ActionResult HienThiPhongBan() 
        {
            List<PhongBan> list = csdl.DS_PhongBan;
            return View(list);
        }
    }
}