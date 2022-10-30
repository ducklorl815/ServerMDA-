using Microsoft.AspNetCore.Hosting;
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
        private IWebHostEnvironment _enviro;

        public CouponController(IWebHostEnvironment p)
        {
            _enviro = p;
        }
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
        public ActionResult Create(CCouponViewModel p)
        {
            MDAContext db = new MDAContext();
            優惠總表coupon m = new 優惠總表coupon();
            m = p.coupon;
            db.優惠總表coupons.Add(m);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                MDAContext db = new MDAContext();
                CCouponViewModel datas = null;
                var namelist = db.會員members.OrderBy(p=>p.會員編號memberId).Select(p => p.姓氏lName + p.名字fName).Distinct().ToList();
                var namecou = db.優惠總表coupons.OrderBy(p => p.優惠編號couponId).Select(p => p.優惠名稱couponName).Distinct().ToList();
                datas = db.優惠明細couponLists.Where(p => p.會員編號memberId == id).Select
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

                    }).FirstOrDefault();
                datas.titleName = namelist;
                datas.titleCou = namecou;
                return View(datas);
            }
            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Edit(CCouponViewModel inCoupon) //post
        {
            MDAContext db = new MDAContext();
            優惠明細couponList c = db.優惠明細couponLists.FirstOrDefault(c => c.會員編號memberId == inCoupon.會員編號memberId);
            if (c != null)
            {
                c.優惠明細編號couponListId = inCoupon.優惠明細編號couponListId;
                c.會員編號memberId = inCoupon.會員編號memberId;
                c.優惠編號couponId = inCoupon.優惠編號couponId;
                c.是否使用優惠oxCouponUsing = inCoupon.是否使用優惠oxCouponUsing;
                c.訂單編號orderId = inCoupon.訂單編號orderId;

                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}
