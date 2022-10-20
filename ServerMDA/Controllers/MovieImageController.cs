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
        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CMovieImageViewModel> datas = null;

            datas = db.電影圖片總表movieImages.Select
            (p => new CMovieImageViewModel
            {
                movieImage = p,
                圖片編號imageId = p.圖片編號imageId,
            }).ToList();
            return View(datas);
        }

        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                MDAContext db = new MDAContext();
                電影圖片總表movieImage movieImage = db.電影圖片總表movieImages.FirstOrDefault(p => p.圖片編號imageId == id);
                if (movieImage != null)
                    return View(movieImage);
            }
            return RedirectToAction("List");
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
                c.圖片imageType = inImage.圖片imageType;
                c.屏蔽invisible = inImage.屏蔽invisible;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }

        public ActionResult Create()
        {
            return View();
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
