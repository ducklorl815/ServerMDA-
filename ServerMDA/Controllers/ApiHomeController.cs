using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServerMDA.Models;
using ServerMDA.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
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

        public IActionResult addBonus(int[] arrId, int arrToDo)
        {
            foreach (var i in arrId)
            {
                var q = _MDA.會員members.Where(p => p.會員編號memberId == i).FirstOrDefault();
                q.紅利點數bonus = q.紅利點數bonus + arrToDo;
            }
            _MDA.SaveChanges();
            return Content("1", "text/plain");
        }

        //QA修改
        public IActionResult editqa(/*int[] arrId, string[] arrQ, string[] arrA*/ string jsonString)
        {
            List<C1Cheng> qA = JsonSerializer.Deserialize<List<C1Cheng>>(jsonString);
            MDAContext db = new MDAContext();
            foreach (var a in qA)
            {

                一般資訊generaInformation c = db.一般資訊generaInformations.FirstOrDefault(c => c.一般資訊generaInformationId == a.arrID);
                if (c != null)
                {
                    c.問題question = a.arrQ;
                    c.答案answer = a.arrA;
                }
            }
            db.SaveChanges();

            //for (int i = 0; i < arrId.Length;i++ )
            //{
            //    MDAContext db = new MDAContext();
            //    一般資訊generaInformation c = db.一般資訊generaInformations.FirstOrDefault(c => c.一般資訊generaInformationId == arrId[i]);
            //    if (c != null)
            //    {
            //        c.問題question = arrQ[i];
            //        c.答案answer = arrA[i];
            //        db.SaveChanges();
            //    }
            //}
            //_MDA.SaveChanges();
            return Json("1");
        }

        public IActionResult editqa2(string jsonString)
        {
            List<C1Cheng> qA = JsonSerializer.Deserialize<List<C1Cheng>>(jsonString);
            MDAContext db = new MDAContext();
            foreach (var a in qA)
            {

                會員問題memQa c = db.會員問題memQas.FirstOrDefault(c => c.會員問題memQaId == a.arrID);
                if (c != null)
                {
                    c.問題question = a.arrQ;
                    c.答案answer = a.arrA;
                }
            }
            db.SaveChanges();
            return Json("1");
        }

        public IActionResult editqa3(string jsonString)
        {
            List<C1Cheng> qA = JsonSerializer.Deserialize<List<C1Cheng>>(jsonString);
            MDAContext db = new MDAContext();
            foreach (var a in qA)
            {

                評分問題rateQa c = db.評分問題rateQas.FirstOrDefault(c => c.評分問題rateQaId == a.arrID);
                if (c != null)
                {
                    c.問題question = a.arrQ;
                    c.答案answer = a.arrA;
                }
            }
            db.SaveChanges();
            return Json("1");
        }

        public IActionResult editqa4(string jsonString)
        {
            List<C1Cheng> qA = JsonSerializer.Deserialize<List<C1Cheng>>(jsonString);
            MDAContext db = new MDAContext();
            foreach (var a in qA)
            {

                評論問題commentQa c = db.評論問題commentQas.FirstOrDefault(c => c.評論問題commentQaId == a.arrID);
                if (c != null)
                {
                    c.問題question = a.arrQ;
                    c.答案answer = a.arrA;
                }
            }
            db.SaveChanges();
            return Json("1");
        }

        public IActionResult editqa5(string jsonString)
        {
            List<C1Cheng> qA = JsonSerializer.Deserialize<List<C1Cheng>>(jsonString);
            MDAContext db = new MDAContext();
            foreach (var a in qA)
            {

                加入片單addlistQa c = db.加入片單addlistQas.FirstOrDefault(c => c.加入片單addlistQaId == a.arrID);
                if (c != null)
                {
                    c.問題question = a.arrQ;
                    c.答案answer = a.arrA;
                }
            }
            db.SaveChanges();
            return Json("1");
        }

        public IActionResult editqa6(string jsonString)
        {
            List<C1Cheng> qA = JsonSerializer.Deserialize<List<C1Cheng>>(jsonString);
            MDAContext db = new MDAContext();
            foreach (var a in qA)
            {

                訂票問題orderticketQa c = db.訂票問題orderticketQas.FirstOrDefault(c => c.訂票問題orderticketQaId == a.arrID);
                if (c != null)
                {
                    c.問題question = a.arrQ;
                    c.答案answer = a.arrA;
                }
            }
            db.SaveChanges();
            return Json("1");
        }

        public IActionResult editqa7(string jsonString)
        {
            List<C1Cheng> qA = JsonSerializer.Deserialize<List<C1Cheng>>(jsonString);
            MDAContext db = new MDAContext();
            foreach (var a in qA)
            {

                取票問題taketicketQa c = db.取票問題taketicketQas.FirstOrDefault(c => c.取票問題taketicketQaId == a.arrID);
                if (c != null)
                {
                    c.問題question = a.arrQ;
                    c.答案answer = a.arrA;
                }
            }
            db.SaveChanges();
            return Json("1");
        }

        public IActionResult editqa8(string jsonString)
        {
            List<C1Cheng> qA = JsonSerializer.Deserialize<List<C1Cheng>>(jsonString);
            MDAContext db = new MDAContext();
            foreach (var a in qA)
            {

                退票問題refundQa c = db.退票問題refundQas.FirstOrDefault(c => c.退票問題refundQaId == a.arrID);
                if (c != null)
                {
                    c.問題question = a.arrQ;
                    c.答案answer = a.arrA;
                }
            }
            db.SaveChanges();
            return Json("1");
        }

        public IActionResult editqa9(string jsonString)
        {
            List<C1Cheng> qA = JsonSerializer.Deserialize<List<C1Cheng>>(jsonString);
            MDAContext db = new MDAContext();
            foreach (var a in qA)
            {

                優惠券couponQa c = db.優惠券couponQas.FirstOrDefault(c => c.優惠券couponQaId == a.arrID);
                if (c != null)
                {
                    c.問題question = a.arrQ;
                    c.答案answer = a.arrA;
                }
            }
            db.SaveChanges();
            return Json("1");
        }

        public IActionResult editqa10(string jsonString)
        {
            List<C1Cheng> qA = JsonSerializer.Deserialize<List<C1Cheng>>(jsonString);
            MDAContext db = new MDAContext();
            foreach (var a in qA)
            {

                購物問題shopQa c = db.購物問題shopQas.FirstOrDefault(c => c.購物問題shopQaId == a.arrID);
                if (c != null)
                {
                    c.問題question = a.arrQ;
                    c.答案answer = a.arrA;
                }
            }
            db.SaveChanges();
            return Json("1");
        }

    }
}
