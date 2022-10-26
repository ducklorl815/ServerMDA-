using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CMyFollowListViewModel
    {
        private 我的追蹤清單myFollowList _myFollowList;
        public 我的追蹤清單myFollowList myFollowList
        {
            get { return _myFollowList; }
            set { _myFollowList = value; }
        }
        public CMyFollowListViewModel()
        {
            _myFollowList = new 我的追蹤清單myFollowList();  //每做一個就建一個
        }
        [DisplayName("追蹤清單編號")]
        public int 我的追蹤清單編號cfId
        {
            get { return _myFollowList.我的追蹤清單編號cfId; }
            set { _myFollowList.我的追蹤清單編號cfId = value; }
        }
        [DisplayName("會員編號")]
        public int 會員編號memberId
        {
            get { return _myFollowList.會員編號memberId; }
            set { _myFollowList.會員編號memberId = value; }
        }
        [DisplayName("對象ID")]
        public int 對象targetId
        {
            get { return _myFollowList.對象targetId; }
            set { _myFollowList.對象targetId = value; }
        }
        [DisplayName("追讚倒ID")]
        public int 追讚倒編號actionTypeId
        {
            get { return _myFollowList.追讚倒編號actionTypeId; }
            set { _myFollowList.追讚倒編號actionTypeId = value; }
        }
        [DisplayName("連接編號ID")]
        public int 連接編號connectId
        {
            get { return _myFollowList.連接編號connectId; }
            set { _myFollowList.連接編號connectId = value; }
        }
        [DisplayName("檢舉理由")]
        public string 檢舉理由reportReason
        {
            get { return _myFollowList.檢舉理由reportReason; }
            set { _myFollowList.檢舉理由reportReason = value; }
        }
        [DisplayName("處理狀態")]
        public int? 處理狀態status
        {
            get { return _myFollowList.處理狀態status; }
            set { _myFollowList.處理狀態status = value; }
        }

        //public virtual 對象target 對象target { get; set; }
        //public int 對象targetId { get; set; }
        [DisplayName("對象狀態")]
        public string 對象名稱targetName { get; set; }

        //public virtual 會員member 會員編號member { get; set; }
        [DisplayName("會員電話")]
        public string 會員電話cellphone { get; set; }
        [DisplayName("姓")]
        public string 姓氏lName { get; set; }
        [DisplayName("名")]
        public string 名字fName { get; set; }
        [DisplayName("對象姓氏")]
        public string 對象姓氏lName { get; set; }
        [DisplayName("對象名字")]
        public string 對象名字fName { get; set; }

        //public virtual 追讚倒actionType 追讚倒編號actionType { get; set; }
        //public int 追讚倒編號actionTypeId { get; set; }
        [DisplayName("追讚倒名稱")]
        public string 追讚倒名稱actionTypeName { get; set; }
    }
}
