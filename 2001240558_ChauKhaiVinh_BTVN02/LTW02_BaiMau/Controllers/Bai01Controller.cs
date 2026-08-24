using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTW02_BaiMau.Controllers
{
    public class Bai01Controller : Controller
    {
        // GET: Bai01
        public ActionResult Mau01()
        {
            List<string> DanhSach=new List<string>();
            DanhSach.Add("Châu Khải Vinh");
            DanhSach.Add("La Quang Vinh");
            DanhSach.Add("Ngô Thuận Văn");
            DanhSach.Add("Nguyễn Hữu Lộc");
            DanhSach.Add("Phạm Hữu Vinh");

            ViewBag.DuLieu=DanhSach;
            return View();
        }
    }
}