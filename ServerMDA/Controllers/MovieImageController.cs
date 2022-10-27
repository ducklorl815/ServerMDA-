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
    public class MovieImageController: Controller
    {
        private IWebHostEnvironment _enviro;
        public MovieImageController(IWebHostEnvironment p)
        {
            _enviro = p;
        }
        List<string> imagetype = new List<string> { "海報", "劇照", "未分類" };
        List<int> invisible = new List<int> {0, 1 };
        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CMovieImageViewModel> datas = null;

            datas = db.電影圖片總表movieImages.Select
            (p => new CMovieImageViewModel
            {
                movieImage = p,
            }).ToList();
            return View(datas);
        }

        public ActionResult Edit(int? id)
        {
            MDAContext db = new MDAContext();
            CMovieImageViewModel datas = null;
            datas = db.電影圖片總表movieImages.Where(p => p.圖片編號imageId == id).Select
                (p => new CMovieImageViewModel
                {
                    movieImage = p,

                }).FirstOrDefault();
            datas.listImagetype = imagetype;
            datas.listinvisible = invisible;
            return View(datas);
        }
        [HttpPost]
        public IActionResult Edit(CMovieImageViewModel inImage) //post
        {
            MDAContext db = new MDAContext();
            電影圖片總表movieImage c = db.電影圖片總表movieImages.FirstOrDefault(c => c.圖片編號imageId == inImage.圖片編號imageId);
            if (c != null)
            {
                if (inImage.photo != null)
                {
                    string pName = Guid.NewGuid().ToString() + ".jpg";
                    c.圖片image = pName;
                    string path = _enviro.WebRootPath + "/images/MovieImage/" + pName;
                    inImage.photo.CopyTo(new FileStream(path, FileMode.Create));
                }
                c.圖片雲端imageImdb = inImage.圖片雲端imageImdb;
                c.電影名稱movieName = inImage.電影名稱movieName;
                c.圖片類型imageType = inImage.圖片類型imageType;
                c.屏蔽invisible = inImage.屏蔽invisible;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }

        public ActionResult Create()
        {
            MDAContext db = new MDAContext();
            CMovieImageViewModel datas = null;
            datas = db.電影圖片總表movieImages.Select
                (p => new CMovieImageViewModel
                {
                    movieImage = p,

                }).FirstOrDefault();
            datas.listImagetype = imagetype;
            datas.listinvisible = invisible;
            return View(datas);
        }

        [HttpPost]
        public ActionResult Create(電影圖片總表movieImage p,CMovieImageViewModel inImage)
        {
            MDAContext db = new MDAContext();
            string pName = Guid.NewGuid().ToString() + ".jpg";
            string path = _enviro.WebRootPath + "/images/MovieImage/" + pName;
            inImage.photo.CopyTo(new FileStream(path, FileMode.Create));

            p.圖片image = pName;

            //m.系列編號seriesId = db.系列電影movieSeries.FirstOrDefault(q => q.系列名稱seriesName == p.系列名稱seriesName).系列編號seriesId;
            //m.電影分級編號ratingId = db.電影分級movieRatings.FirstOrDefault(q => q.分級級數ratingLevel == p.分級級數ratingLevel).分級編號ratingId;
            db.電影圖片總表movieImages.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
