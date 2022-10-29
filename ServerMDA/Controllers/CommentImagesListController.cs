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

            }).ToList();

            return View(datas);
        }
    }
}
