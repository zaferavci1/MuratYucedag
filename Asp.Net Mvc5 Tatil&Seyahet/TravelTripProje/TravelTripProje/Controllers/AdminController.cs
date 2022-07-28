using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        [HttpGet]//Sayfa yüklenmesi sirasında gösterilecek ekran
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var b = c.Blogs.Find(id);
            return View("BlogGetir", b);
        }
        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Tarih = b.Tarih;
            blg.BlogImage = b.BlogImage;
            blg.Baslik = b.Baslik;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var values = c.Yorumlars.ToList();
            return View(values);
        }
        public ActionResult YorumSil(int id)
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yorum = c.Yorumlars.Find(id);
            return View("YorumGetir", yorum);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = c.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult Iletisim()
        {
            var values = c.Iletisims.ToList();
            return View(values);
        }
        public ActionResult MesajSil(int id)
        {
            var b = c.Iletisims.Find(id);
            c.Iletisims.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Iletisim");
        }
        public ActionResult HakkimizdaListele()
        {
            var values = c.Hakkimizdas.ToList();
            return View(values); 
        }
        public ActionResult HakkimizdaGetir(int id)
        {
            var b = c.Blogs.Find(id);
            return View("HakkimizdaGetir", b);
        }
        public ActionResult HakkimizdaGuncelle(Hakkimizda b)
        {
            var blg = c.Hakkimizdas.Find(b.ID);
            blg.FotoUrl = b.FotoUrl;
            blg.Aciklama = b.Aciklama;
            c.SaveChanges();
            return RedirectToAction("HakkimizdaListele");
        }
    }
}