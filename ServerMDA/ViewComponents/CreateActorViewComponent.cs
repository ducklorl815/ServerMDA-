using Microsoft.AspNetCore.Mvc;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewComponents
{
    public class CreateActorViewComponent:ViewComponent
    {
        private MDAContext _MDA;

        public CreateActorViewComponent(MDAContext MDA)
        {
            _MDA = MDA;
        }

        public IViewComponentResult Invoke()
        {
            List<演員總表actor> list = this._MDA.演員總表actors.ToList();
            return View(list);
        }
    }
}
