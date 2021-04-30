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
    public class SehirDetayController : Controller
    {
        SehirlerEntities shr = new SehirlerEntities();
        public ActionResult Index(int sayfa=1)
        {     
            var sehirler = shr.SehirBilgi.ToList().ToPagedList(sayfa, 10); 
            return View(sehirler);
        }
        public ActionResult SehirDetay(int id)
        {
            var sehirbul = shr.SehirBilgi.Where(x => x.SehirId == id).ToList();
            return View(sehirbul);
        }
    }
}