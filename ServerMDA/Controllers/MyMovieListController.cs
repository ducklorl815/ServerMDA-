using Microsoft.AspNetCore.Mvc;
using ServerMDA.Models;
using ServerMDA.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.Controllers
{
    public class MyMovieListController : Controller
    {
        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CMyMovieListViewModel> datas = null;
            datas = db.我的片單myMovieLists.Select
            (p => new CMyMovieListViewModel
            {
                myMovieList = p,
                片單總表名稱listName = p.片單總表編號movieList.片單總表名稱listName,
                會員電話cellphone = p.會員編號member.會員電話cellphone,
                姓氏lName = p.會員編號member.姓氏lName,
                名字fName = p.會員編號member.名字fName,
                暱稱nickName = p.會員編號member.暱稱nickName,
                中文標題titleCht = p.電影編號movie.中文標題titleCht,
                英文標題titleEng = p.電影編號movie.英文標題titleEng,
            }).ToList();

            return View(datas);
        }
        public ActionResult Edit(int? id)
        {
            MDAContext db = new MDAContext();
            CMyMovieListViewModel datas = null;
            var 中文標題 = db.電影movies.Select(p => p.中文標題titleCht).ToList();

            datas = db.我的片單myMovieLists.Where(p => p.會員編號memberId == id).Select
                (p => new CMyMovieListViewModel
                {
                    titleCht中文標題 = 中文標題,
                    myMovieList = p,
                    片單總表名稱listName = p.片單總表編號movieList.片單總表名稱listName,
                    會員電話cellphone = p.會員編號member.會員電話cellphone,
                    姓氏lName = p.會員編號member.姓氏lName,
                    名字fName = p.會員編號member.名字fName,
                    暱稱nickName = p.會員編號member.暱稱nickName,
                    中文標題titleCht = p.電影編號movie.中文標題titleCht,
                    英文標題titleEng = p.電影編號movie.英文標題titleEng,

                }).FirstOrDefault();

            datas.titleCht中文標題 = 中文標題;

            return View(datas);
        }
        [HttpPost]
        public IActionResult Edit(CMyMovieListViewModel inLists) //post
        {
            MDAContext db = new MDAContext();
            我的片單myMovieList c = db.我的片單myMovieLists.FirstOrDefault(c => c.會員編號memberId == inLists.會員編號memberId);
            if (c != null)
            {
                c.片單總表編號movieListId = inLists.片單總表編號movieListId;
                //c.會員編號memberId = inLists.會員編號memberId;
                c.片單總表編號movieListId = db.片單總表movieLists.FirstOrDefault(p => p.片單總表名稱listName == inLists.片單總表名稱listName).片單總表編號movieListId;
                c.電影編號movieId = db.電影movies.FirstOrDefault(q => q.中文標題titleCht == inLists.中文標題titleCht).電影編號movieId;
                c.會員編號memberId = db.會員members.FirstOrDefault(q => q.會員電話cellphone == inLists.會員電話cellphone).會員編號memberId;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}
