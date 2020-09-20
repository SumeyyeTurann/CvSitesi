using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogCV.Models.Sınıf;
using BlogCV.Models.Entity;

namespace BlogCV.Controllers
{
    [Authorize]
    public class DeneyimlerController : Controller
    {
        // GET: Deneyimler
        DBMvcCvEntities db = new DBMvcCvEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger2 = db.tblExperıence.ToList();
            return View(cs);
        }


        [HttpGet]
        public ActionResult YeniDeneyim()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniDeneyim(tblExperıence p)
        {
            db.tblExperıence.Add(p);
            db.SaveChanges();
            return View();
        }

       
        public ActionResult DeneyimSil(int id)
        {
            var deneyim = db.tblExperıence.Find(id);
            db.tblExperıence.Remove(deneyim);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeneyimGetir(int id)
        {
            var veri = db.tblExperıence.Find(id);
            return View("DeneyimGetir", veri);
        }
        public ActionResult Guncelle(tblExperıence p)
        {
            var veriler = db.tblExperıence.Find(p.ID);
            veriler.Title = p.Title;
            veriler.Subtitle = p.Subtitle;
            veriler.Details = p.Details;
            veriler.Date = p.Date;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}