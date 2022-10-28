using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CCouponViewModel
    {
        private 優惠明細couponList _couponList;
        public 優惠明細couponList couponList
        {
            get { return _couponList; }
            set { _couponList = value; }
        }
        public CCouponViewModel()
        {
            _couponList = new 優惠明細couponList();  //每做一個就建一個
        }
        [DisplayName("優惠明細編號")]
        public int 優惠明細編號couponListId
        {
            get { return _couponList.優惠明細編號couponListId; }
            set { _couponList.優惠明細編號couponListId = value; }
        }
        [DisplayName("會員編號")]
        public int 會員編號memberId
        {
            get { return _couponList.會員編號memberId; }
            set { _couponList.會員編號memberId = value; }
        }
        [DisplayName("優惠編號")]
        public int 優惠編號couponId
        {
            get { return _couponList.優惠編號couponId; }
            set { _couponList.優惠編號couponId = value; }
        }
        [DisplayName("是否使用")]
        public bool 是否使用優惠oxCouponUsing
        {
            get { return _couponList.是否使用優惠oxCouponUsing; }
            set { _couponList.是否使用優惠oxCouponUsing = value; }
        }
        [DisplayName("訂單編號")]
        public int 訂單編號orderId
        {
            get { return _couponList.訂單編號orderId; }
            set { _couponList.訂單編號orderId = value; }
        }
        //public virtual 優惠總表coupon 優惠編號coupon { get; set; }
        //public int 優惠編號couponId { get; set; }
        [DisplayName("優惠名稱")]
        public string 優惠名稱couponName { get; set; }
        [DisplayName("優惠折扣")]
        public decimal 優惠折扣couponDiscount { get; set; }
        [DisplayName("優惠代碼")]
        public string 優惠代碼couponCode { get; set; }
        [DisplayName("優惠截止日期")]
        public DateTime 優惠截止日期couponDueDate { get; set; }
        [DisplayName("優惠所需紅利")]
        public int 優惠所需紅利bonusCost { get; set; }
        //public virtual 會員member 會員編號member { get; set; }
        //public int 會員編號memberId { get; set; }
        [DisplayName("會員電話")]
        public string 會員電話cellphone { get; set; }
        [DisplayName("姓氏")]
        public string 姓氏lName { get; set; }
        [DisplayName("名字")]
        public string 名字fName { get; set; }
    }
}
