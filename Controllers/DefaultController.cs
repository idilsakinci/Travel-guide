using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Turkiyenin81Yuzu.Models.Entity;
using Turkiyenin81Yuzu.Models.Siniflar;
using PagedList;
using PagedList.Mvc;

namespace Turkiyenin81Yuzu.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        SehirlerEntities c = new SehirlerEntities();
        public ActionResult Index()
        {
            var degerler = c.Kategoriler.ToList();
            return View(degerler);
        }
        public ActionResult Iletisim()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.SehirBilgi.Where(x => x.SehirId == 7 || x.SehirId == 8).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var degerler = c.SehirBilgi.Where(x => x.SehirId == 19).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial3()
        {
            var degerler = c.SehirBilgi.Where(x => x.SehirId == 32 || x.SehirId == 40).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial4()
        {
            var degerler = c.SehirBilgi.Where(x => x.SehirId == 41).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial5()
        {
            var degerler = c.SehirBilgi.Where(x => x.SehirId == 57 || x.SehirId == 59).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial6()
        {
            var degerler = c.SehirBilgi.Where(x => x.SehirId == 61).ToList();
            return PartialView(degerler);
        }
        public ActionResult SehirlerListe(int id, int sayfa=1)
        {
            var degerler = c.SehirBilgi.Where(x => x.KategoriId1 == id || x.KategoriId2 == id).ToList().ToPagedList(sayfa,10);        
            return View(degerler);
        }
        public ActionResult PopulerSehirlerListe()
        {
            var degerler = c.SehirBilgi.Where(x => x.SehirId == 7 || x.SehirId == 8 || x.SehirId == 19 || 
            x.SehirId == 32 || x.SehirId == 40 || x.SehirId == 41 || x.SehirId == 57 || x.SehirId == 59 || 
            x.SehirId == 61).ToList();
            return PartialView(degerler);
        }

    }
}