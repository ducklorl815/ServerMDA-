using Microsoft.AspNetCore.Http;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            get { return _member.會員電話cellphone; }
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
        [DisplayName("暱稱")]
        public string 暱稱nickName
        {
            get { return _member.暱稱nickName; }
            set { _member.暱稱nickName = value; }
        }
        [DisplayName("生日")]
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
    }
}
