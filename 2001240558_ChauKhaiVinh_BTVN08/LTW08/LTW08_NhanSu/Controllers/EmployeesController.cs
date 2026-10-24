using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTW08_NhanSu.Models;

namespace LTW08_NhanSu.Controllers
{
    public class EmployeesController : Controller
    {
        private QL_NhanSuEntities1 db =new QL_NhanSuEntities1();

        // Lấy dữ liệu nhân viên từ database
        public ActionResult Index()
        {
            var DS_NhanVien=db.Employees.ToList();
            return View(DS_NhanVien);
        }

        // Trang thêm mới nhân viên
        // Hiển thị Form (GET)
        [HttpGet]
        public ActionResult Create()
        {
            // Tạo dropdown
            List<SelectListItem> genderList = new List<SelectListItem>
            {
                new SelectListItem{Text="Nam",Value="Nam"},
                new SelectListItem{Text="Nữ",Value="Nữ"},
            };
            ViewBag.Gender = new SelectList(genderList, "Value", "Text");
            ViewBag.DeptID=new SelectList(db.Deparments.ToList(), "ID", "DisplayName");
            return View(); 
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            List<SelectListItem> genderList = new List<SelectListItem>
            {
                new SelectListItem{Text="Nam",Value="Nam"},
                new SelectListItem{Text="Nữ",Value="Nữ"},
            };
            ViewBag.Gender = new SelectList(genderList, "Value", "Text",emp.Gender);
            ViewBag.DeptID = new SelectList(db.Deparments.ToList(), "ID", "DisplayName",emp.DeptID);
            return View(emp);
        }

        // GET - POST trang Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var emp = db.Employees.Find(id);
            if (emp == null) return HttpNotFound();

            List<SelectListItem> genderList = new List<SelectListItem>
            {
                new SelectListItem{Text="Nam",Value="Nam"},
                new SelectListItem{Text="Nữ",Value="Nữ"},
            };
            ViewBag.Gender = new SelectList(genderList, "Value", "Text", emp.Gender);
            ViewBag.DeptID = new SelectList(db.Deparments.ToList(), "ID", "DisplayName", emp.DeptID);

            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            List<SelectListItem> genderList = new List<SelectListItem>
            {
                new SelectListItem{Text="Nam",Value="Nam"},
                new SelectListItem{Text="Nữ",Value="Nữ"},
            };
            ViewBag.Gender = new SelectList(genderList, "Value", "Text", emp.Gender);
            ViewBag.DeptID = new SelectList(db.Deparments.ToList(), "ID", "DisplayName", emp.DeptID);

            return View(emp);
        }

        // Trang chi tiết
        public ActionResult Details(int id)
        {
            var emp = db.Employees.Find(id);
            if (emp == null) return HttpNotFound();
            return View(emp);
        }
        public ActionResult Delete(int id)
        {
            var emp = db.Employees.Find(id);
            if (emp == null) return HttpNotFound();
            return View(emp);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var emp = db.Employees.Find(id);
            db.Employees.Remove(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // 6. TRANG SIDEBAR HIỂN THỊ DANH SÁCH PHÒNG BAN VÀ LỌC NHÂN VIÊN
        public ActionResult SideBarDept()
        {
            var dsPhongBan = db.Deparments.ToList();
            return View(dsPhongBan);
        }

        // Lọc danh sách nhân viên theo mã phòng ban
        public ActionResult ShowEmplParameter(int id)
        {
            var phongBan = db.Deparments.Find(id);
            ViewBag.DisplayName = phongBan != null ? phongBan.DisplayName : "";

            // Lọc danh sách nhân viên thuộc DeptId
            var dsNhanVien = db.Employees.Where(e => e.DeptID == id).ToList();
            return View(dsNhanVien);
        }
    }
}
