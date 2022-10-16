using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace ServerMDA.Models
{
    public partial class 會員member
    {
        public 會員member()
        {
            優惠明細couponLists = new HashSet<優惠明細couponList>();
            我的片單myMovieLists = new HashSet<我的片單myMovieList>();
            我的追蹤清單myFollowLists = new HashSet<我的追蹤清單myFollowList>();
            訂單總表orders = new HashSet<訂單總表order>();
        }
        [DisplayName("會員編號")]
        public int 會員編號memberId { get; set; }
        [DisplayName("電話")]
        public string 會員電話cellphone { get; set; }
        [DisplayName("密碼")]
        public string 密碼password { get; set; }
        [DisplayName("姓氏")]
        public string 姓氏lName { get; set; }
        [DisplayName("名字")]
        public string 名字fName { get; set; }
        [DisplayName("暱稱")]
        public string 暱稱nickName { get; set; }
        [DisplayName("生日")]
        public DateTime? 生日birthDate { get; set; }
        [DisplayName("性別")]
        public int? 性別gender { get; set; }
        [DisplayName("電子信箱")]
        public string 電子信箱email { get; set; }
        [DisplayName("地址")]
        public string 地址address { get; set; }
        [DisplayName("紅利點數")]
        public int? 紅利點數bonus { get; set; }
        [DisplayName("正式會員")]
        public bool 正式會員formal { get; set; }
        [DisplayName("權限")]
        public int 會員權限permission { get; set; }
        [DisplayName("照片")]
        public string 會員照片image { get; set; }
        [DisplayName("建立時間")]
        public DateTime 建立時間createdTime { get; set; }
        [DisplayName("性別")]
        public virtual 性別gender 性別genderNavigation { get; set; }
        [DisplayName("會員權限")]
        public virtual 會員權限permission 會員權限permissionNavigation { get; set; }
        public virtual ICollection<優惠明細couponList> 優惠明細couponLists { get; set; }
        public virtual ICollection<我的片單myMovieList> 我的片單myMovieLists { get; set; }
        public virtual ICollection<我的追蹤清單myFollowList> 我的追蹤清單myFollowLists { get; set; }
        public virtual ICollection<訂單總表order> 訂單總表orders { get; set; }
    }
}
