using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.Controllers
{
    public class PBIController : Controller
    {
        public IActionResult PBI()
        {
            return View();
        }
    }
}
