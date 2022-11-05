using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
    public class MultPicController : Controller
    {
        private IWebHostEnvironment _enviro;

        public MultPicController(IWebHostEnvironment p, MDAContext context)
        {
            _enviro = p;
            _context = context;
        }
        private readonly MDAContext _context;
        List<string> imagetype = new List<string> { "海報", "劇照", "未分類" };
        List<int> invisible = new List<int> { 0, 1 };
        [HttpGet]
        public ActionResult Create()
        {
            MDAContext db = new MDAContext();
            CCreateTravelProductViewModel datas = null;
            datas = db.電影圖片總表movieImages.Select
                (p => new CCreateTravelProductViewModel
                {
                    movieImage = p,

                }).FirstOrDefault();
            datas.listImagetype = imagetype;
            datas.listinvisible = invisible;
            return View(datas);
        }

        [HttpPost]
        public ActionResult Create(CCreateTravelProductViewModel newProduct)
        {
            MDAContext db = new MDAContext();
            電影圖片總表movieImage c = _context.電影圖片總表movieImages.FirstOrDefault(c => c.圖片編號imageId == newProduct.圖片編號imageId);


                if (newProduct.photo != null)
                {
                    foreach (IFormFile 圖片在這 in newProduct.photo)
                    {
                        電影圖片總表movieImage pic = new 電影圖片總表movieImage();
  
                        //pic.圖片編號imageId = _context.電影圖片總表movieImages.OrderBy(e => e.圖片編號imageId).LastOrDefault().圖片編號imageId+1;

                        string pname = Guid.NewGuid().ToString() + ".jpg";
                        pic.圖片image = pname;
                        string path = _enviro.WebRootPath + "/images/MovieImage/" + pname;

                        圖片在這.CopyTo(new FileStream(path, FileMode.Create));

                        _context.電影圖片總表movieImages.Add(pic);
                        _context.SaveChanges();
                    }
                }
            return RedirectToAction("List", "MovieImage");
            //if (newProduct._電影圖片總表movieImageDetail != null)
            //{
            //    foreach (var list in newProduct._電影圖片總表movieImageDetail)
            //    {
            //        電影圖片總表movieImageDetail tpd = new 電影圖片總表movieImageDetail();
            //        tpd.電影圖片總表movieImageId = _context.電影圖片總表movieImages.OrderBy(e => e.電影圖片總表movieImageId).LastOrDefault().電影圖片總表movieImageId;
            //        tpd.Day = list.Day;
            //        tpd.Date = list.Date;
            //        tpd.DailyDetailText = list.DailyDetailText;
            //        if (list.HotelId != -1)
            //            tpd.HotelId = list.HotelId;
            //        _context.電影圖片總表movieImageDetails.Add(tpd);
            //        _context.SaveChanges();
            //        int latest_DetailID = _context.電影圖片總表movieImageDetails.OrderBy(e => e.電影圖片總表movieImageDetailId).LastOrDefault().電影圖片總表movieImageDetailId;
            //        foreach (int TrasportationID in list.TrasportationID)
            //        {
            //            ProductToTransportation ptt = new ProductToTransportation
            //            {
            //                電影圖片總表movieImageDetailId = latest_DetailID,
            //                TrasportationId = TrasportationID,
            //            };
            //            _context.ProductToTransportations.Add(ptt);
            //        }
            //        foreach (int ViewID in list.ViewID)
            //        {
            //            if (ViewID != -1)
            //            {
            //                ProductToView ptv = new ProductToView
            //                {
            //                    電影圖片總表movieImageDetailId = latest_DetailID,
            //                    ViewId = ViewID,
            //                };
            //                _context.ProductToViews.Add(ptv);
            //            }
            //        }
            //        if (list._CreateView != null)
            //        {
            //            foreach (CreateView cv in list._CreateView)
            //            {
            //                View v = new View
            //                {
            //                    CityId = cv.CreateViewCityID,
            //                    ViewName = cv.CreateViewName,
            //                };
            //                _context.Views.Add(v);
            //                _context.SaveChanges();
            //                ProductToView ptv = new ProductToView
            //                {
            //                    電影圖片總表movieImageDetailId = latest_DetailID,
            //                    ViewId = _context.Views.OrderBy(e => e.ViewId).LastOrDefault().ViewId,
            //                };
            //                _context.ProductToViews.Add(ptv);
            //            }
            //            _context.SaveChanges();
            //        }

            //        _context.SaveChanges();
            //    }
            //}


        }
    }
}
