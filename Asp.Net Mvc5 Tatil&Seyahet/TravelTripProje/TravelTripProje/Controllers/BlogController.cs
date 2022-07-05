using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        public ActionResult Index()
        {
            var bloglar = c.Blogs.ToList();
            return View(bloglar);
        }
        BlogYorum blogYorum = new BlogYorum();
        public ActionResult BlogDetay(int id)
        {
            //var blogBul = c.Blogs.Where(x => x.ID == id).ToList();
            blogYorum.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            blogYorum.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(blogYorum);
        }
    }
}