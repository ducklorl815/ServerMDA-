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
            var a = db.一般資訊generaInformations.ToList();
          
            var b = db.會員問題memQas;
            var c = db.評分問題rateQas;
            var d = db.評論問題commentQas;
            var e = db.加入片單addlistQas;
            var f = db.訂票問題orderticketQas;
            var g = db.取票問題taketicketQas;
            var h = db.退票問題refundQas;
            var i = db.優惠券couponQas;
            var j = db.購物問題shopQas;

            datas = _MDA.一般資訊generaInformations.Select(p => new CQandAViewModel
            {
                一般資訊GeneraInformationID = p.一般資訊generaInformationId,
                問題Question = p.問題question,
                答案Answer = StripHTML(p.答案answer),
                會員問題memQa = b.ToList(),                
                評分問題rateQa = c.ToList(),
                評論問題commentQa = d.ToList(),
                加入片單addlistQa = e.ToList(),
                訂票問題orderticketQa = f.ToList(),
                取票問題taketicketQa = g.ToList(),
                退票問題refundQa = h.ToList(),
                優惠券couponQa = i.ToList(),
                購物問題shopQa = j.ToList(),
            }).ToList();
            return View(datas);
        }

        public static string StripHTML(string input)
        {
            if (input == null)
                return "";
            return Regex.Replace(input, "<[a-zA-Z/].*?>", String.Empty);
        }
        public IActionResult Edit(int? id)
        {
            MDAContext db = new MDAContext();
            List<CQandAViewModel> datas = null;
            var a = db.一般資訊generaInformations.ToList();
            var b = db.會員問題memQas;
            var c = db.評分問題rateQas;
            var d = db.評論問題commentQas;
            var e = db.加入片單addlistQas;
            var f = db.訂票問題orderticketQas;
            var g = db.取票問題taketicketQas;
            var h = db.退票問題refundQas;
            var i = db.優惠券couponQas;
            var j = db.購物問題shopQas;

            datas = _MDA.一般資訊generaInformations.Select(p => new CQandAViewModel
            {
                一般資訊GeneraInformationID = p.一般資訊generaInformationId,
                問題Question = p.問題question,
                答案Answer = StripHTML(p.答案answer),
                會員問題memQa = b.ToList(),
                評分問題rateQa = c.ToList(),
                評論問題commentQa = d.ToList(),
                加入片單addlistQa = e.ToList(),
                訂票問題orderticketQa = f.ToList(),
                取票問題taketicketQa = g.ToList(),
                退票問題refundQa = h.ToList(),
                優惠券couponQa = i.ToList(),
                購物問題shopQa = j.ToList(),
            }).ToList();
            return View(datas);
        }

        [HttpPost]
        public IActionResult Edit(CQandAViewModel p)
        {
            一般資訊generaInformation m = new 一般資訊generaInformation();
            if(p.一般資訊GeneraInformationID!=0) {
                m.一般資訊generaInformationId = p.一般資訊GeneraInformationID;
            m.問題question = p.問題Question;
            m.答案answer = p.答案Answer;  
            _MDA.SaveChanges();

            }           
            return View();
        }
    }
}
