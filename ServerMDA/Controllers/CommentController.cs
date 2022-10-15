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
        public IActionResult List(CKeyWordViewModel model)
        {
            MDAContext db = new MDAContext();
            IEnumerable<電影評論movieComment> datas = null;
            if (string.IsNullOrEmpty(model.txtkeyword))
                datas = from p in db.電影評論movieComments
                        select p;
            else
                datas = db.電影評論movieComments.Where(p => p.評論內容comments.ToLower().Contains(model.txtkeyword.ToLower()) || p.評論標題commentTitle.ToLower().Contains(model.txtkeyword.ToLower()));

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
