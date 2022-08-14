using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Skill_CodeFirstEntity.Models.Sınıflar;

namespace Skill_CodeFirstEntity.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Context c= new Context();
            var values = c.YETENEKLERS.ToList();
            return View(values);
        }

        //index genelde listeleme yapılır
        //action bir dönüş tipi
    }
}