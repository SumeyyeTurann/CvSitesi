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
    public class HobilerController : Controller
    {
        // GET: Hobiler
        DBMvcCvEntities db = new DBMvcCvEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger5 = db.tblInterests.ToList();
            return View(cs);
        }

        [HttpGet]
        public ActionResult YeniHobi()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniHobi(tblInterests  p)
        {
            db.tblInterests.Add(p);
            db.SaveChanges();
            return View(p);
        }

        public ActionResult Sil(int id)
        {
            var hobi = db.tblInterests.Find(id);
            db.tblInterests.Remove(hobi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult HobiGetir(int id)
        {
            var veri = db.tblInterests.Find(id);
            return View("HobiGetir", veri);
        }
        public ActionResult Guncelle(tblInterests p)
        {
            var veriler = db.tblInterests.Find(p.ID);
            veriler.Interest = p.Interest;         
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}