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
    public class CommentImagesListController : Controller
    {
        private IWebHostEnvironment _enviro;

        public CommentImagesListController(IWebHostEnvironment p)
        {
            _enviro = p;
        }
        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CCommentImagesListViewModel> datas = null;
            datas = db.評論圖片明細commentImagesLists.Select
            (p => new CCommentImagesListViewModel
            {
                ImagesList = p,
                圖片image = p.評論圖庫編號commentImage.圖片image,
                評論標題commentTitle = p.評論編號comment.評論標題commentTitle,

            }).ToList();

            return View(datas);
        }
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                MDAContext db = new MDAContext();
                CCommentImagesListViewModel datas = null;
                var comm = db.電影評論movieComments.Select(p => p.評論標題commentTitle).Distinct().ToList();
                datas = db.評論圖片明細commentImagesLists.Where(p => p.評論圖庫編號commentImageId == id).Select
                    (p => new CCommentImagesListViewModel
                    {
                        ImagesList = p,
                        圖片image=p.評論圖庫編號commentImage.圖片image,
                        評論標題commentTitle=p.評論編號comment.評論標題commentTitle,

                    }).FirstOrDefault();
                datas.titleComm = comm;
                return View(datas);
            }

            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Edit(CCommentImagesListViewModel inList) //post
        {
            MDAContext db = new MDAContext();
            評論圖片明細commentImagesList c = db.評論圖片明細commentImagesLists.FirstOrDefault(c => c.評論圖庫編號commentImageId == inList.評論圖庫編號commentImageId);
            if (c != null)
            {
                c.評論圖庫編號commentImageId = inList.評論圖庫編號commentImageId;
                c.評論編號commentId = inList.評論編號commentId;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}
