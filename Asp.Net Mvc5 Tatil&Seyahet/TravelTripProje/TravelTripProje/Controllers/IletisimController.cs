using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult Iletisims()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Iletisims(iletisim y)
        {
            c.Iletisims.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}