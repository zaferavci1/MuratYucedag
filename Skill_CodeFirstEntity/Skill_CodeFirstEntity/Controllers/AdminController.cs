using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Skill_CodeFirstEntity.Models.Sınıflar;

namespace Skill_CodeFirstEntity.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.YETENEKLERS.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniYetenek(Yetenekler y)
        {
            c.YETENEKLERS.Add(y);
            c.SaveChanges();
            return View();
        }
        public ActionResult YetenekSil(int id)
        {
            var values = c.YETENEKLERS.Find(id);
            c.YETENEKLERS.Remove(values);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekGetir(int id)
        {
            var values = c.YETENEKLERS.Find(id);
            return View("YetenekGetir", values);
        }
        [HttpPost]
        public ActionResult YetenekGetir(Yetenekler y)
        {
            var values = c.YETENEKLERS.Find(y.Id);
            values.Aciklama = y.Aciklama;
            values.Deger = y.Deger;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}