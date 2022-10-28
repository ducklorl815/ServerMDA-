using Microsoft.AspNetCore.Mvc;
using ServerMDA.Models;
using ServerMDA.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<COrdersViewModel> datas = null;
            datas = db.訂單總表orders.Select
            (p => new COrdersViewModel
            {
                order = p,

                會員電話cellphone = p.會員編號member.會員電話cellphone,
                姓氏lName = p.會員編號member.姓氏lName,
                名字fName = p.會員編號member.名字fName,

                訂單狀態orderStatusName = p.訂單狀態編號orderStatus.訂單狀態orderStatusName,

                影廳編號cinemaId = p.場次編號screening.影廳編號cinemaId,
                電影代碼movieCode = p.場次編號screening.電影代碼movieCode,
                放映日期playDate = p.場次編號screening.放映日期playDate,
                放映開始時間playTime = p.場次編號screening.放映開始時間playTime,

            }).ToList();

            return View(datas);
        }
    }
}
