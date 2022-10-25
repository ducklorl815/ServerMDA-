using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
    public class ActorController : Controller
    {
        private IWebHostEnvironment _enviro;

        public ActorController(IWebHostEnvironment p)
        {
            _enviro = p;
        }
        public IActionResult List(CKeyWordViewModel model)
        {
            MDAContext db = new MDAContext();
            IEnumerable<演員總表actor> datas = null;
            if (string.IsNullOrEmpty(model.txtkeyword))
                datas = from p in db.演員總表actors
                        select p;
            else
                datas = db.演員總表actors.Where(p => p.中文名字nameCht.Contains(model.txtkeyword) || p.英文名字nameEng.ToLower().Contains(model.txtkeyword.ToLower()));

            return View(datas);
        }
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                MDAContext db = new MDAContext();
                演員總表actor actor = db.演員總表actors.FirstOrDefault(p => p.演員編號actorsId == id);
                if (actor != null)
                    return View(actor);
            }
            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Edit(CActorViewModel inActor) //post
        {
            MDAContext db = new MDAContext();
            演員總表actor c = db.演員總表actors.FirstOrDefault(c => c.演員編號actorsId == inActor.演員編號actorsId);
            if (c != null)
            {
                if (inActor.photo != null)
                {
                     string pName = Guid.NewGuid().ToString() + ".jpg";
                    c.演員照片image = pName;
                    string path = _enviro.WebRootPath + "/images/Actor/" + pName;
                    inActor.photo.CopyTo(new FileStream(path, FileMode.Create));
                }
                c.中文名字nameCht = inActor.中文名字nameCht;
                c.英文名字nameEng = inActor.英文名字nameEng;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(演員總表actor p, CActorViewModel inActor)
        {
            MDAContext db = new MDAContext();

            string pName = Guid.NewGuid().ToString() + ".jpg";
            string path = _enviro.WebRootPath + "/images/Actor/" + pName;
            inActor.photo.CopyTo(new FileStream(path, FileMode.Create));

            p.演員照片image = pName;

            db.演員總表actors.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public ActionResult Details(int? id)
        {
            if (id != null)
            {
                MDAContext db = new MDAContext();
                演員總表actor Detail = db.演員總表actors.FirstOrDefault(p => p.演員編號actorsId == id);
                if (Detail != null)
                    return View(Detail);
            }
            return RedirectToAction("List");
        }

        public IActionResult keywordActors(string keyword)
        {
            MDAContext db = new MDAContext();
            var q = db.演員總表actors.Where(p => p.中文名字nameCht.Contains(keyword) || p.英文名字nameEng.ToLower().Contains(keyword.ToLower())).Select(p => p.演員編號actorsId + p.中文名字nameCht + p.英文名字nameEng);
            return Json(q);
        }
    }
}
