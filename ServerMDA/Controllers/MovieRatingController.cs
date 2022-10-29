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
    public class MovieRatingController : Controller
    {
        private readonly MDAContext _context;
        public MovieRatingController(MDAContext context)
        {
            _context = context;
        }

        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CMovieRatingViewModel> datas = null;
            datas = db.電影分級movieRatings.Select
            (p => new CMovieRatingViewModel
            {
                Rating = p,
            }).ToList();

            return View(datas);
        }
        public ActionResult Edit(int? id)
        {
            MDAContext db = new MDAContext();
            CMovieRatingViewModel datas = null;
            datas = db.電影分級movieRatings.Where(p => p.分級編號ratingId == id).Select
                (p => new CMovieRatingViewModel
                {
                    Rating = p,

                }).FirstOrDefault();
            return View(datas);
        }
        [HttpPost]
        public IActionResult Edit(CMovieRatingViewModel inRating) //post
        {
            MDAContext db = new MDAContext();
            電影分級movieRating c = db.電影分級movieRatings.FirstOrDefault(c => c.分級編號ratingId == inRating.分級編號ratingId);
            if (c != null)
            {
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
        public FileResult ShowPhoto(int id)
        {
            電影分級movieRating movieRating = _context.電影分級movieRatings.Find(id);
            byte[] context = movieRating.分級圖片ratingImage;
            return File(context, "image/jpeg");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CMovieRatingViewModel inRating)
        {
            MDAContext db = new MDAContext();
            電影分級movieRating m = new 電影分級movieRating();
            m = inRating.Rating;

            db.電影分級movieRatings.Add(m);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
