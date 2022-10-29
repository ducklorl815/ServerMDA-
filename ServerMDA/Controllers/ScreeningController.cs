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
    public class ScreeningController : Controller
    {
        private IWebHostEnvironment _enviro;

        public ScreeningController(IWebHostEnvironment p)
        {
            _enviro = p;
        }
        private readonly MDAContext _context;
        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            //var q = _context.場次screenings.Where(c=>c.電影代碼movieCodeNavigation.電影編號movie.電影編號movieId==1).Select
            List<CScreeningViewModel> datas = null;
            datas = db.場次screenings.Select
            (p => new CScreeningViewModel
            {
                screening = p,
                影廳名稱cinemaName = p.影廳編號cinema.影廳名稱cinemaName,
                電影代碼編號movieCodeId = p.電影代碼movieCodeNavigation.電影代碼編號movieCodeId,
                電影名稱 = db.電影movies.Where(x => x.電影編號movieId == p.電影代碼movieCodeNavigation.電影編號movieId).Select(x => x.中文標題titleCht).First(),



            }).ToList();

            return View(datas);
        }
    }
}
