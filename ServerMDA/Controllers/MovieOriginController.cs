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
    public class MovieOriginController : Controller
    {
        private IWebHostEnvironment _enviro;

        public MovieOriginController(IWebHostEnvironment p, MDAContext context)
        {
            _enviro = p;
            _context = context;
        }
        private readonly MDAContext _context;

        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CMovieOriginViewModel> datas = null;
            datas = db.電影產地movieOrigins.Select
            (p => new CMovieOriginViewModel
            {
                Origin = p,
                國家名稱countryName = p.國家編號country.國家名稱countryName,
                國旗countryImage = p.國家編號country.國旗countryImage,
                中文標題titleCht=p.電影編號movie.中文標題titleCht,
            }).ToList();

            return View(datas);
        }

        public ActionResult Edit(int? id)
        {
            MDAContext db = new MDAContext();
            CMovieOriginViewModel datas = null;
            datas = db.電影產地movieOrigins.Where(p => p.電影產地編號mcId == id).Select
                (p => new CMovieOriginViewModel
                {
                    Origin = p,
                    國家名稱countryName = p.國家編號country.國家名稱countryName,
                    國旗countryImage = p.國家編號country.國旗countryImage,
                    中文標題titleCht = p.電影編號movie.中文標題titleCht,

                }).FirstOrDefault();
            return View(datas);
        }
        [HttpPost]
        public IActionResult Edit(CMovieOriginViewModel inOrigin) //post
        {
            MDAContext db = new MDAContext();
            電影產地movieOrigin c = db.電影產地movieOrigins.FirstOrDefault(c => c.電影產地編號mcId == inOrigin.電影產地編號mcId);
            if (c != null)
            {
                c.國家編號countryId = db.國家總表countrys.FirstOrDefault(q => q.國家名稱countryName == inOrigin.國家名稱countryName).國家編號countryId;
                c.電影編號movieId = db.電影movies.FirstOrDefault(q => q.中文標題titleCht == inOrigin.中文標題titleCht).電影編號movieId;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
        public IActionResult ListOri()
        {
            MDAContext db = new MDAContext();
            List<CCountrysViewModel> datas = null;
            datas = db.國家總表countrys.Select
            (p => new CCountrysViewModel
            {
                country = p,
            }).ToList();

            return View(datas);
        }
        public ActionResult EditOri(string id)
        {
            MDAContext db = new MDAContext();
            CCountrysViewModel datas = null;
            datas = db.國家總表countrys.Where(p => p.國家編號countryId == id).Select
                (p => new CCountrysViewModel
                {
                    country = p,

                }).FirstOrDefault();
            return View(datas);
        }
        [HttpPost]
        public IActionResult EditOri(CCountrysViewModel inCou) //post
        {
            MDAContext db = new MDAContext();
            國家總表country c = db.國家總表countrys.FirstOrDefault(c => c.國家編號countryId == inCou.國家編號countryId);

            if (inCou.photo != null)
            {
                string pName = Guid.NewGuid().ToString() + ".jpg";
                c.國旗countryImage = pName;
                string path = _enviro.WebRootPath + "/images/Country/" + pName;
                inCou.photo.CopyTo(new FileStream(path, FileMode.Create));
            }
            c.國家名稱countryName = inCou.國家名稱countryName;
            db.SaveChanges();

            return RedirectToAction("ListOri");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CMovieOriginViewModel inOrigin)
        {
            MDAContext db = new MDAContext();
            電影產地movieOrigin m = new 電影產地movieOrigin();
            m = inOrigin.Origin;
            m.國家編號countryId = db.國家總表countrys.FirstOrDefault(q => q.國家名稱countryName == inOrigin.國家名稱countryName).國家編號countryId;
            m.電影編號movieId = db.電影movies.FirstOrDefault(q => q.中文標題titleCht == inOrigin.中文標題titleCht).電影編號movieId;
            db.電影產地movieOrigins.Add(m);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        //public FileResult ShowPhoto(string id)
        //{
        //    國家總表country country = _context.國家總表countrys.Find(id);
        //    byte[] context = country.國旗countryImage;
        //    return File(context, "image/jpeg");
        //}
        public IActionResult FirstAjax(int id)
        {
            var first = _context.電影movies.Where(p => p.電影編號movieId != id).Select(a => a.中文標題titleCht).ToList();
            return Json(first);
        }
        public IActionResult SecondAjax(string id)
        {
            var second = _context.國家總表countrys.Where(p => p.國家編號countryId != id).Select(a => a.國家名稱countryName).ToList();
            return Json(second);
        }
        public IActionResult FirstAjaxCreate()
        {
            var first = _context.電影movies.Select(a => a.中文標題titleCht).ToList();
            return Json(first);
        }
        public IActionResult SecondAjaxCreate()
        {
            var second = _context.國家總表countrys.Select(a => a.國家名稱countryName).ToList();
            return Json(second);
        }
    }
}
