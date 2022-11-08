using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ServerMDA.Models;
using ServerMDA.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ServerMDA.Controllers
{
    public class QandAController : Controller
    {
        private IWebHostEnvironment _enviro;
        private readonly MDAContext _MDA;
        public QandAController(IWebHostEnvironment enviro, MDAContext MDA)
        {
            _enviro = enviro;
            _MDA = MDA;
        }
        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;
            datas = _MDA.一般資訊generaInformations.Select(p => new CQandAViewModel
            {
                一般資訊GeneraInformationID = p.一般資訊generaInformationId,
                問題Question = p.問題question,
                答案Answer = StripHTML(p.答案answer),
            }).ToList();
            return View(datas);
        }

        public static string StripHTML(string input)
        {
            if (input == null)
                return "";
            return Regex.Replace(input, "<[a-zA-Z/].*?>", String.Empty);
        }

        public IActionResult Edit(List<int?> id)
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;
            var a = db.一般資訊generaInformations.ToList();

            datas = _MDA.一般資訊generaInformations.Select(p => new CQandAViewModel
            {
                一般資訊GeneraInformationID = p.一般資訊generaInformationId,
                問題Question = p.問題question,
                答案Answer = StripHTML(p.答案answer),
            }).ToList();
            return View(datas);
        }

        public IActionResult Edit2(List<int?> id)
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;
            var a = db.會員問題memQas.ToList();

            datas = _MDA.會員問題memQas.Select(p => new CQandAViewModel
            {
                會員問題memQaId = p.會員問題memQaId,
                會員問題Question = p.問題question,
                會員答案Answer = StripHTML(p.答案answer),
            }).ToList();
            return View(datas);
        }

        public IActionResult Edit3(List<int?> id)
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;
            var a = db.評分問題rateQas.ToList();

            datas = _MDA.評分問題rateQas.Select(p => new CQandAViewModel
            {
                評分問題rateQaId = p.評分問題rateQaId,
                評分問題Question = p.問題question,
                評分答案Answer = StripHTML(p.答案answer),
            }).ToList();
            return View(datas);
        }

        public IActionResult Edit4(List<int?> id)
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;
            var a = db.評論問題commentQas.ToList();

            datas = _MDA.評論問題commentQas.Select(p => new CQandAViewModel
            {
                評論問題commentQaId = p.評論問題commentQaId,
                評論問題Question = p.問題question,
                評論答案Answer = StripHTML(p.答案answer),
            }).ToList();
            return View(datas);
        }

        public IActionResult Edit5(List<int?> id)
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;
            var a = db.加入片單addlistQas.ToList();

            datas = _MDA.加入片單addlistQas.Select(p => new CQandAViewModel
            {
                加入片單addlistQaId = p.加入片單addlistQaId,
                加入片單Question = p.問題question,
                加入片單Answer = StripHTML(p.答案answer),
            }).ToList();
            return View(datas);
        }

        public IActionResult Edit6(List<int?> id)
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;
            var a = db.訂票問題orderticketQas.ToList();

            datas = _MDA.訂票問題orderticketQas.Select(p => new CQandAViewModel
            {
                訂票問題orderticketQaId = p.訂票問題orderticketQaId,
                訂票問題Question = p.問題question,
                訂票問題Answer = StripHTML(p.答案answer),
            }).ToList();
            return View(datas);
        }

        public IActionResult Edit7(List<int?> id)
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;
            var a = db.取票問題taketicketQas.ToList();

            datas = _MDA.取票問題taketicketQas.Select(p => new CQandAViewModel
            {
                取票問題taketicketQaId = p.取票問題taketicketQaId,
                取票問題Question = p.問題question,
                取票問題Answer = StripHTML(p.答案answer),
            }).ToList();
            return View(datas);
        }

        public IActionResult Edit8(List<int?> id)
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;
            var a = db.退票問題refundQas.ToList();

            datas = _MDA.退票問題refundQas.Select(p => new CQandAViewModel
            {
                退票問題refundQaId = p.退票問題refundQaId,
                退票問題Question = p.問題question,
                退票問題Answer = StripHTML(p.答案answer),
            }).ToList();
            return View(datas);
        }

        public IActionResult Edit9(List<int?> id)
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;
            var a = db.優惠券couponQas.ToList();

            datas = _MDA.優惠券couponQas.Select(p => new CQandAViewModel
            {
                優惠券couponQaId = p.優惠券couponQaId,
                優惠券問題Question = p.問題question,
                優惠券問題Answer = StripHTML(p.答案answer),
            }).ToList();
            return View(datas);
        }

        public IActionResult Edit10(List<int?> id)
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;
            var a = db.購物問題shopQas.ToList();

            datas = _MDA.購物問題shopQas.Select(p => new CQandAViewModel
            {
                購物問題shopQaId = p.購物問題shopQaId,
                購物問題Question = p.問題question,
                購物問題Answer = StripHTML(p.答案answer),
            }).ToList();
            return View(datas);
        }

        [HttpPost]
        public IActionResult Edit(List<CQandAViewModel> p)
        {
            MDAContext db = new MDAContext();
            一般資訊generaInformation m = new 一般資訊generaInformation();
            foreach (var i in p)
            {
                if (i.一般資訊GeneraInformationID != 0)
                {
                    m.一般資訊generaInformationId = i.一般資訊GeneraInformationID;
                    m.問題question = i.問題Question;
                    m.答案answer = i.答案Answer;
                    db.SaveChanges();

                }
            }
            return View();
        }

        #region list vp
        public IActionResult memberlist()
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;

            datas = _MDA.會員問題memQas.Select(p => new CQandAViewModel
            {
                會員問題memQaId = p.會員問題memQaId,
                會員問題Question = p.問題question,
                會員答案Answer = StripHTML(p.答案answer),
            }).ToList();
            return ViewComponent("會員問題", datas);
        }

        public IActionResult normallist()
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;

            datas = _MDA.一般資訊generaInformations.Select(p => new CQandAViewModel
            {
                一般資訊GeneraInformationID = p.一般資訊generaInformationId,
                問題Question = p.問題question,
                答案Answer = StripHTML(p.答案answer),

            }).ToList();
            return ViewComponent("一般資訊", datas);
        }

        public IActionResult ratelist()
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;

            datas = _MDA.評分問題rateQas.Select(p => new CQandAViewModel
            {
                評分問題rateQaId = p.評分問題rateQaId,
                評分問題Question = p.問題question,
                評分答案Answer = StripHTML(p.答案answer),

            }).ToList();
            return ViewComponent("評分問題", datas);
        }

        public IActionResult commentlist()
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;

            datas = _MDA.評論問題commentQas.Select(p => new CQandAViewModel
            {
                評論問題commentQaId = p.評論問題commentQaId,
                評論問題Question = p.問題question,
                評論答案Answer = StripHTML(p.答案answer),

            }).ToList();
            return ViewComponent("評論問題", datas);
        }

        public IActionResult mylistlist()
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;

            datas = _MDA.加入片單addlistQas.Select(p => new CQandAViewModel
            {
                加入片單addlistQaId = p.加入片單addlistQaId,
                加入片單Question = p.問題question,
                加入片單Answer = StripHTML(p.答案answer),

            }).ToList();
            return ViewComponent("加入片單", datas);
        }

        public IActionResult orderlist()
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;

            datas = _MDA.訂票問題orderticketQas.Select(p => new CQandAViewModel
            {
                訂票問題orderticketQaId = p.訂票問題orderticketQaId,
                訂票問題Question = p.問題question,
                訂票問題Answer = StripHTML(p.答案answer),

            }).ToList();
            return ViewComponent("訂票問題", datas);
        }

        public IActionResult pickuplist()
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;

            datas = _MDA.取票問題taketicketQas.Select(p => new CQandAViewModel
            {
                取票問題taketicketQaId = p.取票問題taketicketQaId,
                取票問題Question = p.問題question,
                取票問題Answer = StripHTML(p.答案answer),

            }).ToList();
            return ViewComponent("取票問題", datas);
        }

        public IActionResult returnlist()
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;

            datas = _MDA.退票問題refundQas.Select(p => new CQandAViewModel
            {
                退票問題refundQaId = p.退票問題refundQaId,
                退票問題Question = p.問題question,
                退票問題Answer = StripHTML(p.答案answer),

            }).ToList();
            return ViewComponent("退票問題", datas);
        }

        public IActionResult couponlist()
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;

            datas = _MDA.優惠券couponQas.Select(p => new CQandAViewModel
            {
                優惠券couponQaId = p.優惠券couponQaId,
                優惠券問題Question = p.問題question,
                優惠券問題Answer = StripHTML(p.答案answer),

            }).ToList();
            return ViewComponent("優惠券", datas);
        }

        public IActionResult shoplist()
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;

            datas = _MDA.購物問題shopQas.Select(p => new CQandAViewModel
            {
                購物問題shopQaId = p.購物問題shopQaId,
                購物問題Question = p.問題question,
                購物問題Answer = StripHTML(p.答案answer),

            }).ToList();
            return ViewComponent("購物問題", datas);
        }
        #endregion

        #region 新增
        public ActionResult Create1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create1(CQandAViewModel p)
        {
            MDAContext db = new MDAContext();
            if (p.qtype == 1)
            {
                一般資訊generaInformation m = new 一般資訊generaInformation();
                m.問題question = p.問題Question;
                m.答案answer = p.答案Answer;
                db.一般資訊generaInformations.Add(m);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else if (p.qtype == 2)
            {
                會員問題memQa mq = new 會員問題memQa();
                mq.問題question = p.會員問題Question;
                mq.答案answer = p.會員答案Answer;
                db.會員問題memQas.Add(mq);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else if (p.qtype == 3)
            {
                評分問題rateQa rq = new 評分問題rateQa();
                rq.問題question = p.會員問題Question;
                rq.答案answer = p.會員答案Answer;
                db.評分問題rateQas.Add(rq);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else if (p.qtype == 4)
            {
                評論問題commentQa cq = new 評論問題commentQa();
                cq.問題question = p.會員問題Question;
                cq.答案answer = p.會員答案Answer;
                db.評論問題commentQas.Add(cq);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else if (p.qtype == 5)
            {
                加入片單addlistQa aq = new 加入片單addlistQa();
                aq.問題question = p.會員問題Question;
                aq.答案answer = p.會員答案Answer;
                db.加入片單addlistQas.Add(aq);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else if (p.qtype == 6)
            {
                訂票問題orderticketQa oq = new 訂票問題orderticketQa();
                oq.問題question = p.會員問題Question;
                oq.答案answer = p.會員答案Answer;
                db.訂票問題orderticketQas.Add(oq);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else if (p.qtype == 7)
            {
                取票問題taketicketQa gq = new 取票問題taketicketQa();
                gq.問題question = p.會員問題Question;
                gq.答案answer = p.會員答案Answer;
                db.取票問題taketicketQas.Add(gq);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else if (p.qtype == 8)
            {
                退票問題refundQa rq = new 退票問題refundQa();
                rq.問題question = p.會員問題Question;
                rq.答案answer = p.會員答案Answer;
                db.退票問題refundQas.Add(rq);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else if (p.qtype == 9)
            {
                優惠券couponQa cq = new 優惠券couponQa();
                cq.問題question = p.會員問題Question;
                cq.答案answer = p.會員答案Answer;
                db.優惠券couponQas.Add(cq);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                購物問題shopQa sq = new 購物問題shopQa();
                sq.問題question = p.會員問題Question;
                sq.答案answer = p.會員答案Answer;
                db.購物問題shopQas.Add(sq);
                db.SaveChanges();
                return RedirectToAction("List");
            }

        }
        #endregion
    }
}
