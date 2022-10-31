using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CCommentViewModel
    {
        private 電影評論movieComment _comment;
        public 電影評論movieComment comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        public CCommentViewModel()
        {
            _comment = new 電影評論movieComment();  //每做一個就建一個
        }
        [DisplayName("評論編號")]
        public int 評論編號commentId
        {
            get { return _comment.評論編號commentId; }
            set { _comment.評論編號commentId = value; }
        }
        [DisplayName("會員編號")]
        public int 會員編號memberId
        {
            get { return _comment.會員編號memberId; }
            set { _comment.會員編號memberId = value; }
        }
        [DisplayName("電影編號")]
        public int 電影編號movieId
        {
            get { return _comment.電影編號movieId; }
            set { _comment.電影編號movieId = value; }
        }
        [DisplayName("評分")]
        public decimal? 評分rate
        {
            get { return _comment.評分rate; }
            set { _comment.評分rate = value; }
        }
        [DisplayName("期待度")]
        public decimal? 期待度anticipation
        {
            get { return _comment.期待度anticipation; }
            set { _comment.期待度anticipation = value; }
        }
        [DisplayName("標題")]
        public string 評論標題commentTitle
        {
            get { return _comment.評論標題commentTitle; }
            set { _comment.評論標題commentTitle = value; }
        }
        [DisplayName("內容")]
        public string 評論內容comments
        {
            get { return _comment.評論內容comments; }
            set { _comment.評論內容comments = value; }
        }
        [DisplayName("發佈時間")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime 發佈時間commentTime
        {
            get { return _comment.發佈時間commentTime; }
            set { _comment.發佈時間commentTime = value; }
        }
        [DisplayName("觀影日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime? 觀影日期viewingTime
        {
            get { return _comment.觀影日期viewingTime; }
            set { _comment.觀影日期viewingTime = value; }
        }
        [DisplayName("觀影方式")]
        public string 觀影方式source
        {
            get { return _comment.觀影方式source; }
            set { _comment.觀影方式source = value; }
        }
        [DisplayName("公開等級")]
        public int? 公開等級編號publicId
        {
            get { return _comment.公開等級編號publicId; }
            set { _comment.公開等級編號publicId = value; }
        }
        [DisplayName("開放留言")]
        public bool? 是否開放討論串oxFloor
        {
            get { return _comment.是否開放討論串oxFloor; }
            set { _comment.是否開放討論串oxFloor = value; }
        }
        [DisplayName("屏蔽")]
        public int 屏蔽invisible
        {
            get { return _comment.屏蔽invisible; }
            set { _comment.屏蔽invisible = value; }
        }

        //public virtual 公開等級編號publicId 公開等級編號public { get; set; }
        //public int 公開等級編號publicId { get; set; }
        [DisplayName("公開等級")]
        public string 公開等級public { get; set; }

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

        //public virtual 電影movie 電影編號movie { get; set; }
        [DisplayName("電影名稱")]
        public string 中文標題titleCht { get; set; }
        [DisplayName("英文標題")]
        public string 英文標題titleEng { get; set; }
        public List<int> titleInvis { get; set; }
    }
}
