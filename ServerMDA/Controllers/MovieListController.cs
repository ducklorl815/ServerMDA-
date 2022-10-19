using Microsoft.AspNetCore.Mvc;
using ServerMDA.Models;
using ServerMDA.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.Controllers
{
    public class MovieListController : Controller
    {
        public IActionResult List(CKeyWordViewModel model)
        {
            MDAContext db = new MDAContext();
            List<CMovieViewModel> datas = null;
            if (string.IsNullOrEmpty(model.txtkeyword))
                datas = db.電影movies.Select
                (p => new CMovieViewModel
                {
                    movie = p,
                    分級圖片ratingImage = p.電影分級編號rating.分級圖片ratingImage,
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
    }
}
