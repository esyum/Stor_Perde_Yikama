using Stor_Perde_Yikama.Context;
using Stor_Perde_Yikama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stor_Perde_Yikama.Controllers
{
    public class HomeController : Controller
    {
        DatabaseContext db = new DatabaseContext();

        public ActionResult Index()
        {
            AnaSayfaDTO obj = new AnaSayfaDTO();
            obj.DTO_slider = db.slayder.OrderByDescending(x => x.OlusturmaTarihi).ToList();
            obj.DTO_galery = db.galery.OrderByDescending(x => x.OlusturmaTarihi).ToList();
            //List<Slayder> slayt = db.slayder.ToList();
            return View(obj);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

