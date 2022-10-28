using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class COrdersViewModel
    {
        private 訂單總表order _order;
        public 訂單總表order order
        {
            get { return _order; }
            set { _order = value; }
        }
        public COrdersViewModel()
        {
            _order = new 訂單總表order();  //每做一個就建一個
        }
        [DisplayName("訂單編號")]
        public int 訂單編號orderId
        {
            get { return _order.訂單編號orderId; }
            set { _order.訂單編號orderId = value; }
        }
        [DisplayName("會員編號")]
        public int 會員編號memberId
        {
            get { return _order.會員編號memberId; }
            set { _order.會員編號memberId = value; }
        }
        [DisplayName("訂單時間")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime 訂單時間orderTime
        {
            get { return _order.訂單時間orderTime; }
            set { _order.訂單時間orderTime = value; }
        }
        [DisplayName("場次編號")]
        public int 場次編號screeningId
        {
            get { return _order.場次編號screeningId; }
            set { _order.場次編號screeningId = value; }
        }
        [DisplayName("訂單狀態")]
        public int 訂單狀態編號orderStatusId
        {
            get { return _order.訂單狀態編號orderStatusId; }
            set { _order.訂單狀態編號orderStatusId = value; }
        }

        //public virtual 場次screening 場次編號screening { get; set; }
        //public int 場次編號screeningId { get; set; }
        [DisplayName("影廳編號")]
        public int 影廳編號cinemaId { get; set; }
        [DisplayName("電影代碼")]
        public int 電影代碼movieCode { get; set; }

        [DisplayName("放映日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime 放映日期playDate { get; set; }

        [DisplayName("放映開始時間")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public string 放映開始時間playTime { get; set; }

        //public virtual 會員member 會員編號member { get; set; }
        //public int 會員編號memberId { get; set; }
        [DisplayName("會員電話")]
        public string 會員電話cellphone { get; set; }
        [DisplayName("姓氏")]
        public string 姓氏lName { get; set; }
        [DisplayName("名字")]
        public string 名字fName { get; set; }
        //public virtual 訂單狀態orderStatus 訂單狀態編號orderStatus { get; set; }
        //public int 訂單狀態編號orderStatusId { get; set; }
        [DisplayName("訂單狀態")]
        public string 訂單狀態orderStatusName { get; set; }

    }
}
