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
    public class CinemaController : Controller
    {
        private IWebHostEnvironment _enviro;

        public CinemaController(IWebHostEnvironment p)
        {
            _enviro = p;
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

            var theater = db.電影院theaters.Select(p => p.電影院名稱theaterName).ToList();
            var clsName = db.影廳cinemas.Select(p => p.廳種名稱cinemaClsName).Distinct().ToList();

            datas = db.影廳cinemas.Where(p => p.影廳編號cinemaId == id).Select
                (p => new CCinemaViewModel
                {
                    cinema = p,
                    電影院名稱theaterName = p.電影院編號theater.電影院名稱theaterName,

                }).FirstOrDefault();
            datas.ListTheater = theater;
            datas.ListClsName = clsName;
            return View(datas);
        }
        [HttpPost]
        public IActionResult Edit(CCinemaViewModel inCinema) //post
        {
            MDAContext db = new MDAContext();
            影廳cinema c = db.影廳cinemas.FirstOrDefault(c => c.影廳編號cinemaId == inCinema.影廳編號cinemaId);
            if (c != null)
            {
                if (inCinema.photo != null)
                {
                    string pName = Guid.NewGuid().ToString() + ".jpg";
                    c.影廳照片image = pName;
                    string path = _enviro.WebRootPath + "/images/Cinema/" + pName;
                    inCinema.photo.CopyTo(new FileStream(path, FileMode.Create));
                }
                c.影廳編號cinemaId = inCinema.影廳編號cinemaId;
                c.影廳名稱cinemaName = inCinema.影廳名稱cinemaName;
                c.電影院編號theaterId = inCinema.電影院編號theaterId;
                c.廳種名稱cinemaClsName = inCinema.廳種名稱cinemaClsName;
                c.座位資訊seatInfo = inCinema.座位資訊seatInfo;
                c.電影院編號theaterId = db.電影院theaters.FirstOrDefault(q => q.電影院名稱theaterName == inCinema.電影院名稱theaterName).電影院編號theaterId;

          
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
        public ActionResult Create()
        {
            MDAContext db = new MDAContext();
            CCinemaViewModel datas = null;
            datas = db.影廳cinemas.Select
            (p => new CCinemaViewModel
            {
               cinema = p,
               電影院名稱theaterName = p.電影院編號theater.電影院名稱theaterName,
            }).FirstOrDefault();
            var clsName = db.影廳cinemas.Select(p => p.廳種名稱cinemaClsName).Distinct().ToList();
            var theater = db.電影院theaters.Select(p => p.電影院名稱theaterName).ToList();
            var seat = db.影廳cinemas.Select(p => p.座位資訊seatInfo).ToList();
            datas.ListTheater = theater;
            datas.ListClsName = clsName;
            datas.ListSeat = seat;
            return View(datas);
        }
        [HttpPost]
        public ActionResult Create(CCinemaViewModel inCinema)
        {
            MDAContext db = new MDAContext();
            影廳cinema p = new 影廳cinema();

            string pName = Guid.NewGuid().ToString() + ".jpg";
            p.影廳照片image = pName;
            string path = _enviro.WebRootPath + "/images/Cinema/" + pName;
            inCinema.photo.CopyTo(new FileStream(path, FileMode.Create));

            p.影廳名稱cinemaName = inCinema.影廳名稱cinemaName;
            p.電影院編號theaterId = db.電影院theaters.FirstOrDefault(q => q.電影院名稱theaterName == inCinema.電影院名稱theaterName).電影院編號theaterId;
            p.廳種名稱cinemaClsName = inCinema.廳種名稱cinemaClsName;
            p.座位資訊seatInfo = inCinema.座位資訊seatInfo;

            db.影廳cinemas.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult series(int id)
        {
            var series = _context.電影院theaters.Where(p => p.電影院編號theaterId != id).Select(a => a.電影院名稱theaterName).ToList();
            return Json(series);
        }
    }
}
