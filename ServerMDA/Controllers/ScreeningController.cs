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
        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CScreeningViewModel> datas = null;
            datas = db.場次screenings.Select
            (p => new CScreeningViewModel
            {
                screening = p,

            }).ToList();

            return View(datas);
        }
    }
}
