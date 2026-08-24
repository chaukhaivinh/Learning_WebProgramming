using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTW02_BaiMau.Models;

namespace LTW02_BaiMau.Controllers
{
    public class PhongBanController : Controller
    {
        // GET: PhongBan
        public ActionResult Phong()
        {
            PhongBanViewModel model = new PhongBanViewModel();
            return View(model);
        }
    }
}