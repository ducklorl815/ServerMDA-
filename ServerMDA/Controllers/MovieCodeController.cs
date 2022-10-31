using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ServerMDA.Models;
using ServerMDA.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.Controllers
{
    public class MovieCodeController : Controller
    {
        private IWebHostEnvironment _enviro;

        public MovieCodeController(IWebHostEnvironment p)
        {
            _enviro = p;
        }

        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CMovieCodeViewModel> datas = null;
            datas = db.電影代碼movieCodes.Select
            (p => new CMovieCodeViewModel
            {
                movieCode = p,
                語言名稱languageName = p.語言編號language.語言名稱languageName,
                中文標題titleCht = p.電影編號movie.中文標題titleCht,
            }).ToList();

            return View(datas);
        }
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                MDAContext db = new MDAContext();
                電影代碼movieCode movieCode = db.電影代碼movieCodes.FirstOrDefault(p => p.電影代碼編號movieCodeId == id);
                if (movieCode != null)
                    return View(movieCode);
            }
            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Edit(CMovieCodeViewModel inMovieCode) //post
        {
            MDAContext db = new MDAContext();
            電影代碼movieCode c = db.電影代碼movieCodes.FirstOrDefault(c => c.電影代碼編號movieCodeId == inMovieCode.電影代碼編號movieCodeId);
            if (c != null)
            {
                c.電影編號movieId = inMovieCode.電影編號movieId;
                c.語言編號languageId = inMovieCode.語言編號languageId;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(電影代碼movieCode p)
        {
            MDAContext db = new MDAContext();
            db.電影代碼movieCodes.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
