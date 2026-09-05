using LTW03_BTTL4.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTW03_BTTL4.Controllers
{
    public class RegistController : Controller
    {
        [HttpGet]
        public ActionResult RegisterForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterForm(Infomation info, HttpPostedFileBase fileUpload)
        {
            if (fileUpload != null && fileUpload.ContentLength > 0)
            {
                var filename = Path.GetFileName(fileUpload.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Images/"), filename);

                var dir = new DirectoryInfo(Server.MapPath("~/Content/Images/"));
                if (!dir.Exists) dir.Create();

                fileUpload.SaveAs(path);
                info.FileImage = filename; 
            }
            else
            {
                info.FileImage = "default.png"; 
            }

            Session["ThongTinDangKy"] = info;

            return RedirectToAction("MHXacNhan");
        }

        [HttpGet]
        public ActionResult MHXacNhan()
        {
            // Lấy thông tin từ Session ra [7]
            var info = Session["ThongTinDangKy"] as Infomation;
            if (info == null)
            {
                return RedirectToAction("Index");
            }
            return View(info);
        }
    }
}