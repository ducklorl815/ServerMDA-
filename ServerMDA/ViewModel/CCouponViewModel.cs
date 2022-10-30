using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            _coupon = new 優惠總表coupon();
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
        private 優惠總表coupon _coupon;
        public 優惠總表coupon coupon
        {
            get { return _coupon; }
            set { _coupon = value; }
        }

        //public int 優惠編號couponId { get; set; }
        [DisplayName("優惠名稱")]
        public string 優惠名稱couponName
        {
            get { return _coupon.優惠名稱couponName; }
            set { _coupon.優惠名稱couponName = value; }
        }
        [DisplayName("優惠折扣")]
        public decimal 優惠折扣couponDiscount
        {
            get { return _coupon.優惠折扣couponDiscount; }
            set { _coupon.優惠折扣couponDiscount = value; }
        }
        [DisplayName("優惠代碼")]
        public string 優惠代碼couponCode
        {
            get { return _coupon.優惠代碼couponCode; }
            set { _coupon.優惠代碼couponCode = value; }
        }
        [DisplayName("優惠截止日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime 優惠截止日期couponDueDate
        {
            get { return _coupon.優惠截止日期couponDueDate; }
            set { _coupon.優惠截止日期couponDueDate = value; }
        }
        [DisplayName("優惠所需紅利")]
        public int 優惠所需紅利bonusCost
        {
            get { return _coupon.優惠所需紅利bonusCost; }
            set { _coupon.優惠所需紅利bonusCost = value; }
        }
        //public virtual 會員member 會員編號member { get; set; }
        //public int 會員編號memberId { get; set; }
        [DisplayName("會員電話")]
        public string 會員電話cellphone { get; set; }
        [DisplayName("姓氏")]
        public string 姓氏lName { get; set; }
        [DisplayName("名字")]
        public string 名字fName { get; set; }
        public List<string> titleName { get; set; }
        public List<string> titleCou { get; set; }
    }
}
