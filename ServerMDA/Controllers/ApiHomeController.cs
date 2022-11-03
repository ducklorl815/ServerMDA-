using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.Controllers
{
    public class ApiHomeController : Controller
    {
        private readonly ILogger<ApiHomeController> _logger;
        private readonly MDAContext _MDA;
        public ApiHomeController(ILogger<ApiHomeController> logger, MDAContext MDA)
        {
            _logger = logger;
            _MDA = MDA;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult addCoupon(int[] arrId, int arrToDo)
        {
            foreach (var i in arrId)
            {
                優惠明細couponList o = new 優惠明細couponList
                {
                    會員編號memberId = i,
                    優惠編號couponId = arrToDo,
                    是否使用優惠oxCouponUsing = false,
                };
                _MDA.優惠明細couponLists.Add(o);
            }
            _MDA.SaveChanges();
            return Content("1", "text/plain");
        }

        public IActionResult addPermission(int[] arrId, int arrToDo)
        {
            foreach (var i in arrId)
            {
                var q = _MDA.會員members.Where(p => p.會員編號memberId == i).FirstOrDefault();
                q.會員權限permission = arrToDo;
            }
            _MDA.SaveChanges();
            return Content("1", "text/plain");
        }

        public IActionResult addFormal(int[] arrId, int arrToDo)
        {
            foreach (var i in arrId)
            {
                var q = _MDA.會員members.Where(p => p.會員編號memberId == i).FirstOrDefault();
                q.正式會員formal = Convert.ToBoolean(arrToDo);
            }
            _MDA.SaveChanges();
            return Content("1", "text/plain");
        }
    }
}
