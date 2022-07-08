using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(Admin ad)
        {
            var values = c.Admins.FirstOrDefault(x => x.Kullanici == ad.Kullanici && x.Sifre == ad.Sifre);
            if (values!=null)
            {
                FormsAuthentication.SetAuthCookie(values.Kullanici, false);
                Session["Kullanici"] = values.Kullanici.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
                return View();
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LogIn","LogIn");
        }
    }
}