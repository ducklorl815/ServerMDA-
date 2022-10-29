using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CScreeningViewModel
    {
        private 場次screening _screening;
        public 場次screening screening
        {
            get { return _screening; }
            set { _screening = value; }
        }
        public CScreeningViewModel()
        {
            _screening = new 場次screening();  //每做一個就建一個
        }
        [DisplayName("場次編號")]
        public int 場次編號screeningId
        {
            get { return _screening.場次編號screeningId; }
            set { _screening.場次編號screeningId = value; }
        }
        [DisplayName("影廳編號")]
        public int 影廳編號cinemaId
        {
            get { return _screening.影廳編號cinemaId; }
            set { _screening.影廳編號cinemaId = value; }
        }
        [DisplayName("電影代碼")]
        public int 電影代碼movieCode
        {
            get { return _screening.電影代碼movieCode; }
            set { _screening.電影代碼movieCode = value; }
        }
        [DisplayName("放映日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime 放映日期playDate
        {
            get { return _screening.放映日期playDate; }
            set { _screening.放映日期playDate = value; }
        }
        [DisplayName("放映開始時間")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public string 放映開始時間playTime
        {
            get { return _screening.放映開始時間playTime; }
            set { _screening.放映開始時間playTime = value; }
        }

        public virtual 影廳cinema 影廳編號cinema { get; set; }
        //public int 影廳編號cinemaId { get; set; }
        public string 影廳名稱cinemaName { get; set; }
        public int 電影院編號theaterId { get; set; }
        public string 廳種名稱cinemaClsName { get; set; }
        public string 座位資訊seatInfo { get; set; }
        public string 影廳照片image { get; set; }
        public virtual 電影代碼movieCode 電影代碼movieCodeNavigation { get; set; }
        public int 電影代碼編號movieCodeId { get; set; }
        public int 電影編號movieId { get; set; }
        public int 語言編號languageId { get; set; }

    }
}
