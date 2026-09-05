using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTW03_BTM2.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc) 
        {
            string username = fc["User"];
            string password = fc["Pass"];
            ViewBag.Message = $"Chào bạn: {username} ♥";
            return View();
        }
    }
}