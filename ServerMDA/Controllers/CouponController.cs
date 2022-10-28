using Microsoft.AspNetCore.Mvc;
using ServerMDA.Models;
using ServerMDA.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.Controllers
{
    public class CouponController : Controller
    {
        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CCouponViewModel> datas = null;
            datas = db.優惠明細couponLists.Select
            (p => new CCouponViewModel
            {
                couponList = p,

                會員電話cellphone = p.會員編號member.會員電話cellphone,
                姓氏lName = p.會員編號member.姓氏lName,
                名字fName = p.會員編號member.名字fName,

                優惠名稱couponName = p.優惠編號coupon.優惠名稱couponName,
                優惠截止日期couponDueDate = p.優惠編號coupon.優惠截止日期couponDueDate,
                優惠所需紅利bonusCost = p.優惠編號coupon.優惠所需紅利bonusCost,
                優惠代碼couponCode = p.優惠編號coupon.優惠代碼couponCode,
                優惠折扣couponDiscount = p.優惠編號coupon.優惠折扣couponDiscount,

            }).ToList();

            return View(datas);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(優惠總表coupon p)
        {
            MDAContext db = new MDAContext();
            db.優惠總表coupons.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
