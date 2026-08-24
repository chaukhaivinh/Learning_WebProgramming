using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTW02_Bai03.Models;

namespace LTW02_Bai03.Controllers
{
    public class SachController : Controller
    {
        // GET: Sach
        public ActionResult DanhSach()
        {
            SachViewModel Data = new SachViewModel();
            ViewBag.DS_Loai = Data._DS_Loai;
            return View(Data._DS_Sach);
        }
    }
}