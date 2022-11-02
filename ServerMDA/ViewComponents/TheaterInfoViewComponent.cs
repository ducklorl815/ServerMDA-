using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerMDA.Models;
using ServerMDA.ViewModel;

namespace ServerMDA.ViewComponents
{
    public class TheaterInfoViewComponent : ViewComponent
    {
        private MDAContext _MDA;

        public TheaterInfoViewComponent(MDAContext MDA)
        {
            _MDA = MDA;
            _MDA.影廳cinemas.ToList();
        }

        public IViewComponentResult Invoke(int theaterID)
        {
            int i = 0;
            List<CCinemaInfoViewModel> list = this._MDA.影廳cinemas.Where(c => c.電影院編號theaterId == theaterID).Select(c=>new CCinemaInfoViewModel {
                id=c.影廳編號cinemaId,
                type=c.廳種名稱cinemaClsName,
                seatMap=fn_顯示座位圖(c.座位資訊seatInfo),
                count=fn_計算座位數(c.座位資訊seatInfo)                
            }).ToList();
            foreach(var item in list)
            {
                item.name = CinemaNames[i];
                if (i < 10) 
                i++;
            }
                    
            return View(list);
        }



        private List<string> CinemaNames = new List<string>()
        {
            "白金廳",
            "銀廳",
            "鑽石廳",
            "水銀廳",
            "山銅廳",
            "寶石廳",
            "黃金廳",
            "琥珀廳",
            "翡翠廳",
            "珍珠廳",
            "紫晶廳",
            "石頭廳"
        };
        private static string fn_顯示座位圖(string seatInfo)
        {           
            seatInfo = seatInfo.Replace('@', '#');
            return seatInfo;
        }
        private static int fn_計算座位數(string seatInfo)
        {
            string[] seatArr = seatInfo.Split('@');
            int count = 0;
            foreach (string item in seatArr)
            {
                if (!(item.Contains("NA")) && !(item.Contains("saled")) && !(string.IsNullOrWhiteSpace(item)) && !(item.Contains("||")) && !(string.IsNullOrEmpty(item)))
                    count++;
            }
            return count;
        }

    }
}
