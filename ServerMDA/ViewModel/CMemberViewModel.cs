using Microsoft.AspNetCore.Http;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CMemberViewModel
    {
        private 會員member _member;
        public 會員member member
        {
            get { return _member; }
            set { _member = value; }
        }
        public CMemberViewModel()
        {
            _member = new 會員member();  //每做一個就建一個
        }
        [DisplayName("會員編號")]
        public int 會員編號memberId
        {
            get { return _member.會員編號memberId; }
            set { _member.會員編號memberId = value; }
        }
        [DisplayName("電話")]
        public string 會員電話cellphone
        {
            get { return _member.會員電話cellphone = _member.會員電話cellphone.Substring(0, 4) + "****" + _member.會員電話cellphone.Substring(8); }
            set { _member.會員電話cellphone = value; }
        }
        [DisplayName("密碼")]

        public string 密碼password
        {
            get { return _member.密碼password; }
            set { _member.密碼password = value; }
        }
        [DisplayName("姓氏")]
        public string 姓氏lName
        {
            get { return _member.姓氏lName; }
            set { _member.姓氏lName = value; }
        }
        [DisplayName("名字")]
        public string 名字fName
        {
            get { return _member.名字fName; }
            set { _member.名字fName = value; }
        }
        //{
        //    get { return _member.名字fName = _member.名字fName.Substring(0, 0) + "O" + _member.名字fName.Substring(1); }
        //    set { _member.名字fName = value; }
        //}
        [DisplayName("暱稱")]
        public string 暱稱nickName
        {
            get { return _member.暱稱nickName; }
            set { _member.暱稱nickName = value; }
        }
        [DisplayName("生日")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]

        public DateTime? 生日birthDate
        {
            get { return _member.生日birthDate; }
            set { _member.生日birthDate = value; }
        }
        [DisplayName("性別")]
        public int? 性別gender
        {
            get { return _member.性別gender; }
            set { _member.性別gender = value; }
        }
        [DisplayName("電子信箱")]
        public string 電子信箱email
        {
            get { return _member.電子信箱email; }
            set { _member.電子信箱email = value; }
        }
        [DisplayName("地址")]
        public string 地址address
        {
            get { return _member.地址address; }
            set { _member.地址address = value; }
        }
        [DisplayName("紅利點數")]
        public int? 紅利點數bonus
        {
            get { return _member.紅利點數bonus; }
            set { _member.紅利點數bonus = value; }
        }
        [DisplayName("正式會員")]
        public bool 正式會員formal
        {
            get { return _member.正式會員formal; }
            set { _member.正式會員formal = value; }
        }
        [DisplayName("權限")]
        public int 會員權限permission
        {
            get { return _member.會員權限permission; }
            set { _member.會員權限permission = value; }
        }
        [DisplayName("照片")]
        public string 會員照片image
        {
            get { return _member.會員照片image; }
            set { _member.會員照片image = value; }
        }
        [DisplayName("建立時間")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]

        public DateTime 建立時間createdTime
        {
            get { return _member.建立時間createdTime; }
            set { _member.建立時間createdTime = value; }
        }
        public IFormFile photo { get; set; }

        //public virtual 性別gender 性別genderNavigation { get; set; }
        public int 性別gender1 { get; set; }
        [DisplayName("性別")]
        public string 性別名稱genderName { get; set; }

        //public virtual 會員權限permission 會員權限permissionNavigation { get; set; }
        [DisplayName("會員權限")]
        public int 會員權限permission1 { get; set; }
        [DisplayName("權限")]

        public string 權限名稱permissionName { get; set; }

        //List
        //性別名稱genderName
        //權限名稱permissionName
        public List<string> ListGender { get; set; }
        public List<string> ListPermission { get; set; }
        public List<string> ListAddresses { get; set; }


        //public virtual ICollection<優惠明細couponList> 優惠明細couponLists { get; set; }
        //public int 會員編號memberId { get; set; }
        //public int 我的片單myMovieListId { get; set; } <<我的片單myMovieList
        //public int 片單總表編號movieListId { get; set; } <<我的片單myMovieList
        //public int 電影編號movieId { get; set; } <<我的片單myMovieList

        //public virtual ICollection<我的片單myMovieList> 我的片單myMovieLists { get; set; }
        //public int 會員編號memberId { get; set; }
        public int 我的片單myMovieListId { get; set; }
        public int 片單總表編號movieListId { get; set; }
        public int 電影編號movieId { get; set; }

        //public virtual ICollection<我的追蹤清單myFollowList> 我的追蹤清單myFollowLists { get; set; }
        //public int 會員編號memberId { get; set; }
        public int 我的追蹤清單編號cfId { get; set; }
        public int 對象targetId { get; set; }
        public int 追讚倒編號actionTypeId { get; set; }
        public int 連接編號connectId { get; set; }
        public string 檢舉理由reportReason { get; set; }
        public int? 處理狀態status { get; set; }

        //public virtual ICollection<訂單總表order> 訂單總表orders { get; set; }
        //public int 會員編號memberId { get; set; }
        public int 訂單編號orderId { get; set; }
        public DateTime 訂單時間orderTime { get; set; }
        public int 場次編號screeningId { get; set; }
        public int 訂單狀態編號orderStatusId { get; set; }


        public List<優惠總表coupon> 優惠總表coupon { get; set; }
        public List<string> 優惠名稱Coupon_Name { get; set; }
        public List<會員權限permission> 會員權限PermissionS { get; set; }
    }
}
