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
