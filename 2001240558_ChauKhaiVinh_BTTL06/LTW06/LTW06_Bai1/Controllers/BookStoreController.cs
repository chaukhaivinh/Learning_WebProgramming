using LTW06_Bai1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTW06_Bai1.Controllers
{
    public class BookStoreController : Controller
    {
        BookStoreData data = new BookStoreData();

        // Thêm [ChildActionOnly] để Action này chỉ được gọi từ Layout, không bị truy cập trực tiếp bằng URL
        [ChildActionOnly]
        public ActionResult DSLoai()
        {
            List<ProductType> list = data.GetListType();
            return PartialView(list);
        }

        public ActionResult DSSP(int? _TypeID = null)
        {
            List<Product> list = data.GetListProduct(_TypeID);
            return View(list);
        }

        public ActionResult ChiTiet(int _ID)
        {
            Product sp = data.GetProductByID(_ID);
            if (sp == null) return HttpNotFound();
            return View(sp);
        }

        public ActionResult TimKiem(string kw = "", double? PriceRange1 = null, double? PriceRange2 = null)
        {
            ViewBag.KW = kw;
            ViewBag.GiaTu = PriceRange1;
            ViewBag.GiaDen = PriceRange2;

            List<Product> listResult = data.AdvancedSeach(kw, PriceRange1, PriceRange2);
            return View(listResult);
        }
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangNhap(string sdt, string matKhau)
        {
            Customer kh = data.CheckLogin(sdt, matKhau);
            if (kh != null)
            {
                Session["User"] = kh;
                return RedirectToAction("DSSP");
            }

            ViewBag.ThongBao = "Số điện thoại hoặc mật khẩu không chính xác!";
            return View();
        }

        public ActionResult DangXuat()
        {
            Session["User"] = null;
            return RedirectToAction("DSSP");
        }
    }
}