using LTW3_BTM3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTW3_BTM3.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Product sp)
        {

            ViewBag.Message = $"Tên món: {sp.Name} | Giá: {sp.Price}";
            return View();
        } 
        
    }
}