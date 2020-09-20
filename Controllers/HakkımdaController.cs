using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogCV.Controllers;
using BlogCV.Models.Entity;
using BlogCV.Models.Sınıf;


namespace BlogCV.Controllers
{
    [Authorize]
    public class HakkımdaController : Controller
    {
        // GET: Hakkımda
        DBMvcCvEntities db = new DBMvcCvEntities(); 
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger1 = db.tblAbout.ToList();
            return View(cs);
        }

        public ActionResult VeriGetir(int id)
        {
            var veriler = db.tblAbout.Find(id);
            return View("VeriGetir", veriler);
        }

        public ActionResult Guncelle(tblAbout p)
        {
            var degerler = db.tblAbout.Find(p.ID);
            degerler.Name = p.Name;
            degerler.Surname = p.Surname;
            degerler.Phone = p.Phone;
            degerler.Address = p.Address;
            degerler.Image = p.Image;
            degerler.Maıl = p.Maıl;
            degerler.Type = p.Type;
            degerler.About = p.About;

            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}