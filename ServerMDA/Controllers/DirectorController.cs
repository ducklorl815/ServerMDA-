﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ServerMDA.Models;
using ServerMDA.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.Controllers
{
    public class DirectorController : Controller
    {
        private IWebHostEnvironment _enviro;

        public DirectorController(IWebHostEnvironment p)
        {
            _enviro = p;
        }
        public IActionResult List(CKeyWordViewModel model)
        {
             MDAContext db = new MDAContext();
            IEnumerable<導演總表director> datas = null;
            if (string.IsNullOrEmpty(model.txtkeyword))
                datas = from p in db.導演總表directors
                        select p;
            else
                datas = db.導演總表directors.Where(p => p.中文名字nameCht.Contains(model.txtkeyword)|| p.英文名字nameEng.ToLower().Contains(model.txtkeyword.ToLower()));

            return View(datas);
        }
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                MDAContext db = new MDAContext();
                導演總表director director = db.導演總表directors.FirstOrDefault(p => p.導演編號directorId == id);
                if (director != null)
                    return View(director);
            }
            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Edit(CDirectorViewModel inDir) //post
        {
            MDAContext db = new MDAContext();
            導演總表director c = db.導演總表directors.FirstOrDefault(c => c.導演編號directorId == inDir.導演編號directorId);
            if (c != null)
            {
                if (inDir.photo != null)
                {
                    string pName = Guid.NewGuid().ToString() + ".jpg";
                    c.導演照片image = pName;
                    string path = _enviro.WebRootPath + "/images/Director/" + pName;
                    inDir.photo.CopyTo(new FileStream(path, FileMode.Create));
                }
                c.中文名字nameCht = inDir.中文名字nameCht;
                c.英文名字nameEng = inDir.英文名字nameEng;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(導演總表director p, CDirectorViewModel inDir)
        {
            MDAContext db = new MDAContext();

            string pName = Guid.NewGuid().ToString() + ".jpg";
            string path = _enviro.WebRootPath + "/images/Actor/" + pName;
            inDir.photo.CopyTo(new FileStream(path, FileMode.Create));

            p.導演照片image = pName;

            db.導演總表directors.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
