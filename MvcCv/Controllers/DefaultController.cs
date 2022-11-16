using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var degerler = db.tblHakkimda.ToList();
            return View(degerler);
        }
        public PartialViewResult SosyalMedya()
        {
            var sosyal = db.tblSosyalMedya.Where(x=>x.Durum==true).ToList();
            return PartialView(sosyal);
        }


        public PartialViewResult Deneyim()
        {
            var deneyimler = db.tblDeneyimlerim.ToList();
            return PartialView(deneyimler);
        }

        public PartialViewResult Egitimlerim()
        {
            var egitimler = db.tblEgitim.ToList();
            return PartialView(egitimler);
        }

        public PartialViewResult Yeteneklerim()
        {
            var yetenekler = db.tblYeteneklerim.ToList();
            return PartialView(yetenekler);
        }

        public PartialViewResult Hobilerim()
        {
            var hobiler = db.tblHobilerim.ToList();
            return PartialView(hobiler);
        }
        public PartialViewResult Sertifikalar()
        {
            var sertifikalar = db.tblSertifikalarim.ToList();
            return PartialView(sertifikalar);
        }

        [HttpGet]
        public PartialViewResult Iletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Iletisim(tblİletisim t)
        {
            t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.tblİletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}