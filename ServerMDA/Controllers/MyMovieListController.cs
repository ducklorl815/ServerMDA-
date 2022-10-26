using Microsoft.AspNetCore.Mvc;
using ServerMDA.Models;
using ServerMDA.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.Controllers
{
    public class MyMovieListController : Controller
    {
        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CMyMovieListViewModel> datas = null;
            datas = db.我的片單myMovieLists.Select
            (p => new CMyMovieListViewModel
            {
                myMovieList = p,
                片單總表名稱listName = p.片單總表編號movieList.片單總表名稱listName,
                會員電話cellphone = p.會員編號member.會員電話cellphone,
                姓氏lName = p.會員編號member.姓氏lName,
                名字fName = p.會員編號member.名字fName,
                暱稱nickName = p.會員編號member.暱稱nickName,
                中文標題titleCht = p.電影編號movie.中文標題titleCht,
                英文標題titleEng = p.電影編號movie.英文標題titleEng,
            }).ToList();

            return View(datas);
        }
        public ActionResult Edit(int? id)
        {
            MDAContext db = new MDAContext();
            CMyMovieListViewModel datas = null;

            datas = db.我的片單myMovieLists.Where(p => p.會員編號memberId == id).Select
                (p => new CMyMovieListViewModel
                {
                    myMovieList = p,
                    //分級圖片ratingImage = p.電影分級編號rating.分級圖片ratingImage,
                    //分級說明ratingIllustrate = p.電影分級編號rating.分級說明ratingIllustrate,
                    //系列名稱seriesName = p.系列編號series.系列名稱seriesName,
                    //分級級數ratingLevel = p.電影分級編號rating.分級級數ratingLevel,

                }).FirstOrDefault();

            return View(datas);
        }
        [HttpPost]
        public IActionResult Edit(CMyMovieListViewModel inMovie) //post
        {
            //MDAContext db = new MDAContext();
            //電影movie c = db.我的片單myMovieLists.FirstOrDefault(c => c.電影編號movieId == inMovie.電影編號movieId);
            //if (c != null)
            //{
            //    c.中文標題titleCht = inMovie.中文標題titleCht;
            //    c.英文標題titleEng = inMovie.英文標題titleEng;
            //    c.上映年份releaseYear = inMovie.上映年份releaseYear;
            //    c.上映日期releaseDate = inMovie.上映日期releaseDate;
            //    c.片長runtime = inMovie.片長runtime;
            //    c.評分rate = inMovie.評分rate;
            //    c.期待度anticipation = inMovie.期待度anticipation;
            //    c.票房boxOffice = inMovie.票房boxOffice;
            //    c.劇情大綱plot = inMovie.劇情大綱plot;
            //    c.系列編號seriesId = db.系列電影movieSeries.FirstOrDefault(q => q.系列名稱seriesName == inMovie.系列名稱seriesName).系列編號seriesId;
            //    c.電影分級編號ratingId = db.電影分級movieRatings.FirstOrDefault(q => q.分級級數ratingLevel == inMovie.分級級數ratingLevel).分級編號ratingId;
            //    db.SaveChanges();
            //}
            return RedirectToAction("List");
        }
    }
}
