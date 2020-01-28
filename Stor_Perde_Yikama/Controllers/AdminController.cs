﻿using Stor_Perde_Yikama.Context;
using Stor_Perde_Yikama.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
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
            List<Slayder> _slayder = db.slayder.OrderByDescending(x=>x.OlusturmaTarihi).ToList();
            return View(_slayder);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Slayder s, HttpPostedFileBase file)
        {
            try
            {
                Slayder _slayder = new Slayder();
                if (file != null && file.ContentLength > 0)
                {
                    MemoryStream memoryStream = file.InputStream as MemoryStream;
                    if (memoryStream == null)
                    {
                        memoryStream = new MemoryStream();
                        file.InputStream.CopyTo(memoryStream);
                    }
                    _slayder.SliderFoto = memoryStream.ToArray();

                    _slayder.SliderText = s.SliderText;
                    _slayder.SliderSubText = s.SliderSubText;
                    _slayder.OlusturmaTarihi = DateTime.Now;
                    db.slayder.Add(_slayder);
                    db.SaveChanges();

                    return RedirectToAction("MySlayder", "Admin");

                }

                return View(s);

            }
            catch (Exception)
            {

                throw new Exception("Hata oluştu");
            }
        }


        // GET: Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Slayder _slayder = db.slayder.Find(id);
            if (_slayder == null)
            {
                return HttpNotFound();
            }
            return View(_slayder);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Slayder s, HttpPostedFileBase file)
        {
            try
            {
                Slayder _slayder = new Slayder();
                if (file != null && file.ContentLength > 0)
                {
                    MemoryStream memoryStream = file.InputStream as MemoryStream;
                    if (memoryStream == null)
                    {
                        memoryStream = new MemoryStream();
                        file.InputStream.CopyTo(memoryStream);
                    }
                    _slayder.SliderFoto = memoryStream.ToArray();
                }

                _slayder.ID = s.ID;
                _slayder.SliderText = s.SliderText;
                _slayder.SliderSubText = s.SliderSubText;
                _slayder.OlusturmaTarihi = DateTime.Now;

                db.Entry(_slayder).State = EntityState.Modified;
                
                if (file == null)
                    db.Entry(_slayder).Property(m => m.SliderFoto).IsModified = false;
                db.SaveChanges();


                return RedirectToAction("MySlayder", "Admin");
            }
            catch (Exception)
            {

                throw new Exception("Hata oluştu");
            }
            //if (ModelState.IsValid)
            //{
            //    db.Entry(_slayder).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("MySlayder");
            //}
            //return View(_slayder);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Slayder _slayder = db.slayder.Find(id);
            if (_slayder == null)
            {
                return HttpNotFound();
            }
            return View(_slayder);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Slayder _slayder = db.slayder.Find(id);
            db.slayder.Remove(_slayder);
            db.SaveChanges();
            return RedirectToAction("MySlayder");
        }

        public ActionResult MyGalery()
        {
            List<Galery> _galery = db.galery.OrderByDescending(x => x.OlusturmaTarihi).ToList();
            return View(_galery);
        }

        // GET: Admin/Create
        public ActionResult Galery_Create()
        {
            return View();
        }

        

        // POST: Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Galery_Create(Galery s, HttpPostedFileBase file)
        {
            try
            {
                Galery _galery = new Galery();
                if (file != null && file.ContentLength > 0)
                {
                    MemoryStream memoryStream = file.InputStream as MemoryStream;
                    if (memoryStream == null)
                    {
                        memoryStream = new MemoryStream();
                        file.InputStream.CopyTo(memoryStream);
                    }
                    _galery.galery_pic = memoryStream.ToArray();

                    _galery.baslik = s.baslik;
                    _galery.alt_baslik = s.alt_baslik;
                    _galery.filter_name = s.filter_name;
                    _galery.title = s.title;
                    _galery.OlusturmaTarihi = DateTime.Now;

                    db.galery.Add(_galery);
                    db.SaveChanges();

                    return RedirectToAction("MyGalery", "Admin");

                }

                return View(s);

            }
            catch (Exception)
            {

                throw new Exception("Hata oluştu");
            }
        }


    }
}
