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
    public class MovieTypeController : Controller
    {
        private IWebHostEnvironment _enviro;

        public MovieTypeController(IWebHostEnvironment p, MDAContext context)
        {
            _enviro = p;
            _context = context;
        }
        private readonly MDAContext _context;

        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CMovieTypeViewModel> datas = null;
            datas = db.電影片種movieTypes.Select
            (p => new CMovieTypeViewModel
            {
                movieType = p,
                片種名稱totalTypeName=p.片種編號type.片種名稱totalTypeName,
                中文標題titleCht = p.電影編號movie.中文標題titleCht,
            }).ToList();

            return View(datas);
        }
        public ActionResult Edit(int? id)
        {
            MDAContext db = new MDAContext();
            CMovieTypeViewModel datas = null;
            var type = db.片種總表totalTypes.Select(p => p.片種名稱totalTypeName).ToList();
            var cht = db.電影movies.Select(p => p.中文標題titleCht).ToList();
            datas = db.電影片種movieTypes.Where(p => p.電影片種編號mtId == id && p.片種編號typeId== p.片種編號typeId).Select
                (p => new CMovieTypeViewModel
                {
                    movieType = p,
                    //todo 沒辦法修改到第二個
                    //片種名稱totalTypeName = p.片種編號type.片種名稱totalTypeName,
                    中文標題titleCht = p.電影編號movie.中文標題titleCht,

                }).FirstOrDefault();
            datas.titleCht = cht;
            datas.titleType = type;
            return View(datas);
        }
        [HttpPost]
        public IActionResult Edit(CMovieTypeViewModel inType) //post
        {
            MDAContext db = new MDAContext();
            電影片種movieType c = db.電影片種movieTypes.FirstOrDefault(c => c.電影片種編號mtId == inType.電影片種編號mtId);
            if (c != null)
            {
                c.片種編號typeId = db.片種總表totalTypes.FirstOrDefault(q => q.片種名稱totalTypeName == inType.片種名稱totalTypeName).片種編號totalTypeId;
                c.電影編號movieId = db.電影movies.FirstOrDefault(q => q.中文標題titleCht == inType.中文標題titleCht).電影編號movieId;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CMovieTypeViewModel inType)
        {
            MDAContext db = new MDAContext();
            電影片種movieType c = new 電影片種movieType();
            c = inType.movieType;
            c.片種編號typeId = db.片種總表totalTypes.FirstOrDefault(q => q.片種名稱totalTypeName == inType.片種名稱totalTypeName).片種編號totalTypeId;
            c.電影編號movieId = db.電影movies.FirstOrDefault(q => q.中文標題titleCht == inType.中文標題titleCht).電影編號movieId;
            db.電影片種movieTypes.Add(c);
            db.SaveChanges();
            return RedirectToAction("List");
        }

    }
}
