using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ServerMDA.Models;
using ServerMDA.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.Controllers
{
    public class CommentImageController : Controller
    {
        private IWebHostEnvironment _enviro;

        public CommentImageController(IWebHostEnvironment p)
        {
            _enviro = p;
        }
        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CCommentImageViewModel> datas = null;
            datas = db.評論圖片總表commentImages.Select
            (p => new CCommentImageViewModel
            {
                commentImage = p,

            }).ToList();

            return View(datas);
        }
        public ActionResult Edit(int? id)
        {
            MDAContext db = new MDAContext();
            CCommentImageViewModel datas = null;
            datas = db.評論圖片總表commentImages.Where(p => p.評論圖庫編號commentImageId == id).Select
                (p => new CCommentImageViewModel
                {
                    commentImage = p,

                }).FirstOrDefault();

            return View(datas);
        }
        [HttpPost]
        public IActionResult Edit(CCommentImageViewModel inComment) //post
        {
            MDAContext db = new MDAContext();
            評論圖片總表commentImage c = db.評論圖片總表commentImages.FirstOrDefault(c => c.評論圖庫編號commentImageId == inComment.評論圖庫編號commentImageId);
            if (c != null)
            {
                if (inComment.photo != null)
                {
                    string pName = Guid.NewGuid().ToString() + ".jpg";
                    c.圖片image = pName;
                    string path = _enviro.WebRootPath + "/images/Comment/" + pName;
                    inComment.photo.CopyTo(new FileStream(path, FileMode.Create));
                }
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
        public ActionResult Create(評論圖片總表commentImage p, CCommentImageViewModel inComment)
        {
            MDAContext db = new MDAContext();

            string pName = Guid.NewGuid().ToString() + ".jpg";
            string path = _enviro.WebRootPath + "/images/Comment/" + pName;
            inComment.photo.CopyTo(new FileStream(path, FileMode.Create));

            p.圖片image = pName;

            db.評論圖片總表commentImages.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
