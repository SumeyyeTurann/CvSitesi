using BlogCV.Models.Entity;
using BlogCV.Models.Sınıf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BlogCV.Controllers
{
    
    public class LoginController : Controller
    {
        // GET: Login
        DBMvcCvEntities db = new DBMvcCvEntities();
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(tblAbout p)
        {
            var giris = db.tblAbout.FirstOrDefault(x => x.Maıl == p.Maıl && x.Password == p.Password);
            if (giris != null)
            {
                FormsAuthentication.SetAuthCookie(giris.Maıl, false);
                Session["Mail"] = giris.Maıl.ToString();

                //TempData["Ad"] = giris.Ad.ToString();


                if (giris.Maıl == "admin@mail.com")
                {
                    return RedirectToAction("Index", "Hakkımda");
                }
                return RedirectToAction("Index", "Default");
            }
            else
            {
                return View();
            }

        }
    }
}