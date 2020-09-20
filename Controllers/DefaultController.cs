using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogCV.Models.Entity;
using BlogCV.Models.Sınıf;

namespace BlogCV.Controllers
{
    [Authorize]
    public class DefaultController : Controller
    {
        // GET: Default
        DBMvcCvEntities db = new DBMvcCvEntities();
        public ActionResult Index()
        {
            //Class1 cs = new Class1();
            //cs.Deger1 = db.tblAbout.ToList();
            //cs.Deger2 = db.tblExperıence.ToList();
            //cs.Deger3 = db.tblEducatıon.ToList();
            //cs.Deger4 = db.tblSkılls.ToList();
            //cs.Deger5 = db.tblInterests.ToList();
            //cs.Deger6 = db.tblArticles.ToList();

            //return View(cs);
            var aktifkullanıcı = (string)Session["Mail"];
            var üyedegeri = db.tblAbout.FirstOrDefault(x => x.Maıl == aktifkullanıcı);
            return View(üyedegeri);
        }
        public ActionResult Action()
        {
            var aktifkullanıcı = (string)Session["Mail"];
            var üyedegeri = db.tblAbout.FirstOrDefault(x => x.Maıl == aktifkullanıcı);
            return View(üyedegeri);
        }
    }
}