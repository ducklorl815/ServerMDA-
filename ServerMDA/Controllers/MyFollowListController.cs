using Microsoft.AspNetCore.Mvc;
using ServerMDA.Models;
using ServerMDA.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.Controllers
{
    public class MyFollowListController : Controller
    {
        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CMyFollowListViewModel> datas = null;
            datas = db.我的追蹤清單myFollowLists.Where(p=>p.處理狀態status==0).Select
            (p => new CMyFollowListViewModel
            {
                myFollowList = p,
                對象名稱targetName = p.對象target.對象名稱targetName,
                會員電話cellphone = p.會員編號member.會員電話cellphone,
                姓氏lName = p.會員編號member.姓氏lName,
                名字fName = p.會員編號member.名字fName,
                追讚倒名稱actionTypeName = p.追讚倒編號actionType.追讚倒名稱actionTypeName,
            }).ToList();

            return View(datas);
        }
        public ActionResult Edit(int? id)
        {
            MDAContext db = new MDAContext();
            CMyFollowListViewModel datas = null;
            //var rating = db.電影分級movieRatings.Select(p => p.分級級數ratingLevel).ToList();
            //var series = db.系列電影movieSeries.Select(p => p.系列名稱seriesName).ToList();
            datas = db.我的追蹤清單myFollowLists.Where(p => p.會員編號memberId == id).Select
                (p => new CMyFollowListViewModel
                {
                    myFollowList = p,
                    對象名稱targetName = p.對象target.對象名稱targetName,
                    會員電話cellphone = p.會員編號member.會員電話cellphone,
                    姓氏lName = p.會員編號member.姓氏lName,
                    名字fName = p.會員編號member.名字fName,
                    追讚倒名稱actionTypeName = p.追讚倒編號actionType.追讚倒名稱actionTypeName,

                }).FirstOrDefault();
            //datas.listrating = rating;
            //datas.listseries = series;
            return View(datas);
        }
        [HttpPost]
        public IActionResult Edit(CMyFollowListViewModel inList) //post
        {
            MDAContext db = new MDAContext();
            我的追蹤清單myFollowList c = db.我的追蹤清單myFollowLists.FirstOrDefault(c => c.會員編號memberId == inList.會員編號memberId);
            if (c != null)
            {
                c.會員編號memberId = inList.會員編號memberId;
                c.對象targetId = inList.對象targetId;
                c.追讚倒編號actionTypeId = inList.追讚倒編號actionTypeId;
                c.連接編號connectId = inList.連接編號connectId;
                c.檢舉理由reportReason = inList.檢舉理由reportReason;
                c.處理狀態status = inList.處理狀態status;
                c.對象targetId = db.對象targets.FirstOrDefault(p=>p.對象名稱targetName== inList.對象名稱targetName).對象targetId;
                c.會員編號memberId = db.會員members.FirstOrDefault(p => p.會員電話cellphone == inList.會員電話cellphone).會員編號memberId;
                c.追讚倒編號actionTypeId = db.追讚倒actionTypes.FirstOrDefault(p => p.追讚倒名稱actionTypeName == inList.追讚倒名稱actionTypeName).追讚倒編號actionTypeId;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}
