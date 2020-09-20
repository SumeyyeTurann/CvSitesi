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
    public class EgitimController : Controller
    {
        DBMvcCvEntities db = new DBMvcCvEntities();
        // GET: Egitim
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger3 = db.tblEducatıon.ToList();
            return View(cs);
        }

        [HttpGet]
        public ActionResult YeniEgitim()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniEgitim(tblEducatıon p)
        {
            db.tblEducatıon.Add(p);
            db.SaveChanges();
            return View();
        }

        public ActionResult Sil(int id)
        {
            var egitim = db.tblEducatıon.Find(id);
            db.tblEducatıon.Remove(egitim);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult EgitimGetir(int id)
        {
            var veri = db.tblEducatıon.Find(id);
            return View("EgitimGetir", veri);
        }
        public ActionResult Guncelle(tblEducatıon p)
        {
            var veriler = db.tblEducatıon.Find(p.ID);
            veriler.Title = p.Title;
            veriler.Subtıtle = p.Subtıtle;
            veriler.Department = p.Department;
            veriler.GPA = p.GPA;           
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}