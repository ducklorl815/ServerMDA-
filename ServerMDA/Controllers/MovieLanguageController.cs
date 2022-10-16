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
            IEnumerable<電影語言movieLanguage> datas = null;
            if (string.IsNullOrEmpty(model.txtkeyword))
                datas = from p in db.電影語言movieLanguages
                        select p;
            else
                datas = db.電影語言movieLanguages.Where(p => p.語言名稱languageName.Contains(model.txtkeyword));

            return View(datas);
        }
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                MDAContext db = new MDAContext();
                電影語言movieLanguage language = db.電影語言movieLanguages.FirstOrDefault(p => p.語言編號languageId == id);
                if (language != null)
                    return View(language);
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
            return View();
        }
        [HttpPost]
        public ActionResult Create(電影movie p)
        {
            MDAContext db = new MDAContext();
            db.電影movies.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
