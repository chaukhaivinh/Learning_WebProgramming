using LTW05_BTTL3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTW05_BTTL3.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        Data data = new Data();
        public ActionResult DSLoai()
        {
            List<ProductType> DS_Loai= data.GetDSLoai();
            return View(DS_Loai);
        }
        public ActionResult DSSanPham(int _TypeID=0)
        {
            List<Product> DS_SP = data.GetDSSanPham(_TypeID);
            return View(DS_SP);
        }
        public ActionResult SanPhamByLoai(int _TypeID=0)
        {
            ViewBag.DSLoai = data.GetDSLoai();
            List<Product> DS_SP = data.GetDSSanPham(_TypeID);
            return View(DS_SP); 
        }
        public ActionResult TimKiem(string kw)
        {
            
            ViewBag.TuKhoa= kw;
            List<Product> DS_SPTK = data.TimKiemTheoTen(kw);
            return View(DS_SPTK);
        }
        public ActionResult LocTheoDropdown(int _TypeID)
        {
            List<ProductType> DS_Loai = data.GetDSLoai();
            ViewBag.MaLoai = new SelectList(DS_Loai, "ID", "DisplayName",_TypeID);
            List<Product> DS_SP = data.GetDSSanPham(_TypeID);
            return View(DS_SP);
        }
    }
}