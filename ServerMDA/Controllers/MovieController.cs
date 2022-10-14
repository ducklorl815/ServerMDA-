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
    public class MovieController : Controller
    {
            private IWebHostEnvironment _enviro;

            public MovieController(IWebHostEnvironment p)
            {
                _enviro = p;
            }
            public IActionResult List(CKeyWordViewModel model)
            {
                MDAContext db = new MDAContext();
                IEnumerable<電影movie> datas = null;
                if (string.IsNullOrEmpty(model.txtkeyword))
                    datas = from p in db.電影movies
                            select p;
                else
                    datas = db.電影movies.Where(p => p.中文標題titleCht.Contains(model.txtkeyword) || p.英文標題titleEng.ToLower().Contains(model.txtkeyword.ToLower()));

                return View(datas);
            }
            public ActionResult Edit(int? id)
            {
                if (id != null)
                {
                    MDAContext db = new MDAContext();
                    電影movie movie = db.電影movies.FirstOrDefault(p => p.電影編號movieId == id);
                    if (movie != null)
                        return View(movie);
                }
                return RedirectToAction("List");
            }
            [HttpPost]
            public IActionResult Edit(CMovieViewModel inMovie) //post
            {
                MDAContext db = new MDAContext();
                電影movie c = db.電影movies.FirstOrDefault(c => c.電影編號movieId == inMovie.電影編號movieId);
                if (c != null)
                {
                    c.系列編號seriesId = inMovie.系列編號seriesId;
                    c.中文標題titleCht = inMovie.中文標題titleCht;
                    c.英文標題titleEng = inMovie.英文標題titleEng;
                    c.上映年份releaseYear = inMovie.上映年份releaseYear;
                    c.上映日期releaseDate = inMovie.上映日期releaseDate;
                    c.片長runtime = inMovie.片長runtime;
                    c.電影分級編號ratingId = inMovie.電影分級編號ratingId;
                    c.評分rate = inMovie.評分rate;
                    c.期待度anticipation = inMovie.期待度anticipation;
                    c.票房boxOffice = inMovie.票房boxOffice;
                    c.劇情大綱plot = inMovie.劇情大綱plot;
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
