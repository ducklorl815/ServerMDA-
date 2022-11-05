using Microsoft.AspNetCore.Mvc;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewComponents
{
    public class SeriesViewComponent:ViewComponent
    {
        private MDAContext _MDA;

        public SeriesViewComponent(MDAContext MDA)
        {
            _MDA = MDA;
        }

        public IViewComponentResult Invoke()
        {
            List<系列電影movieSeries> list = this._MDA.系列電影movieSeries.ToList();
            return View(list);
        }
    }
}
