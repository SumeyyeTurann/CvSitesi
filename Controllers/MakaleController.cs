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
    public class MakaleController : Controller
    {
        // GET: Makale
        DBMvcCvEntities db = new DBMvcCvEntities();
        public ActionResult Index(string p)
        {
            var degerler = from d in db.tblArticles select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.Article.Contains(p));
            }
            return View(degerler.ToList());
        }

        [HttpGet]
        public ActionResult YeniMakale()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniMakale(tblArticles p)
        {
            db.tblArticles.Add(p);
            db.SaveChanges();
            return View(p);
        }

        public ActionResult Sil(int id)
        {
            var makale = db.tblArticles.Find(id);
            db.tblArticles.Remove(makale);
            db.SaveChanges(); 
            return RedirectToAction("Index");
        }

        public ActionResult MakaleGetir(int id)
        {
            var veri = db.tblArticles.Find(id);
            return View("MakaleGetir   ", veri);
        }
        public ActionResult Guncelle(tblArticles p)
        {
            var veriler = db.tblArticles.Find(p.ID);
            veriler.Article = p.Article;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}