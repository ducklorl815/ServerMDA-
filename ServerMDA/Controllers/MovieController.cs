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

            public MovieController(IWebHostEnvironment p,MDAContext context)
            {
                _enviro = p;
                _context = context;
            }
            private readonly MDAContext _context;

        public IActionResult List(CKeyWordViewModel model)
            {
                MDAContext db = new MDAContext();
                List<CMovieViewModel> datas = null;
                if (string.IsNullOrEmpty(model.txtkeyword))
                datas = db.電影movies.Select
                (p=>new CMovieViewModel
                {
                    movie=p,       
                    分級圖片ratingImage =p.電影分級編號rating.分級圖片ratingImage,
                    系列名稱seriesName = p.系列編號series.系列名稱seriesName,
                }).ToList();

                else
                datas = db.電影movies.Where(p => p.中文標題titleCht.Contains(model.txtkeyword) || p.英文標題titleEng.ToLower().Contains(model.txtkeyword.ToLower())).Select
                (p => new CMovieViewModel
                {
                    movie = p,
                    分級圖片ratingImage = p.電影分級編號rating.分級圖片ratingImage
                }).ToList();
                return View(datas);
            }
            public ActionResult Edit(int? id)
            {
                MDAContext db = new MDAContext();
                CMovieViewModel datas = null;
                datas = db.電影movies.Where(p => p.電影編號movieId == id).Select
                    (p => new CMovieViewModel
                        {
                            movie = p,
                            分級圖片ratingImage = p.電影分級編號rating.分級圖片ratingImage,
                            分級說明ratingIllustrate = p.電影分級編號rating.分級說明ratingIllustrate,
                            系列名稱seriesName = p.系列編號series.系列名稱seriesName,

                        }).FirstOrDefault();
                return View(datas);
            }
            [HttpPost]
            public IActionResult Edit(CMovieViewModel inMovie) //post
            {
                MDAContext db = new MDAContext();
                電影movie c = db.電影movies.FirstOrDefault(c => c.電影編號movieId == inMovie.電影編號movieId);
                if (c != null)
                {
                    c.中文標題titleCht = inMovie.中文標題titleCht;
                    c.英文標題titleEng = inMovie.英文標題titleEng;
                    c.上映年份releaseYear = inMovie.上映年份releaseYear;
                    c.上映日期releaseDate = inMovie.上映日期releaseDate;
                    c.片長runtime = inMovie.片長runtime;
                    c.評分rate = inMovie.評分rate;
                    c.期待度anticipation = inMovie.期待度anticipation;
                    c.票房boxOffice = inMovie.票房boxOffice;
                    c.劇情大綱plot = inMovie.劇情大綱plot;
                    c.系列編號seriesId = db.系列電影movieSeries.FirstOrDefault(q => q.系列名稱seriesName == inMovie.系列名稱seriesName).系列編號seriesId;
                    c.電影分級編號ratingId = db.電影分級movieRatings.FirstOrDefault(q => q.分級級數ratingLevel == inMovie.分級級數ratingLevel).分級編號ratingId;
                db.SaveChanges();
                }
                return RedirectToAction("List");
            }
            public ActionResult Create()
            {
                return View();
            }
            [HttpPost]
            public ActionResult Create(CMovieViewModel p)
            {
            MDAContext db = new MDAContext();
            電影movie m = new 電影movie();
            m = p.movie;
            m.系列編號seriesId = db.系列電影movieSeries.FirstOrDefault(q => q.系列名稱seriesName == p.系列名稱seriesName).系列編號seriesId;
            m.電影分級編號ratingId = db.電影分級movieRatings.FirstOrDefault(q => q.分級級數ratingLevel == p.分級級數ratingLevel).分級編號ratingId;
            db.電影movies.Add(m);
            db.SaveChanges();
            return RedirectToAction("List");
            }
            public FileResult ShowPhoto(int id)
            {
                電影分級movieRating movieRating = _context.電影分級movieRatings.Find(id);
                byte[] context = movieRating.分級圖片ratingImage;
                return File(context, "image/jpeg");
            }
            public IActionResult series()
            {
                var series = _context.系列電影movieSeries.Select(a => a.系列名稱seriesName).ToList();
                return Json(series);
            }
            public IActionResult rating()
            {
                var ratings = _context.電影分級movieRatings.Select(a => a.分級級數ratingLevel).ToList();
                return Json(ratings);
            }
            public IActionResult insMovie()
            {
                var ratings = _context.電影分級movieRatings.Select(a => a.分級級數ratingLevel).ToList();
                return Json(ratings);
            }
    }
    
}
