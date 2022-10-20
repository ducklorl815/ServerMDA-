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
    public class CinemaController : Controller
    {
        private IWebHostEnvironment _enviro;

        public CinemaController(IWebHostEnvironment p, MDAContext context)
        {
            _enviro = p;
            _context = context;
        }
        private readonly MDAContext _context;

        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CCinemaViewModel> datas = null;
                datas = db.影廳cinemas.Select
                (p => new CCinemaViewModel
                {
                    cinema = p,
                    電影院名稱theaterName = p.電影院編號theater.電影院名稱theaterName,
                }).ToList();

            return View(datas);
        }
        public ActionResult Edit(int? id)
        {
            MDAContext db = new MDAContext();
            CCinemaViewModel datas = null;
            datas = db.影廳cinemas.Where(p => p.影廳編號cinemaId == id).Select
                (p => new CCinemaViewModel
                {
                    cinema = p,
                    電影院名稱theaterName = p.電影院編號theater.電影院名稱theaterName,

                }).FirstOrDefault();
            return View(datas);
        }
        [HttpPost]
        public IActionResult Edit(CCinemaViewModel inCinema) //post
        {
            MDAContext db = new MDAContext();
            影廳cinema c = db.影廳cinemas.FirstOrDefault(c => c.影廳編號cinemaId == inCinema.影廳編號cinemaId);
            if (c != null)
            {
                c.影廳編號cinemaId = inCinema.影廳編號cinemaId;
                c.影廳名稱cinemaName = inCinema.影廳名稱cinemaName;
                c.電影院編號theaterId = inCinema.電影院編號theaterId;
                c.廳種名稱cinemaClsName = inCinema.廳種名稱cinemaClsName;
                c.座位資訊seatInfo = inCinema.座位資訊seatInfo;
                c.影廳照片image = inCinema.影廳照片image;
                c.電影院編號theaterId = db.系列電影movieSeries.FirstOrDefault(q => q.系列名稱seriesName == inCinema.系列名稱seriesName).系列編號seriesId;
          
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
        public IActionResult series(int id)
        {
            var series = _context.系列電影movieSeries.Where(p => p.系列編號seriesId != id).Select(a => a.系列名稱seriesName).ToList();
            return Json(series);
        }
        public IActionResult rating(int id)
        {
            //c.系列編號seriesId = db.系列電影movieSeries.FirstOrDefault(q => q.系列名稱seriesName == inCinema.系列名稱seriesName).系列編號seriesId;
            //c.電影分級編號ratingId = db.電影分級movieRatings.FirstOrDefault(q => q.分級級數ratingLevel == inCinema.分級級數ratingLevel).分級編號ratingId;
            var ratings = _context.電影分級movieRatings.Where(p => p.分級編號ratingId != id).Select(a => a.分級級數ratingLevel).ToList();
            return Json(ratings);
        }
        public IActionResult insMovie()
        {
            var ratings = _context.電影分級movieRatings.Select(a => a.分級級數ratingLevel).ToList();
            return Json(ratings);
        }
    }
}
