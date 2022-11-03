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
    public class TheaterController : Controller
    {
        private IWebHostEnvironment _enviro;
        private MDAContext _MDA;

        public TheaterController(IWebHostEnvironment p, MDAContext MDA)
        {
            _enviro = p;
            _MDA = MDA;
        }

        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            db.影城mainTheaters.ToList();
            db.電影院theaters.ToList();
            db.影廳cinemas.ToList();
            List<CTheaterViewModel> datas = null;
            datas = db.電影院theaters.Select
            (p => new CTheaterViewModel
            {
                theater = p,
                影城名稱mainTheaterName = p.影城編號mainTheater.影城名稱mainTheaterName
            }).ToList();

            return View(datas);
        }

        public IActionResult TheaterInfo(int theaterId)
        {

            return ViewComponent("TheaterInfo", theaterId);
        }

        public IActionResult EditSeatMap(int cinemaid)
        {
            影廳cinema cinema = this._MDA.影廳cinemas
                                    .Where(c => c.影廳編號cinemaId == cinemaid)
                                    .FirstOrDefault();

            return View(cinema);
        }

        public class _SaveSeatInfo
        {
            public int cinemaID { get; set; }
            public string seatInfo { get; set; }
        }

        public IActionResult SaveSeatInfo(_SaveSeatInfo saveInfo)
        {
            var q = this._MDA.影廳cinemas
                      .Where(c => c.影廳編號cinemaId == saveInfo.cinemaID).FirstOrDefault();
            string seatInfo = saveInfo.seatInfo.Replace('#', '@');
            seatInfo = seatInfo.Trim();
            q.座位資訊seatInfo = seatInfo;
            this._MDA.SaveChanges();
            return RedirectToAction("List");
        }

        #region Edit
        public ActionResult Edit(int? id)
        {
            MDAContext db = new MDAContext();
            CTheaterViewModel datas = null;
            datas = db.電影院theaters.Where(p => p.電影院編號theaterId == id).Select
            (p => new CTheaterViewModel
            {
                theater = p,
            }).FirstOrDefault();

            return View(datas);
        }
        [HttpPost]
        public IActionResult Edit(CTheaterViewModel intheater) //post
        {
            MDAContext db = new MDAContext();
            電影院theater c = db.電影院theaters.FirstOrDefault(c => c.電影院編號theaterId == intheater.電影院編號theaterId);
            if (c != null)
            {
                if (intheater.photo != null)
                {
                    string pName = Guid.NewGuid().ToString() + ".jpg";
                    c.電影院照片image = pName;
                    string path = _enviro.WebRootPath + "/images/Theater/" + pName;
                    intheater.photo.CopyTo(new FileStream(path, FileMode.Create));
                }

                c.電影院名稱theaterName = intheater.電影院名稱theaterName;
                //c.影城編號mainTheaterId = intheater.影城編號mainTheaterId;
                c.營業時間businessHours = intheater.營業時間businessHours;
                c.電話phone = intheater.電話phone;
                c.地址address = intheater.地址address;
                c.官方網站url = intheater.官方網站url;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
        #endregion

        #region Create

        public ActionResult Create()
        {
            MDAContext db = new MDAContext();
            CTheaterViewModel datas = null;
            var theater = db.影城mainTheaters.Select(p => p.影城名稱mainTheaterName).ToList();
            datas = db.電影院theaters.Select
            (p => new CTheaterViewModel
            {
                theater = p,
                影城名稱mainTheaterName = p.影城編號mainTheater.影城名稱mainTheaterName,

            }).FirstOrDefault();
            datas.titleTheater = theater;
            return View(datas);
        }
        [HttpPost]
        public ActionResult Create(電影院theater p, CTheaterViewModel intheater)
        {
            MDAContext db = new MDAContext();

            string pName = Guid.NewGuid().ToString() + ".jpg";
            string path = _enviro.WebRootPath + "/images/Theater/" + pName;
            intheater.photo.CopyTo(new FileStream(path, FileMode.Create));

            p.影城編號mainTheaterId = db.影城mainTheaters.FirstOrDefault(p => p.影城名稱mainTheaterName == intheater.影城名稱mainTheaterName).影城編號mainTheaterId;
            p.電影院照片image = pName;
            db.電影院theaters.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        #endregion
    }
}