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

        public IActionResult List(CKeyWordViewModel model)
        {
            MDAContext db = new MDAContext();
            IEnumerable<電影分級movieRating> datas = null;
            if (string.IsNullOrEmpty(model.txtkeyword))
                datas = from p in db.電影分級movieRatings
                        select p;
            else
                datas = db.電影分級movieRatings.Where(p => p.分級說明ratingIllustrate.Contains(model.txtkeyword) || p.分級級數ratingLevel.Contains(model.txtkeyword));

            return View(datas);
        }

        public FileResult ShowPhoto(int id)
        {
            電影分級movieRating movieRating = _context.電影分級movieRatings.Find(id);
            byte[] context = movieRating.分級圖片ratingImage;
            return File(context, "image/jpeg");
        }

    }
}
