using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTW09_BT1.Models;

namespace LTW09_BT1.Controllers
{
    public class BooksController : Controller
    {
        private QL_BanSachEntities db = new QL_BanSachEntities();

        public ActionResult DSMenu_ChuDe()
        {
            List<ChuDe> dsCD = db.ChuDes.Take(10).ToList();
            return PartialView(dsCD);
        }

        public ActionResult DSMenu_NXB()
        {
            List<NhaXuatBan> dsNXB = db.NhaXuatBans.Take(10).ToList();
            return PartialView(dsNXB);
        }
        public ActionResult Index()
        {
            List<Sach> dsSach = db.Saches.OrderByDescending(s => s.NgayCapNhat).Take(5).ToList();
            return View(dsSach);
        }
        public ActionResult XemChiTiet(int id)
        {
            Sach sach = db.Saches.SingleOrDefault(s => s.MaSach == id);
            if (sach == null)
            {
                Response.StatusCode = 404;
                return HttpNotFound("Sách không tồn tại!");
            }

            // Sản phẩm cùng chủ đề (trừ cuốn hiện tại)
            ViewBag.CungChuDe = db.Saches.Where(s => s.MaChuDe == sach.MaChuDe && s.MaSach != id).Take(4).ToList();

            // Sản phẩm cùng nhà xuất bản (trừ cuốn hiện tại)
            ViewBag.CungNXB = db.Saches.Where(s => s.MaNXB == sach.MaNXB && s.MaSach != id).Take(4).ToList();

            return View(sach);
        }
        public ActionResult SachTheoCD(int? maCD)
        {
            ChuDe cd = db.ChuDes.SingleOrDefault(c => c.MaChuDe == maCD);
            if (cd == null)
            {
                Response.StatusCode = 404;
                return HttpNotFound("Không tìm thấy chủ đề!");
            }

            List<Sach> dsSach = db.Saches.Where(s => s.MaChuDe == maCD).ToList();
            ViewBag.TenChuDe = cd.TenChuDe;
            return View(dsSach);
        }
        public ActionResult SachTheoNXB(int? maNXB)
        {
            NhaXuatBan nxb = db.NhaXuatBans.SingleOrDefault(n => n.MaNXB == maNXB);
            if (nxb == null)
            {
                Response.StatusCode = 404;
                return HttpNotFound("Không tìm thấy nhà xuất bản!");
            }

            List<Sach> dsSach = db.Saches
                                    .Where(s => s.MaNXB == maNXB)
                                    .OrderBy(s => s.GiaBan)
                                    .ToList();

            ViewBag.TenNXB = nxb.TenNXB;
            return View(dsSach);
        }
    }
}
