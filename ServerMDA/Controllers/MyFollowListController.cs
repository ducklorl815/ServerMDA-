using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.Controllers
{
    public class MyFollowListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
