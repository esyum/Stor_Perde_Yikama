using Stor_Perde_Yikama.Context;
using Stor_Perde_Yikama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stor_Perde_Yikama.Controllers
{
    public class AdminController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MySlayder()
        {
            List<Slayder> _slayder = db.slayder.ToList();
            return View(_slayder);
        }

    }
}
