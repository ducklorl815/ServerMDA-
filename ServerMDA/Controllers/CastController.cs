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
    public class CastController : Controller
    {
        private IWebHostEnvironment _enviro;

        public CastController(IWebHostEnvironment p, MDAContext context)
        {
            _enviro = p;
            _context = context;
        }
        private readonly MDAContext _context;
        public IActionResult sortList(int id)
        {
            MDAContext db = new MDAContext();
            List<CCastViewModel> datas = null;
            datas = db.電影主演casts.Where(p => p.電影編號movieId == id).Select
            (p => new CCastViewModel
            {
                cast = p,
                中文名字nameCht = p.演員編號actor.中文名字nameCht,
                演員照片image = p.演員編號actor.演員照片image,
                英文名字nameEng = p.演員編號actor.英文名字nameEng,
                中文標題titleCht = p.電影編號movie.中文標題titleCht,
            }).ToList();
            return View(datas);
        }

        public IActionResult sortListDir(int id)
        {
            MDAContext db = new MDAContext();
            List<CMovieDirectorViewModel> dirdatas = null;
            dirdatas = db.電影導演movieDirectors.Where(p => p.電影編號movieId == id).Select
            (q => new CMovieDirectorViewModel
            {
                director = q,
                中文名字nameCht = q.導演編號director.中文名字nameCht,
                英文名字nameEng = q.導演編號director.英文名字nameEng,
                導演照片image = q.導演編號director.導演照片image,
                中文標題titleCht = q.電影編號movie.中文標題titleCht,
            }).ToList();

            return View(dirdatas);
        }

        public ActionResult Edit(int? id)
        {
            MDAContext db = new MDAContext();
            CCastViewModel datas = null;
            datas = db.電影主演casts.Where(p => p.電影編號movieId == id).Select
                (p => new CCastViewModel
                {
                    cast = p,
                    //分級圖片ratingImage = p.電影分級編號rating.分級圖片ratingImage,
                    //分級說明ratingIllustrate = p.電影分級編號rating.分級說明ratingIllustrate,
                    //系列名稱seriesName = p.系列編號series.系列名稱seriesName,

                }).FirstOrDefault();
            return View(datas);
        }
        public ActionResult Create(int? id)
        {
            if (id != null)
            {
                MDAContext db = new MDAContext();
                CCastViewModel datas = null;
                var nameCht = db.演員總表actors.Select(p => p.中文名字nameCht).ToList();

                datas = db.電影主演casts.Where(p => p.電影編號movieId == id).Select
                (p => new CCastViewModel
                {
                    cast = p,
                    中文名字nameCht = p.演員編號actor.中文名字nameCht,
                    中文標題titleCht = p.電影編號movie.中文標題titleCht,
                }).FirstOrDefault();

                datas.titleNameList = nameCht;
                return View(datas);
            }
            return View();
        }
        [HttpPost]
        public ActionResult Create(CCastViewModel p)
        {
            MDAContext db = new MDAContext();
            電影主演cast m = new 電影主演cast();
            m = p.cast;
            m.演員編號actorId = db.演員總表actors.FirstOrDefault(q => q.中文名字nameCht == p.中文名字nameCht).演員編號actorsId;
            //m.電影分級編號ratingId = db.電影分級movieRatings.FirstOrDefault(q => q.分級級數ratingLevel == p.分級級數ratingLevel).分級編號ratingId;
            db.電影主演casts.Add(m);
            db.SaveChanges();
            return RedirectToAction("List", "Movie", null);
        }

        public ActionResult CreateDir(int? id)
        {
            if (id != null)
            {
                MDAContext db = new MDAContext();
                CMovieDirectorViewModel datas = null;
                var nameCht = db.導演總表directors.Select(p => p.中文名字nameCht).ToList();

                datas = db.電影導演movieDirectors.Where(p => p.電影編號movieId == id).Select
                (p => new CMovieDirectorViewModel
                {
                    director = p,
                    中文名字nameCht = p.導演編號director.中文名字nameCht,
                    中文標題titleCht = p.電影編號movie.中文標題titleCht,
                }).FirstOrDefault();

                datas.titleNameList = nameCht;
                return View(datas);
            }
            return View();
        }
        [HttpPost]
        public ActionResult CreateDir(CMovieDirectorViewModel p)
        {
            MDAContext db = new MDAContext();
            電影導演movieDirector m = new 電影導演movieDirector();
            m = p.director;
            m.導演編號directorId = db.導演總表directors.FirstOrDefault(q => q.中文名字nameCht == p.中文名字nameCht).導演編號directorId;
            //m.電影分級編號ratingId = db.電影分級movieRatings.FirstOrDefault(q => q.分級級數ratingLevel == p.分級級數ratingLevel).分級編號ratingId;
            db.電影導演movieDirectors.Add(m);
            db.SaveChanges();
            return RedirectToAction("List", "Movie", null);
        }
    }
}
