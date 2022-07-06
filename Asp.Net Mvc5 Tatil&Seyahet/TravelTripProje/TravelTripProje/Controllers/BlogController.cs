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
        BlogYorum blogYorum = new BlogYorum();
        public ActionResult Index()
        {
            // var bloglar = c.Blogs.ToList();
            blogYorum.Deger1 = c.Blogs.ToList();
            blogYorum.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            //2 blog alsın demek
            return View(blogYorum);
        }
       
        public ActionResult BlogDetay(int id)
        {
            //var blogBul = c.Blogs.Where(x => x.ID == id).ToList();
            blogYorum.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            blogYorum.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(blogYorum);
        }
    }
}