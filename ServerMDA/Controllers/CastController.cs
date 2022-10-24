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
    public class CastController : Controller
    {
        private IWebHostEnvironment _enviro;

        public CastController(IWebHostEnvironment p, MDAContext context)
        {
            _enviro = p;
            _context = context;
        }
        private readonly MDAContext _context;
        public IActionResult sortList(int id)
        {
            MDAContext db = new MDAContext();
            List<CCastViewModel> datas = null;
            datas = db.電影主演casts.Where(p=>p.電影編號movieId==id).Select
            (p => new CCastViewModel
            {
                cast = p,
                中文名字nameCht=p.演員編號actor.中文名字nameCht,
                演員照片image = p.演員編號actor.演員照片image,
                英文名字nameEng=p.演員編號actor.英文名字nameEng,
                中文標題titleCht=p.電影編號movie.中文標題titleCht,
            }).ToList();

            return View(datas);
        }
        public ActionResult Edit(int? id)
        {
            MDAContext db = new MDAContext();
            CCastViewModel datas = null;
            datas = db.電影主演casts.Where(p => p.電影編號movieId == id).Select
                (p => new CCastViewModel
                {
                    cast = p,
                    //分級圖片ratingImage = p.電影分級編號rating.分級圖片ratingImage,
                    //分級說明ratingIllustrate = p.電影分級編號rating.分級說明ratingIllustrate,
                    //系列名稱seriesName = p.系列編號series.系列名稱seriesName,

                }).FirstOrDefault();
            return View(datas);
        }
    }
}
