using Microsoft.AspNetCore.Mvc;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewComponents
{
    public class CreateDirctorViewComponent:ViewComponent
    {
        private MDAContext _MDA;

        public CreateDirctorViewComponent(MDAContext MDA)
        {
            _MDA = MDA;
        }

        public IViewComponentResult Invoke()
        {
            var q = this._MDA.導演總表directors.ToList();
            return View(q);
        }
    }
}
