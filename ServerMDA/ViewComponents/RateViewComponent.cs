using Microsoft.AspNetCore.Mvc;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewComponents
{
    public class RateViewComponent:ViewComponent
    {
        private MDAContext _MDA;

        public RateViewComponent(MDAContext MDA)
        {
            _MDA = MDA;
        }

        public IViewComponentResult Invoke()
        {
            List<電影分級movieRating> list = this._MDA.電影分級movieRatings.ToList();
            return View(list);
        }
    }
}
