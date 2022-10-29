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
    public class MovieLanguageController : Controller
    {
        private IWebHostEnvironment _enviro;

        public MovieLanguageController(IWebHostEnvironment p)
        {
            _enviro = p;
        }

        public IActionResult List(CKeyWordViewModel model)
        {
            MDAContext db = new MDAContext();
            List<CMovieLanguageViewModel> datas = null;
            if (string.IsNullOrEmpty(model.txtkeyword))
                datas = db.電影語言movieLanguages.Select
                    (p => new CMovieLanguageViewModel
                    {
                        movieLanguage = p,
                    }).ToList();
            else
                datas = db.電影語言movieLanguages.Where(p => p.語言名稱languageName.Contains(model.txtkeyword)).Select
                    (p => new CMovieLanguageViewModel
                    {
                        movieLanguage = p,
                    }).ToList();
            return View(datas);
        }

        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                MDAContext db = new MDAContext();
                CMovieLanguageViewModel datas = null;
                datas = db.電影語言movieLanguages.Where(p => p.語言編號languageId == id).Select
                (p => new CMovieLanguageViewModel
                {
                    movieLanguage = p,

                }).FirstOrDefault();
                if (datas != null)
                    return View(datas);
            }
            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Edit(CMovieLanguageViewModel inLanguage) //post
        {
            MDAContext db = new MDAContext();
            電影語言movieLanguage c = db.電影語言movieLanguages.FirstOrDefault(c => c.語言編號languageId == inLanguage.語言編號languageId);
            if (c != null)
            {
                c.語言名稱languageName = inLanguage.語言名稱languageName;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }

        public ActionResult Create()
        {
            MDAContext db = new MDAContext();
            CMovieLanguageViewModel datas = null;
            datas = db.電影語言movieLanguages.Select
                   (p => new CMovieLanguageViewModel
                   {
                       movieLanguage = p,
                   }).FirstOrDefault();
            return View(datas);
        }

        [HttpPost]
        public ActionResult Create(CMovieLanguageViewModel p)
        {
            MDAContext db = new MDAContext();
            電影語言movieLanguage m = new 電影語言movieLanguage();
            m = p.movieLanguage;
            db.電影語言movieLanguages.Add(m);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
