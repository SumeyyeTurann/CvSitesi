using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogCV.Models.Sınıf;
using BlogCV.Models.Entity;
using PagedList;
using PagedList.Mvc;

namespace BlogCV.Controllers
{
    [Authorize]
    public class YeteneklerController : Controller
    {
        // GET: Yetenekler
        DBMvcCvEntities db = new DBMvcCvEntities();
        public ActionResult Index(int sayfa=1)
        {
            //Class1 cs = new Class1();
            var degerler = db.tblSkılls.ToList().ToPagedList(sayfa, 5);
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniYetenek(tblSkılls p)
        {
            db.tblSkılls.Add(p);
            db.SaveChanges();
            return View(p);
        }

        public ActionResult Sil(int id)
        {
            var yetenek = db.tblSkılls.Find(id);
            db.tblSkılls.Remove(yetenek);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YetenekGetir(int id)
        {
            var veri = db.tblSkılls.Find(id);
            return View("YetenekGetir", veri);
        }
        public ActionResult Guncelle(tblSkılls p)
        {
            var veriler = db.tblSkılls.Find(p.ID);
            veriler.Skıll = p.Skıll;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}