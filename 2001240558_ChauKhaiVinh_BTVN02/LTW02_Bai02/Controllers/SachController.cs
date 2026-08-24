using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTW02_Bai02.Models;

namespace LTW02_Bai02.Controllers
{
    public class SachController : Controller
    {
        // GET: Sach
        public ActionResult CuaHangSach()
        {
            SachViewModel model = new SachViewModel();
            return View(model);
        }
        public ActionResult ChiTietSach(int ID)
        {
            LTW02_Bai02.Models.SachViewModel KhoSach=new LTW02_Bai02.Models.SachViewModel();
            var ChiTiet=KhoSach.DS_Sach.FirstOrDefault(x => x.ID==ID);
            return View(ChiTiet);
        }
    }
}