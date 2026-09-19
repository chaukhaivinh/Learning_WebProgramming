using LTW05_BTM1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTW05_BTM1.Controllers
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
        Data csdl = new Data();
        public ActionResult HienThiThongTin()
        {
            List<Employee> ds = csdl.DS_NhanVien;
            return View(ds);
        }
    }
}