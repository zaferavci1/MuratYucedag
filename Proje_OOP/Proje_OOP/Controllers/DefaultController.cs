using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Örnekler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje_OOP.Controllers
{
    public class DefaultController : Controller
    {
        //void islemler()
        //{
        //    Class1 c1 = new Class1();
        //    c1.Topla();
        //}

        void mesajlar()
        {
            ViewBag.m1 = "Merhaab bu bir core projesi";
            ViewBag.m2 = "Proje cok iyi duruyor";
            ViewBag.m3 = "Selamlar hi hello bonjour ";
        }

        public IActionResult Index()
        {
            mesajlar();
            MesajListesi("merhabalar 11.06.2022");
            kullanıcı("Zafer avci");
            ViewBag.T = Topla(89, 56);
            return View();
        }

        int topla()
        {
            int s1 = 5, s2 = 41, topla;
            return topla = s1 + s2;
        }
        string cumle()
        {
            string c = "Kçük hanımlar küçük beyler sizler hepiniz geleceğin birer gülü " +
                "parlayan yıldızısınız";
            return c;
        }
        void MesajListesi(string p)
        {
            ViewBag.v = p;
        }

        void kullanıcı(string kullaniciAdi)
        {
            ViewBag.k = kullaniciAdi;
        }
        int Topla(int s1,int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }
       
        public IActionResult Urunler()
        {
            mesajlar();
            ViewBag.t = topla();
            kullanıcı("Avci");
            return View();
        }
        public IActionResult Musteriler()
        {
            ViewBag.d = cumle();
            kullanıcı("zafer avci 004");
            return View();
        }
        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler();

            sehirler.Ad = "Hatay";
            sehirler.Id = 31;
            sehirler.Nufus = 15000000;
            sehirler.Ulke = "Turkiye";
            sehirler.Renk1="Kırmızı ";
            sehirler.Renk2 = "Beyaz";

            ViewBag.ad = sehirler.Ad;
            ViewBag.id = sehirler.Id;
            ViewBag.nufus = sehirler.Nufus;
            ViewBag.ulke = sehirler.Ulke;
            ViewBag.r1 = sehirler.Renk1;
            ViewBag.r2 = sehirler.Renk2;

            sehirler.Id = 34;
            sehirler.Ad = "Istanbul";
            sehirler.Nufus = 1065468;
            sehirler.Ulke = "İtalya";
            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Beyaz";
            sehirler.Renk3 = "Yeşil";
            ViewBag.v1 = sehirler.Ad;
            ViewBag.v2 = sehirler.Id;
            ViewBag.v3 = sehirler.Ulke;
            ViewBag.v4 = sehirler.Nufus;
            ViewBag.v5 = sehirler.Renk1;
            ViewBag.v6 = sehirler.Renk2;
            ViewBag.v7 = sehirler.Renk3;

            return View();
        }
    }
}
