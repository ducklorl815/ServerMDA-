using Microsoft.AspNetCore.Hosting;
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
        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CDirectorViewModel> datas = null;
            datas = db.導演總表directors.Select
            (p => new CDirectorViewModel
            {
                director = p,
            }).ToList();

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
                c.導演中文名字nameCht = inDir.導演中文名字nameCht;
                c.導演英文名字nameEng = inDir.導演英文名字nameEng;
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
        public ActionResult Details(int? id)
        {
            if (id != null)
            {
                MDAContext db = new MDAContext();
                導演總表director Detail = db.導演總表directors.FirstOrDefault(p => p.導演編號directorId == id);
                if (Detail != null)
                    return View(Detail);
            }
            return RedirectToAction("List");
        }
    }
}
