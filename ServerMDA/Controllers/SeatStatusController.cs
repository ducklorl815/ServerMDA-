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
    public class SeatStatusController : Controller
    {
        private IWebHostEnvironment _enviro;

        public SeatStatusController(IWebHostEnvironment p)
        {
            _enviro = p;
        }
        private readonly MDAContext _context;

        public IActionResult List()
        {
            //MDAContext db = new MDAContext();
            //List<CSeatStatusViewModel> datas = null;
            //datas = db.出售座位狀態seatStatuses.Select
            //(p => new CSeatStatusViewModel
            //{
            //    seatStatus = p,

            //    放映開始時間playTime = p.場次編號screening.放映開始時間playTime,
            //    放映日期playDate = p.場次編號screening.放映日期playDate,

            //}).ToList();

            //return View(datas);




            MDAContext db = new MDAContext();
            List<CSeatStatusViewModel> datas = null;
            datas = db.出售座位狀態seatStatuses.Select
            (i => new CSeatStatusViewModel
            {
                seatStatus = i,
                //a = i.出售座位資訊seatSoldInfo,
                放映開始時間playTime = i.場次編號screening.放映開始時間playTime,
                放映日期playDate = i.場次編號screening.放映日期playDate,

                影廳名稱 = i.場次編號screening.影廳編號cinema.影廳名稱cinemaName,
                電影名稱 = i.場次編號screening.電影代碼movieCodeNavigation.電影編號movie.中文標題titleCht,
            }).ToList();
            return View(datas);
        }
    }
}
