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
    public class MovieIimagesListController : Controller
    {
        private IWebHostEnvironment _enviro;
        private readonly MDAContext _context;
        public MovieIimagesListController(IWebHostEnvironment p, MDAContext context)
        {
            _enviro = p;
            _context = context;
        }
        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CMovieImagesListViewModel> datas = null;

            datas = db.電影圖片movieIimagesLists.Select
            (p => new CMovieImagesListViewModel
            {
                movieIimagesList = p,
                圖片image=p.圖片編號image.圖片image,
                中文標題titleCht=p.電影編號movie.中文標題titleCht
            }).ToList();
            return View(datas);
        }

        public ActionResult Edit(int? id)
        {
            MDAContext db = new MDAContext();
            var chi = db.電影movies.Select(i => i.中文標題titleCht).ToList();
            var imglist = db.電影圖片總表movieImages.Select(i => i.圖片編號imageId).ToList();
            var img = db.電影圖片總表movieImages.Select(i => i.圖片image).ToList();
            CMovieImagesListViewModel datas = null;
            datas = db.電影圖片movieIimagesLists.Where(p => p.電影編號movieId == id).Select
                (p => new CMovieImagesListViewModel
                {
                    movieIimagesList = p,
                    電影編號movieId=p.電影編號movie.電影編號movieId,
                    中文標題titleCht=p.電影編號movie.中文標題titleCht,
                    圖片image=p.圖片編號image.圖片image,
                    圖片類型imageType=p.圖片編號image.圖片類型imageType,
                }).FirstOrDefault();
            datas.titleChtList = chi;
            datas.titleImgList = imglist;
            datas.titleImg = img;
            return View(datas);
        }
        [HttpPost]
        public IActionResult Edit(CMovieImagesListViewModel inList) //post
        {
            MDAContext db = new MDAContext();
            電影圖片movieIimagesList c = db.電影圖片movieIimagesLists.FirstOrDefault(c => c.電影圖片編號miId == inList.電影圖片編號miId);
            電影圖片總表movieImage d = db.電影圖片總表movieImages.FirstOrDefault(c => c.圖片編號imageId == inList.圖片編號imageId);
            if (c != null)
            {
                if (inList.photo != null)
                {
                    string pName = Guid.NewGuid().ToString() + ".jpg";
                    d.圖片image = pName;
                    string path = _enviro.WebRootPath + "/images/MovieImage/" + pName;
                    inList.photo.CopyTo(new FileStream(path, FileMode.Create));
                }
                //c.圖片編號imageId = inList.圖片編號imageId;
                //c.電影編號movieId = inList.電影編號movieId;

                db.SaveChanges();
            }
            return RedirectToAction("List");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CMovieImagesListViewModel p)
        {
            MDAContext db = new MDAContext();
            電影圖片movieIimagesList m = new 電影圖片movieIimagesList();
            m = p.movieIimagesList;
            m.圖片編號imageId = db.電影圖片總表movieImages.FirstOrDefault(q => q.圖片編號imageId == p.圖片編號imageId).圖片編號imageId;
            m.電影編號movieId = db.電影movies.FirstOrDefault(q => q.中文標題titleCht == p.中文標題titleCht).電影編號movieId;
            db.電影圖片movieIimagesLists.Add(m);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        
        public IActionResult imageing(int id)
        {
            //c.系列編號seriesId = db.系列電影movieSeries.FirstOrDefault(q => q.系列名稱seriesName == inMovie.系列名稱seriesName).系列編號seriesId;
            //c.電影分級編號ratingId = db.電影分級movieRatings.FirstOrDefault(q => q.分級級數ratingLevel == inMovie.分級級數ratingLevel).分級編號ratingId;
            var movings = _context.電影圖片總表movieImages.Where(p => p.圖片編號imageId != id).Select(a => a.圖片編號imageId).ToList();
            return Json(movings);
        }
        public IActionResult moving(int id)
        {
            //c.系列編號seriesId = db.系列電影movieSeries.FirstOrDefault(q => q.系列名稱seriesName == inMovie.系列名稱seriesName).系列編號seriesId;
            //c.電影分級編號ratingId = db.電影分級movieRatings.FirstOrDefault(q => q.分級級數ratingLevel == inMovie.分級級數ratingLevel).分級編號ratingId;
            var movings = _context.電影movies.Where(p => p.電影編號movieId != id).Select(a => a.中文標題titleCht).ToList();
            return Json(movings);
        }
        public IActionResult imglist(int id)
        {
            var imglist = _context.電影圖片總表movieImages.Where(p => p.圖片編號imageId == id).Select(a => a.圖片image);
            return Json(imglist);
        }
        public ActionResult Details(int? id)
        {
            MDAContext db = new MDAContext();
            CMovieImagesListViewModel datas = null;
            datas = db.電影圖片movieIimagesLists.Where(p => p.電影編號movieId == id).Select
                (p => new CMovieImagesListViewModel
                {
                    movieIimagesList = p,
                    中文標題titleCht = p.電影編號movie.中文標題titleCht,
                    英文標題titleEng= p.電影編號movie.英文標題titleEng,
                    圖片image = p.圖片編號image.圖片image,

                }).FirstOrDefault();
            return View(datas);
        }

    }
}
