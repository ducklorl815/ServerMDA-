//using Microsoft.AspNetCore.Mvc;
//using ServerMDA.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace ServerMDA.Controllers
//{
//    public class DatatablesController1 : Controller
//    {
//        public IActionResult List()
//        {
//            MDAContext db = new MDAContext();
//            IEnumerable<演員總表actor> datas = null;
//                datas = from p in db.演員總表actors
//                        select p;
//            return View(datas);
//        }
//    }
//}
