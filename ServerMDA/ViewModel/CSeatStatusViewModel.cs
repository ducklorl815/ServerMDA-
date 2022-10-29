using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CSeatStatusViewModel
    {
        private 出售座位狀態seatStatus _seatStatus;
        public 出售座位狀態seatStatus seatStatus
        {
            get { return _seatStatus; }
            set { _seatStatus = value; }
        }
        public CSeatStatusViewModel()
        {
            _seatStatus = new 出售座位狀態seatStatus();  //每做一個就建一個
        }
        [DisplayName("出售座位編號")]
        public int 出售座位編號seatId
        {
            get { return _seatStatus.出售座位編號seatId; }
            set { _seatStatus.出售座位編號seatId = value; }
        }
        [DisplayName("場次編號")]
        public int 場次編號screeningId
        {
            get { return _seatStatus.場次編號screeningId; }
            set { _seatStatus.場次編號screeningId = value; }
        }
        [DisplayName("出售座位資訊")]
        public string 出售座位資訊seatSoldInfo
        {
            get { return _seatStatus.出售座位資訊seatSoldInfo; }
            set { _seatStatus.出售座位資訊seatSoldInfo = value; }
        }

        //public virtual 場次screening 場次編號screening { get; set; }
        // public int 場次編號screeningId { get; set; }
        [DisplayName("影廳編號")]
        public int 影廳編號cinemaId { get; set; }
        [DisplayName("電影代碼")]
        public int 電影代碼movieCode { get; set; }
        [DisplayName("放映日期")]
        public DateTime 放映日期playDate { get; set; }
        [DisplayName("放映開始時間")]
        public string 放映開始時間playTime { get; set; }
    }
}
