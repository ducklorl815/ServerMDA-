using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace ServerMDA.Models
{
    public partial class 電影評論movieComment
    {
        public 電影評論movieComment()
        {
            回覆樓數floors = new HashSet<回覆樓數floor>();
            標籤明細hashtagsLists = new HashSet<標籤明細hashtagsList>();
            評論圖片明細commentImagesLists = new HashSet<評論圖片明細commentImagesList>();
        }
        [DisplayName("評論編號")]
        public int 評論編號commentId { get; set; }
        [DisplayName("會員編號")]
        public int 會員編號memberId { get; set; }
        [DisplayName("電影編號")]
        public int 電影編號movieId { get; set; }
        [DisplayName("評分")]
        public decimal? 評分rate { get; set; }
        [DisplayName("期待度")]
        public decimal? 期待度anticipation { get; set; }
        [DisplayName("標題")]
        public string 評論標題commentTitle { get; set; }
        [DisplayName("內容")]
        public string 評論內容comments { get; set; }
        [DisplayName("發佈時間")]
        public DateTime 發佈時間commentTime { get; set; }
        [DisplayName("觀影日期")]
        public DateTime? 觀影日期viewingTime { get; set; }
        [DisplayName("觀影方式")]
        public string 觀影方式source { get; set; }
        [DisplayName("公開等級")]
        public int? 公開等級編號publicId { get; set; }
        [DisplayName("是否開放")]
        public bool? 是否開放討論串oxFloor { get; set; }
        [DisplayName("屏蔽")]
        public int 屏蔽invisible { get; set; }
        [DisplayName("公開等級")]
        public virtual 公開等級編號publicId 公開等級編號public { get; set; }
        [DisplayName("電影編號")]
        public virtual 電影movie 電影編號movie { get; set; }
        public virtual ICollection<回覆樓數floor> 回覆樓數floors { get; set; }
        public virtual ICollection<標籤明細hashtagsList> 標籤明細hashtagsLists { get; set; }
        public virtual ICollection<評論圖片明細commentImagesList> 評論圖片明細commentImagesLists { get; set; }
    }
}
