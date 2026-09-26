using LTW03_BTTL5.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTW03_BTTL5.Controllers
{
    public class SachController : Controller
    {
        [HttpGet]
        public ActionResult NhapSach()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NhapSach(int maSach, string tenSach, decimal gia, HttpPostedFileBase fileAnhBia)
        {
            string fileName = "";
            if (fileAnhBia != null && fileAnhBia.ContentLength > 0)
            {
                fileName = Path.GetFileName(fileAnhBia.FileName);
                string folderPath = Server.MapPath("~/Image/");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string path = Path.Combine(folderPath, fileName);
                fileAnhBia.SaveAs(path);
            }

            Sach sach = new Sach(maSach, tenSach, gia, fileName);
            return View("XacNhanNhapSach", sach);
        }
    }
}