using System;
using System.Collections.Generic;
using System.Linq;
using TravelTripProject.Models.Sınıflar;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace TravelTripProject.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap

        Context c = new Context();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin sa)
        {
            var bilgiler=c.Admins.FirstOrDefault(x=>x.User==sa.User && x.Password==sa.Password);
            if (bilgiler!=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.User,false);
                Session["User"]=bilgiler.User.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "GirisYap");
        }
    }
}