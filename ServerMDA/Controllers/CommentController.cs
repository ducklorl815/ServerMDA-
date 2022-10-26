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
    public class CommentController : Controller
    {
        private IWebHostEnvironment _enviro;

        public CommentController(IWebHostEnvironment p)
        {
            _enviro = p;
        }
        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CCommentViewModel> datas = null;
            datas = db.電影評論movieComments.Select
            (p => new CCommentViewModel
            {
                comment = p,
                會員電話cellphone = p.會員編號member.會員電話cellphone,
                姓氏lName = p.會員編號member.姓氏lName,
                名字fName = p.會員編號member.名字fName,
                中文標題titleCht = p.電影編號movie.中文標題titleCht,
                英文標題titleEng = p.電影編號movie.英文標題titleEng,
                公開等級public=p.公開等級編號public.公開等級public,
            }).ToList();

            return View(datas);
        }
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                MDAContext db = new MDAContext();
                電影評論movieComment comment = db.電影評論movieComments.FirstOrDefault(p => p.評論編號commentId == id);
                if (comment != null)
                    return View(comment);
            }
            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Edit(CCommentViewModel inComment) //post
        {
            MDAContext db = new MDAContext();
            電影評論movieComment c = db.電影評論movieComments.FirstOrDefault(c => c.評論編號commentId == inComment.評論編號commentId);
            if (c != null)
            {
                c.評論編號commentId = inComment.評論編號commentId;
                c.會員編號memberId = inComment.會員編號memberId;
                c.電影編號movieId = inComment.電影編號movieId;
                c.評分rate = inComment.評分rate;
                c.期待度anticipation = inComment.期待度anticipation;
                c.評論標題commentTitle = inComment.評論標題commentTitle;
                c.評論內容comments = inComment.評論內容comments;
                c.發佈時間commentTime = inComment.發佈時間commentTime;
                c.觀影日期viewingTime = inComment.觀影日期viewingTime;
                c.觀影方式source = inComment.觀影方式source;
                c.公開等級編號publicId = inComment.公開等級編號publicId;
                c.是否開放討論串oxFloor = inComment.是否開放討論串oxFloor;
                c.屏蔽invisible = inComment.屏蔽invisible;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(電影評論movieComment p)
        {
            MDAContext db = new MDAContext();

            db.電影評論movieComments.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
