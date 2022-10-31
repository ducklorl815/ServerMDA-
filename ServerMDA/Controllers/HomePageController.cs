using Microsoft.AspNetCore.Mvc;
using ServerMDA.Models;
using ServerMDA.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            CTheaterViewModel datas = null;
            var theater = db.電影院theaters.Select(p => p.電影院名稱theaterName).ToList();
            datas = db.電影院theaters.Select
            (p => new CTheaterViewModel
            {
                theater = p,

            }).FirstOrDefault();
            datas.titleTheater = theater;
            return View(datas);
        }
    }
}
