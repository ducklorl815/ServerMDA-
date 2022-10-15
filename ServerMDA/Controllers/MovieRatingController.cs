using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.Controllers
{
    public class MovieRatingController : Controller
    {
        private IWebHostEnvironment _enviro;

        public MovieRatingController(IWebHostEnvironment p)
        {
            _enviro = p;
        }
        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            var datas = from p in db.電影movies
                    select p;
            return View(datas);
        }
    }
}
