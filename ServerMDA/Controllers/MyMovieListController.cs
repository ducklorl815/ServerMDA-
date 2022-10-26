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
    }
}
