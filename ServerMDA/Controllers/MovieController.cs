using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ServerMDA.Models;
using ServerMDA.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.Controllers
{
    public class MovieController : Controller
    {
        #region Top
        private IWebHostEnvironment _enviro;
        public MovieController(IWebHostEnvironment p, MDAContext context)
        {
            _enviro = p;
            _context = context;
        }
        private readonly MDAContext _context;
        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CMovieViewModel> datas = null;
            datas = db.電影movies.Select
            (p => new CMovieViewModel
            {
                movie = p,
                分級圖片ratingImage = p.電影分級編號rating.分級圖片ratingImage,
                系列名稱seriesName = p.系列編號series.系列名稱seriesName,
            }).ToList();

            return View(datas);
        }
        public ActionResult Edit(int? id)
        {
            MDAContext db = new MDAContext();
            CMovieViewModel datas = null;
            var rating = db.電影分級movieRatings.Select(p => p.分級級數ratingLevel).ToList();
            var series = db.系列電影movieSeries.Select(p => p.系列名稱seriesName).ToList();
            datas = db.電影movies.Where(p => p.電影編號movieId == id).Select
                (p => new CMovieViewModel
                {
                    movie = p,
                    分級圖片ratingImage = p.電影分級編號rating.分級圖片ratingImage,
                    分級說明ratingIllustrate = p.電影分級編號rating.分級說明ratingIllustrate,
                    系列名稱seriesName = p.系列編號series.系列名稱seriesName,
                    分級級數ratingLevel = p.電影分級編號rating.分級級數ratingLevel,

                }).FirstOrDefault();
            datas.listrating = rating;
            datas.listseries = series;
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
            MDAContext db = new MDAContext();
            CMovieViewModel datas = null;
            var rating = db.電影分級movieRatings.Select(p => p.分級級數ratingLevel).ToList();
            var series = db.系列電影movieSeries.Select(p => p.系列名稱seriesName).ToList();
            datas = db.電影movies.Select
                (p => new CMovieViewModel
                {
                    movie = p,
                    分級圖片ratingImage = p.電影分級編號rating.分級圖片ratingImage,
                    分級說明ratingIllustrate = p.電影分級編號rating.分級說明ratingIllustrate,
                    系列名稱seriesName = p.系列編號series.系列名稱seriesName,
                    分級級數ratingLevel = p.電影分級編號rating.分級級數ratingLevel,
                }).FirstOrDefault();
            datas.listrating = rating;
            datas.listseries = series;
            return View(datas);
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

        #endregion

        #region 新增資訊
        public IActionResult CreateOneWay()
        {
            return View();
        }

        public IActionResult CreateOneDragon(COneDragonViewModelcs Inputdata)
        {
            電影movie movie = new 電影movie()
            {
                系列編號seriesId = Inputdata.Series_ID,
                中文標題titleCht = Inputdata.Title_Chi,
                英文標題titleEng = Inputdata.Title_Eng,
                上映年份releaseYear = Inputdata.Release_Date.Year,
                上映日期releaseDate = Inputdata.Release_Date.Date,
                片長runtime = Inputdata.runtime,
                電影分級編號ratingId = Inputdata.Rate_ID,
                票房boxOffice = Inputdata.Box,
                劇情大綱plot = Inputdata.Plot,
                預告片trailer = Inputdata.TrailerUrl
            };

            this._context.電影movies.Add(movie);
            this._context.SaveChanges();

            int movieID = this._context.電影movies.OrderBy(m => m.電影編號movieId).LastOrDefault().電影編號movieId;
            fn_加入電影圖片(movieID, Inputdata.photos);
            fn_加入電影主演(movieID, Inputdata.actors);
            fn_加入電影導演(movieID, Inputdata.directors);
            return RedirectToAction("List");
        }

        #region ViewComponent

        public IActionResult CreateActor()
        {
            return ViewComponent("CreateActor");
        }

        public IActionResult CreateDirector()
        {
            return ViewComponent("CreateDirctor");
        }

        #endregion

        #region Ajax

        public IActionResult CreateNewSerial(string name)
        {
            if(!string.IsNullOrEmpty(name))
            {
                系列電影movieSeries series = new 系列電影movieSeries()
                {
                    系列名稱seriesName = name
                };
                this._context.系列電影movieSeries.Add(series);
                this._context.SaveChanges();
                return Json('T');
            }
            return Json('F');
        }


        #endregion

        #region function
        public void fn_加入電影導演(int movie_id, List<int> directors)
        {
            foreach (int item in directors)
            {
                電影導演movieDirector director = new 電影導演movieDirector()
                {
                    電影編號movieId = movie_id,
                    導演編號directorId = item,
                };
                this._context.電影導演movieDirectors.Add(director);
            }

            this._context.SaveChanges();
        }

        public void fn_加入電影主演(int movie_id, List<int> actors)
        {
            foreach (int item in actors)
            {
                電影主演cast cast = new 電影主演cast()
                {
                    電影編號movieId = movie_id,
                    演員編號actorId = item,
                };
                this._context.電影主演casts.Add(cast);
            }
            this._context.SaveChanges();
        }
        //p
        public void fn_加入電影圖片(int movie, List<IFormFile> files)
        {
            int _count = files.Count();
            string root = $"{_enviro.WebRootPath}/images/MovieImage/";
            string fileName = "";
            string _url = "";
            foreach (IFormFile file in files)
            {
                if (file.Length > 0)
                {
                    fileName = Guid.NewGuid().ToString() + ".jpg";
                    _url = $"{root}{fileName}";
                    using (var stream = System.IO.File.Create(_url))
                    {
                        file.CopyTo(stream);
                    }
                    電影圖片總表movieImage pic = new 電影圖片總表movieImage()
                    {
                        圖片image = fileName,
                    };
                    this._context.電影圖片總表movieImages.Add(pic);
                }
            }
            this._context.SaveChanges();
            List<int> q = this._context.電影圖片總表movieImages.OrderByDescending(p => p.圖片編號imageId).Take(_count).Select(p => p.圖片編號imageId).ToList();
            foreach (int item in q)
            {
                電影圖片movieIimagesList image = new 電影圖片movieIimagesList()
                {
                    圖片編號imageId = item,
                    電影編號movieId = movie,
                };
                this._context.電影圖片movieIimagesLists.Add(image);
            }
            this._context.SaveChanges();
        }



        #endregion



        #endregion

        #region butt

        public IActionResult autoCmpMovie(string keyword)
        {
            var q = _context.演員總表actors.Where(m => m.演員中文名字nameCht.Contains(keyword) || m.演員英文名字nameEng.ToUpper().Contains(keyword.ToUpper())).Select(p => p.演員中文名字nameCht);
            return Json(q);

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
        public IActionResult rating(int id)
        {
            //c.系列編號seriesId = db.系列電影movieSeries.FirstOrDefault(q => q.系列名稱seriesName == inMovie.系列名稱seriesName).系列編號seriesId;
            //c.電影分級編號ratingId = db.電影分級movieRatings.FirstOrDefault(q => q.分級級數ratingLevel == inMovie.分級級數ratingLevel).分級編號ratingId;
            var ratings = _context.電影分級movieRatings.Where(p => p.分級編號ratingId != id).Select(a => a.分級級數ratingLevel).ToList();
            return Json(ratings);
        }
        public IActionResult insMovie()
        {
            var ratings = _context.電影分級movieRatings.Select(a => a.分級級數ratingLevel).ToList();
            return Json(ratings);
        }
        public IActionResult actorlist(int id)
        {
            MDAContext db = new MDAContext();
            //List<CMovieViewModel> actorlist = null;
            var actorlist = db.電影主演casts.Where(p => p.電影編號movieId == id).Select
            (p => new CMovieViewModel
            {
                中文名字nameCht = p.演員編號actor.演員中文名字nameCht,
            }).ToList();

            return Json(actorlist);
        }
        public ActionResult Details(int? id)
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
                    分級級數ratingLevel = p.電影分級編號rating.分級級數ratingLevel,
                    //todo 片種挖不過來
                    //片種編號typeId = p.電影片種movieTypes.Select(p=>p.電影編號movie.電影編號movieId).ToList(),
                }).FirstOrDefault();
            return View(datas);
        }
        public IActionResult checkWatchList(string name)
        {
            bool isExist = _context.演員總表actors.Any(l => l.演員中文名字nameCht == name);
            return Content(isExist.ToString(), "text/plain");
        }
        //todo Session
        public IActionResult AS(string jsonString)
        {
            HttpContext.Session.SetString(CDictionary.SK_ADDMOVIE_ACTOR, jsonString);
            string jsonAll = HttpContext.Session.GetString(CDictionary.SK_ADDMOVIE_ACTOR);
            //var result = JsonSerializer.Deserialize<CDictionary>(jsonAll);
            return View();
        }

        #endregion
    }

}
